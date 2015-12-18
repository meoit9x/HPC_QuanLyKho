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
    public partial class UCQuyCach : UserControl
    {
        List<dQC> ldqc;
        dQC dqc = new dQC();
        public UCQuyCach(List<dQC> ldqc)
        {
            InitializeComponent();
            this.ldqc = ldqc;
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
            chTenNhom.Text = "Tên quy cách";
            chTenNhom.Width = 317;
            chTenNhom.TextAlign = HorizontalAlignment.Center;
            lvNhomHang.Columns.Add(chTenNhom);

            lvNhomHang.GridLines = true;
            lvNhomHang.FullRowSelect = true;

            int i = 0;
            foreach (dQC qc in ldqc)
            {
                lvNhomHang.Items.Add((i + 1) + "");
                lvNhomHang.Items[i].SubItems.Add(qc.qten);
                i++;
            }

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            ldqc = SQC.SearchQuyCach(tbSearch.Text);
            Load_LvNhomHang();
        }

        private void btTao_Click(object sender, EventArgs e)
        {
            tbSearch.Text = "";
            if ("".Equals(tbNVT.Text))
            {
                lbLoi.Text = "Quy cách không được để trống.";
                return;
            }
            if (btThoat.Visible == true)
            {
                dqc.qten = tbNVT.Text;
                ldqc = SQC.EditQC(dqc, tbSearch.Text);
                Load_LvNhomHang();
                lbLoi.Text = "Sửa thành công.";
            }
            else
            {
                dQC qc = new dQC();
                qc.qten = tbNVT.Text;
                ldqc = SQC.AddNewQC(qc, tbSearch.Text);
                Load_LvNhomHang();
                tbNVT.Text = "";
                lbLoi.Text = "Tạo mới thành công.";
            }
        }

        private void lvNhomHang_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            foreach (ListViewItem listviewItem in lvNhomHang.SelectedItems)
            {
                dqc = ldqc[listviewItem.Index];
                tbNVT.Text = dqc.qten;
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
            List<dQC> listQC = SQC.XoaQC(dqc, tbSearch.Text);
            if (listQC.Count == ldqc.Count)
                lbLoi.Text = "Không thể xóa quy cách.\nQuy cách này đã được sử dụng.";
            else
            {
                ldqc = new List<dQC>();
                ldqc = listQC;
                Load_LvNhomHang();
                DisplayEdit(false);
                lbLoi.Text = "Xóa thành công.";
            }
        }
    }
}
