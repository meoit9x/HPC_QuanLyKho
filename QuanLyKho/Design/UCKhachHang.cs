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
    public partial class UCKhachHang : UserControl
    {
        List<dKH> lKH;
        dKH dkh = new dKH();

        public UCKhachHang()
        {
            InitializeComponent();
        }

        private void UCKhachHang_Load(object sender, EventArgs e)
        {
            Load_LvKhachHang();
        }

        private void Load_LvKhachHang()
        {
            lKH = SKH.GetAll();
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
            chTenNhom.Text = "Tên khách hàng";
            chTenNhom.Width = 120;
            chTenNhom.TextAlign = HorizontalAlignment.Center;
            lvNhomHang.Columns.Add(chTenNhom);

            ColumnHeader chDiaChi;
            chDiaChi = new ColumnHeader();
            chDiaChi.Text = "Địa chỉ";
            chDiaChi.Width = 187;
            chDiaChi.TextAlign = HorizontalAlignment.Center;
            lvNhomHang.Columns.Add(chDiaChi);

            ColumnHeader chSoDienThoai;
            chSoDienThoai = new ColumnHeader();
            chSoDienThoai.Text = "Số điện thoại";
            chSoDienThoai.Width = 85;
            chSoDienThoai.TextAlign = HorizontalAlignment.Center;
            lvNhomHang.Columns.Add(chSoDienThoai);

            lvNhomHang.GridLines = true;
            lvNhomHang.FullRowSelect = true;

            int i = 0;
            foreach (dKH kh in lKH)
            {
                lvNhomHang.Items.Add((i + 1) + "");
                lvNhomHang.Items[i].SubItems.Add(kh.ten);
                lvNhomHang.Items[i].SubItems.Add(kh.diachi);
                lvNhomHang.Items[i].SubItems.Add(kh.dienthoai);
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
                tbDiaChi.Text = "";
                tbTenKH.Text = "";
                tbSoDienThoai.Text = "";
                lbLoi.Text = "";
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DisplayEdit(false);
        }

        private void btTao_Click(object sender, EventArgs e)
        {
            if ("".Equals(tbTenKH.Text))
            {
                lbLoi.Text = "Tên khách hàng không được để trống.";
                tbTenKH.Focus();
                return;
            }
            if ("".Equals(tbDiaChi.Text))
            {
                lbLoi.Text = "Địa chỉ khách hàng không được để trống.";
                tbDiaChi.Focus();
                return;
            }
            if ("".Equals(tbSoDienThoai.Text))
            {
                lbLoi.Text = "Số điện thoại khách hàng không được để trống.";
                tbSoDienThoai.Focus();
                return;
            }
            if (btThoat.Visible == true)
            {
                dkh.diachi = tbDiaChi.Text;
                dkh.dienthoai = tbSoDienThoai.Text;
                dkh.ten = tbTenKH.Text;
                Main.db.SaveChanges();
                lbLoi.Text = "Sửa thành công.";
            }
            else
            {
                dKH dkhTao = new dKH();
                dkhTao.diachi = tbDiaChi.Text;
                dkhTao.dienthoai = tbSoDienThoai.Text;
                dkhTao.ten = tbTenKH.Text;
                Main.db.dKH.Add(dkhTao);
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
                dkh = lKH[listviewItem.Index];
                tbTenKH.Text = dkh.ten;
                tbSoDienThoai.Text = dkh.dienthoai;
                tbDiaChi.Text = dkh.diachi;
            }

            DisplayEdit(true);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            Main.db.dKH.Remove(dkh);
            Main.db.SaveChanges();
            Load_LvKhachHang();
            DisplayEdit(false);
            lbLoi.Text = "Xóa thành công.";
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            lKH = SKH.SearchTen(tbSearch.Text);
            Load_LvKhachHang();
        }


    }
}
