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
    public partial class UNChuyen : UserControl
    {
        List<pC> lpc = new List<pC>();
        pC objPC = new pC();

        public UNChuyen()
        {
            InitializeComponent();
        }

        private void UNDieuChuyen_Load(object sender, EventArgs e)
        {
            lpc = SPhieuChuyen.GetPhieuChuyenDi();
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
            chDiaChi.Text = "Đơn vị nhận";
            chDiaChi.Width = 120;
            chDiaChi.TextAlign = HorizontalAlignment.Center;
            lvPhieuNhap.Columns.Add(chDiaChi);

            lvPhieuNhap.GridLines = true;
            lvPhieuNhap.FullRowSelect = true;

            int i = 0;
            foreach (pC pn in lpc)
            {
                lvPhieuNhap.Items.Add((i + 1) + "");
                lvPhieuNhap.Items[i].SubItems.Add(pn.cmaso);
                lvPhieuNhap.Items[i].SubItems.Add(Convert.ToString(pn.pdate));
                lvPhieuNhap.Items[i].SubItems.Add(Convert.ToString(pn.dK1.kten));
                i++;
            }
        }

        private void tbDenNgay_KeyUp(object sender, KeyEventArgs e)
        {
            lpc = new List<pC>();
            lpc = SPhieuChuyen.SearchPhieuChuyen(tbSoHoaDon.Text, tbTuNgay.Text, tbDenNgay.Text);
            Load_LvHoaDon();
        }

        private void tbTuNgay_KeyUp(object sender, KeyEventArgs e)
        {
            lpc = new List<pC>();
            lpc = SPhieuChuyen.SearchPhieuChuyen(tbSoHoaDon.Text, tbTuNgay.Text, tbDenNgay.Text);
            Load_LvHoaDon();
        }

        private void tbSoHoaDon_TextChanged(object sender, EventArgs e)
        {
            lpc = new List<pC>();
            lpc = SPhieuChuyen.SearchPhieuChuyen(tbSoHoaDon.Text, tbTuNgay.Text, tbDenNgay.Text);
            Load_LvHoaDon();
        }

        private void lvPhieuNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem listviewItem in lvPhieuNhap.SelectedItems)
            {
                objPC = lpc[listviewItem.Index];
            }
            
        }
        private void SetupFormChiTiet(pC objPC)
        {
            UNChuyenCT uncct = new UNChuyenCT(objPC);
            Main.pnParent.Controls.Clear();
            Main.pnParent.Controls.Add(uncct);
        }

        private void btHoanTat_Click(object sender, EventArgs e)
        {
            SetupFormChiTiet(null);
        }

        private void btChiTiet_Click(object sender, EventArgs e)
        {
            SetupFormChiTiet(objPC);
        }


    }
}
