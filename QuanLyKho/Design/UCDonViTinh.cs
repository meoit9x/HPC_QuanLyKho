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
    public partial class UCDonViTinh : UserControl
    {
        List<dDVT> lDVT;
        dDVT ddvt = new dDVT();
        public UCDonViTinh(List<dDVT> lDVT)
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
            chTenNhom.Text = "Đơn vị tính";
            chTenNhom.Width = 317;
            chTenNhom.TextAlign = HorizontalAlignment.Center;
            lvNhomHang.Columns.Add(chTenNhom);

            lvNhomHang.GridLines = true;
            lvNhomHang.FullRowSelect = true;

            int i = 0;
            foreach (dDVT nvt in lDVT)
            {
                lvNhomHang.Items.Add((i + 1) + "");
                lvNhomHang.Items[i].SubItems.Add(nvt.dvt);
                i++;
            }

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            lDVT = SDVT.SearchDVT(tbSearch.Text);
            Load_LvNhomHang();
        }

        private void btTao_Click(object sender, EventArgs e)
        {
            tbSearch.Text = "";
            if ("".Equals(tbNVT.Text))
            {
                lbLoi.Text = "Đơn vị tính không được để trống.";
                return;
            }
            if (btThoat.Visible == true)
            {
                ddvt.dvt = tbNVT.Text;
                lDVT = SDVT.EditDVT(ddvt, tbSearch.Text);
                Load_LvNhomHang();
                lbLoi.Text = "Sửa thành công.";
            }
            else
            {
                dDVT objDVT = new dDVT();
                objDVT.dvt = tbNVT.Text;
                lDVT = SDVT.AddNewDVT(objDVT, tbSearch.Text);
                Load_LvNhomHang();
                tbNVT.Text = "";
                lbLoi.Text = "Tạo thành công.";
            }
        }

        private void lvNhomHang_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            foreach (ListViewItem listviewItem in lvNhomHang.SelectedItems)
            {
                ddvt = lDVT[listviewItem.Index];
                tbNVT.Text = ddvt.dvt;
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
            List<dDVT> listDVT = SDVT.XoaDVT(ddvt, tbSearch.Text);
            if (listDVT.Count == lDVT.Count)
                lbLoi.Text = "Không thể xóa đơn vị tính.\nĐơn vị tính này đã được sử dụng.";
            else
            {
                lDVT = new List<dDVT>();
                lDVT = listDVT;
                Load_LvNhomHang();
                DisplayEdit(false);
                lbLoi.Text = "Xóa thành công.";
            }
        }
    }
}
