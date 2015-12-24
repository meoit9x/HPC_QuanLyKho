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
    public partial class UNNhap : UserControl
    {
        List<pN> lpn = new List<pN>();
        pN objPN = new pN();
        public UNNhap()
        {
            InitializeComponent();
        }

        private void btHoanTat_Click(object sender, EventArgs e)
        {
            Main.AddPhieuNhapCT(null);
        }

        private void UNHoaDon_Load(object sender, EventArgs e)
        {
            lpn = SPhieuNhap.GetAll();
            Load_LvHoaDon();
        }

        private void Load_LvHoaDon()
        {
            lvPhieuNhap.Items.Clear();
            lvPhieuNhap.Columns.Clear();
            lvPhieuNhap.View = View.Details;

            ColumnHeader chSTT;
            chSTT = new ColumnHeader();
            chSTT.Text = "STT";
            chSTT.Width = 40;
            chSTT.TextAlign = HorizontalAlignment.Center;
            lvPhieuNhap.Columns.Add(chSTT);

            ColumnHeader chMaVT;
            chMaVT = new ColumnHeader();
            chMaVT.Text = "Số hóa đơn";
            chMaVT.Width = 80;
            chMaVT.TextAlign = HorizontalAlignment.Center;
            lvPhieuNhap.Columns.Add(chMaVT);

            ColumnHeader chTenNhom;
            chTenNhom = new ColumnHeader();
            chTenNhom.Text = "Ngày hóa đơn";
            chTenNhom.Width = 120;
            chTenNhom.TextAlign = HorizontalAlignment.Center;
            lvPhieuNhap.Columns.Add(chTenNhom);

            ColumnHeader chDiaChi;
            chDiaChi = new ColumnHeader();
            chDiaChi.Text = "Ngày tạo";
            chDiaChi.Width = 120;
            chDiaChi.TextAlign = HorizontalAlignment.Center;
            lvPhieuNhap.Columns.Add(chDiaChi);


            lvPhieuNhap.GridLines = true;
            lvPhieuNhap.FullRowSelect = true;

            int i = 0;
            foreach (pN pn in lpn)
            {
                lvPhieuNhap.Items.Add((i + 1) + "");
                lvPhieuNhap.Items[i].SubItems.Add(pn.nmaso);
                lvPhieuNhap.Items[i].SubItems.Add(Convert.ToString(pn.ngayhd));
                lvPhieuNhap.Items[i].SubItems.Add(Convert.ToString(pn.ndate));
                i++;
            }
        }

        private void tbSoHoaDon_KeyUp(object sender, KeyEventArgs e)
        {
            lpn = new List<pN>();
            lpn = SPhieuNhap.SearchSoHoaDon(tbSoHoaDon.Text, tbTuNgay.Text, tbDenNgay.Text);
            Load_LvHoaDon();
        }

        private void tbDenNgay_KeyUp(object sender, KeyEventArgs e)
        {
            lpn = new List<pN>();
            lpn = SPhieuNhap.SearchSoHoaDon(tbSoHoaDon.Text, tbTuNgay.Text, tbDenNgay.Text);
            Load_LvHoaDon();
        }

        private void tbTuNgay_KeyUp(object sender, KeyEventArgs e)
        {
            lpn = new List<pN>();
            lpn = SPhieuNhap.SearchSoHoaDon(tbSoHoaDon.Text, tbTuNgay.Text, tbDenNgay.Text);
            Load_LvHoaDon();
        }

        private void lvPhieuNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem listviewItem in lvPhieuNhap.SelectedItems)
            {
                objPN = new pN();
                objPN = lpn[listviewItem.Index];
            }
        }

        private void btChiTiet_Click(object sender, EventArgs e)
        {
            Main.AddPhieuNhapCT(objPN);
        }
    }
}
