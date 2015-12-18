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
    public partial class UCMay : UserControl
    {
        List<dMay> lMay;
        dMay dmay = new dMay();

        public UCMay()
        {
            InitializeComponent();
        }

        private void UCMay_Load(object sender, EventArgs e)
        {

        }

        private void Load_LvKhachHang()
        {
            lMay = SMay.GetAll();
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
            chTenNhom.Text = "Mã số máy";
            chTenNhom.Width = 120;
            chTenNhom.TextAlign = HorizontalAlignment.Center;
            lvNhomHang.Columns.Add(chTenNhom);

            ColumnHeader chDiaChi;
            chDiaChi = new ColumnHeader();
            chDiaChi.Text = "Tên máy";
            chDiaChi.Width = 187;
            chDiaChi.TextAlign = HorizontalAlignment.Center;
            lvNhomHang.Columns.Add(chDiaChi);

            lvNhomHang.GridLines = true;
            lvNhomHang.FullRowSelect = true;

            int i = 0;
            foreach (dMay kh in lMay)
            {
                lvNhomHang.Items.Add((i + 1) + "");
                lvNhomHang.Items[i].SubItems.Add(kh.maso);
                lvNhomHang.Items[i].SubItems.Add(kh.tenmay);
                i++;
            }

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
                tbTenMay.Text = "";
                tbMaSo.Text = "";
                lbLoi.Text = "";
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DisplayEdit(false);
        }

        private void btTao_Click(object sender, EventArgs e)
        {
            if ("".Equals(tbMaSo.Text))
            {
                lbLoi.Text = "Mã số máy không được để trống.";
                tbMaSo.Focus();
                return;
            }

            if ("".Equals(tbTenMay.Text))
            {
                lbLoi.Text = "Tên máy không được để trống.";
                tbTenMay.Focus();
                return;
            }
            
            if (btThoat.Visible == true)
            {
                dmay.tenmay = tbTenMay.Text;
                dmay.maso = tbMaSo.Text;
                Main.db.SaveChanges();
                lbLoi.Text = "Sửa thành công.";
            }
            else
            {
                dmay = new dMay();
                dmay.tenmay = tbTenMay.Text;
                dmay.kid = Main.OBJ_KHO.kid;
                dmay.maso = tbMaSo.Text;
                Main.db.dMay.Add(dmay);
                Main.db.SaveChanges();
                lbLoi.Text = "Tạo thành công.";
                DisplayEdit(false);
            }
            Load_LvKhachHang();
        }

        private void lvNhomHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem listviewItem in lvNhomHang.SelectedItems)
            {
                dmay = lMay[listviewItem.Index];
                tbTenMay.Text = dmay.tenmay;
                tbMaSo.Text = dmay.maso;
            }

            DisplayEdit(true);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            Main.db.dMay.Remove(dmay);
            Main.db.SaveChanges();
            Load_LvKhachHang();
            DisplayEdit(false);
            lbLoi.Text = "Xóa thành công.";
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            lMay = SMay.SearchTen(tbSearch.Text);
            Load_LvKhachHang();
        }

    }
}
