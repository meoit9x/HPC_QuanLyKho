using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKho.Service;

namespace QuanLyKho.Design
{
    public partial class UCNhomVatTu : UserControl
    {
        List<dNVT> lDVT;
        dNVT dnvt = new dNVT();
        public UCNhomVatTu(List<dNVT> lDVT)
        {
            InitializeComponent();
            this.lDVT = lDVT;
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
            chTenNhom.Text = "Nhóm hàng";
            chTenNhom.Width = 317;
            chTenNhom.TextAlign = HorizontalAlignment.Center;
            lvNhomHang.Columns.Add(chTenNhom);

            lvNhomHang.GridLines = true;
            lvNhomHang.FullRowSelect = true;

            int i = 0;
            foreach (dNVT nvt in lDVT)
            {
                lvNhomHang.Items.Add((i + 1) + "");
                lvNhomHang.Items[i].SubItems.Add(nvt.tennhom);
                i++;
            }

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            lDVT = SNVatTu.SearchNVT(tbSearch.Text);
            Load_LvNhomHang();
        }

        private void btTao_Click(object sender, EventArgs e)
        {
            tbSearch.Text = "";
            if ("".Equals(tbNVT.Text))
            {
                lbLoi.Text = "Nhóm vật tư không được để trống.";
                return;
            }
            if (btThoat.Visible == true)
            {
                dnvt.tennhom = tbNVT.Text;
                lDVT = SNVatTu.EditNhomHang(dnvt, tbSearch.Text);
                Load_LvNhomHang();
                lbLoi.Text = "Sửa thành công.";
            }
            else
            {
                dNVT objNVT = new dNVT();
                objNVT.tennhom = tbNVT.Text;
                lDVT = SNVatTu.AddNewNhomHang(objNVT, tbSearch.Text);
                Load_LvNhomHang();
                tbNVT.Text = "";
                lbLoi.Text = "Tạo thành công.";
            }
        }

        private void lvNhomHang_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            foreach (ListViewItem listviewItem in lvNhomHang.SelectedItems)
            {
                dnvt = lDVT[listviewItem.Index];
                tbNVT.Text = dnvt.tennhom;
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
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DisplayEdit(false);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            List<dNVT> listVatTu = SNVatTu.XoaNhomHang(dnvt, tbSearch.Text);
            if (listVatTu.Count == lDVT.Count)
                lbLoi.Text = "Không thể xóa nhóm vật tư.\nNhóm vật tư này đã được sử dụng.";
            else
            {
                lDVT = new List<dNVT>();
                lDVT = listVatTu;
                Load_LvNhomHang();
                DisplayEdit(false);
                lbLoi.Text = "Xóa thành công.";
            }
        }

    }
}
