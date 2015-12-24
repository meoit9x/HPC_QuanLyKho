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
    public partial class UNSuDung : UserControl
    {
        private List<pSD> lsd = new List<pSD>();
        private pSD objSD = new pSD();

        public UNSuDung()
        {
            InitializeComponent();
        }

        private void btHoanTat_Click(object sender, EventArgs e)
        {
            Main.AddSuDungCT(null);
        }

        private void UNHoaDon_Load(object sender, EventArgs e)
        {
            lsd = SPhieuSuDung.GetSDAll();
            Load_LvHoaDon();
        }

        private void Load_LvHoaDon()
        {
            lvSuDung.Items.Clear();
            lvSuDung.Columns.Clear();
            lvSuDung.View = View.Details;

            ColumnHeader chSTT;
            chSTT = new ColumnHeader();
            chSTT.Text = "STT";
            chSTT.Width = 40;
            chSTT.TextAlign = HorizontalAlignment.Center;
            lvSuDung.Columns.Add(chSTT);

            ColumnHeader chMaVT;
            chMaVT = new ColumnHeader();
            chMaVT.Text = "Số hóa đơn";
            chMaVT.Width = 80;
            chMaVT.TextAlign = HorizontalAlignment.Center;
            lvSuDung.Columns.Add(chMaVT);

            ColumnHeader chDiaChi;
            chDiaChi = new ColumnHeader();
            chDiaChi.Text = "Ngày tạo";
            chDiaChi.Width = 120;
            chDiaChi.TextAlign = HorizontalAlignment.Center;
            lvSuDung.Columns.Add(chDiaChi);

            lvSuDung.GridLines = true;
            lvSuDung.FullRowSelect = true;

            int i = 0;
            foreach (pSD psd in lsd)
            {
                lvSuDung.Items.Add((i + 1) + "");
                lvSuDung.Items[i].SubItems.Add(psd.smaso);
                lvSuDung.Items[i].SubItems.Add(Convert.ToString(psd.sdate));
                i++;
            }
        }

        private void tbSoHoaDon_KeyUp(object sender, KeyEventArgs e)
        {
            lsd = new List<pSD>();
            lsd = SPhieuSuDung.SearchSoHoaDonSuDung(tbSoHoaDon.Text, tbTuNgay.Text, tbDenNgay.Text);
            Load_LvHoaDon();
        }

        private void tbDenNgay_KeyUp(object sender, KeyEventArgs e)
        {
            lsd = new List<pSD>();
            lsd = SPhieuSuDung.SearchSoHoaDonSuDung(tbSoHoaDon.Text, tbTuNgay.Text, tbDenNgay.Text);
            Load_LvHoaDon();
        }

        private void tbTuNgay_KeyUp(object sender, KeyEventArgs e)
        {
            lsd = new List<pSD>();
            lsd = SPhieuSuDung.SearchSoHoaDonSuDung(tbSoHoaDon.Text, tbTuNgay.Text, tbDenNgay.Text);
            Load_LvHoaDon();
        }

        private void lvSuDung_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem listviewItem in lvSuDung.SelectedItems)
            {
                objSD = lsd[listviewItem.Index];
            }
        }
        
        private void btChiTiet_Click(object sender, EventArgs e)
        {
            Main.AddSuDungCT(objSD);
        }
    }
}
