using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKho.Service;

namespace QuanLyKho.Design
{
    public partial class UCKho : UserControl
    {
        List<dK> lks;
        dK dk = new dK();
        public UCKho(List<dK> lks)
        {
            InitializeComponent();
            this.lks = lks;
            Load_LvNhomHang();
        }

        private void Load_LvNhomHang()
        {
            lvNhomHang.Items.Clear();
            lvNhomHang.Columns.Clear();
            lvNhomHang.View = View.Details;

            ColumnHeader chSTT;
            chSTT = new ColumnHeader();
            chSTT.Text = "STT";
            chSTT.Width = 40;
            chSTT.TextAlign = HorizontalAlignment.Center;
            lvNhomHang.Columns.Add(chSTT);

            ColumnHeader chTenNhom;
            chTenNhom = new ColumnHeader();
            chTenNhom.Text = "Tên kho";
            chTenNhom.Width = 80;
            chTenNhom.TextAlign = HorizontalAlignment.Center;
            lvNhomHang.Columns.Add(chTenNhom);

            ColumnHeader chTenKho;
            chTenKho = new ColumnHeader();
            chTenKho.Text = "Địa chỉ";
            chTenKho.Width = 237;
            chTenKho.TextAlign = HorizontalAlignment.Center;
            lvNhomHang.Columns.Add(chTenKho);

            lvNhomHang.GridLines = true;
            lvNhomHang.FullRowSelect = true;

            int i = 0;
            foreach (dK dk in lks)
            {
                lvNhomHang.Items.Add((i + 1) + "");
                lvNhomHang.Items[i].SubItems.Add(dk.kten);
                lvNhomHang.Items[i].SubItems.Add(dk.diachi);
                i++;
            }

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            lks = SKho.SearchKho();
            Load_LvNhomHang();
        }

        private void btTao_Click(object sender, EventArgs e)
        {
            if("".Equals(tbNVT.Text))
            {
                lbLoi.Text = "Tên kho không được để trống.";
                tbNVT.Focus();
                return;
            }
            if ("".Equals(tbDiaChi.Text))
            {
                lbLoi.Text = "Địa chỉ kho không được để trống.";
                tbDiaChi.Focus();
                return;
            }
            if (btThoat.Visible == true)
            {
                dk.kten = tbNVT.Text;
                dk.diachi = tbDiaChi.Text;
                lks = SKho.EditKho(dk);
                Load_LvNhomHang();
                lbLoi.Text = "Sửa thành công.";
            }
            else
            {
                dK objKho = new dK();
                objKho.kten = tbNVT.Text;
                dk.diachi = tbDiaChi.Text;
                lks = SKho.AddNewKho(objKho);
                Load_LvNhomHang();
                tbNVT.Text = "";
                lbLoi.Text = "Tạo mới thành công.";
            }
        }

        private void lvNhomHang_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            foreach (ListViewItem listviewItem in lvNhomHang.SelectedItems)
            {
                dk = lks[listviewItem.Index];
                tbNVT.Text = dk.kten;
            }

            DisplayEdit(true);
        }

        private void DisplayEdit(bool isShow)
        {
            btXoa.Visible = isShow;
            btThoat.Visible = isShow;
            if (isShow)
            {
                btTao.Text = "Sửa";
            }
            else
            {
                btTao.Text = "Tạo";
                tbNVT.Text = "";
                lbLoi.Text = "";
                tbDiaChi.Text = "";
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DisplayEdit(false);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (SKho.CheckXoaKho(dk))
            {
                lks = SKho.XoaKho(dk);
                Load_LvNhomHang();
                lbLoi.Text = "Xóa thành công.";
                DisplayEdit(false);
            }
            else
            {
                lbLoi.Text = "Không thể xóa kho này.";
                return;
            }
        }

        private void lvNhomHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem listviewItem in lvNhomHang.SelectedItems)
            {
                dk = lks[listviewItem.Index];
                tbNVT.Text = dk.kten;
                tbDiaChi.Text = dk.diachi;
            }
        }
    }
}
