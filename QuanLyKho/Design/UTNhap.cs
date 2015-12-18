using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrintingLinks;
using System.Text.RegularExpressions;
using QuanLyKho.Service;

namespace QuanLyKho.Design
{
    public partial class UTNhap : UserControl
    {
        List<pNCT> lpn;
        pNCT objPhieuNhap = new pNCT();

        public UTNhap(List<pNCT> lpn)
        {
            InitializeComponent();
            this.lpn = lpn;
            Load_LvVatTu();
        }

        private void Load_LvVatTu()
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

            ColumnHeader chTenVatTu;
            chTenVatTu = new ColumnHeader();
            chTenVatTu.Text = "Tên vật tư";
            chTenVatTu.Width = 125;
            chTenVatTu.TextAlign = HorizontalAlignment.Center;
            lvPhieuNhap.Columns.Add(chTenVatTu);

            ColumnHeader chSoLuong;
            chSoLuong = new ColumnHeader();
            chSoLuong.Text = "Số lượng";
            chSoLuong.Width = 55;
            chSoLuong.TextAlign = HorizontalAlignment.Center;
            lvPhieuNhap.Columns.Add(chSoLuong);

            ColumnHeader chMaSo;
            chMaSo = new ColumnHeader();
            chMaSo.Text = "Mã số";
            chMaSo.Width = 100;
            chMaSo.TextAlign = HorizontalAlignment.Center;
            lvPhieuNhap.Columns.Add(chMaSo);

            ColumnHeader chTime;
            chTime = new ColumnHeader();
            chTime.Text = "Thời gian tạo";
            chTime.Width = 120;
            chTime.TextAlign = HorizontalAlignment.Center;
            lvPhieuNhap.Columns.Add(chTime);

            lvPhieuNhap.GridLines = true;
            lvPhieuNhap.FullRowSelect = true;

            int i = 0;
            foreach (pNCT pn in lpn)
            {
                lvPhieuNhap.Items.Add((i + 1) + "");
                lvPhieuNhap.Items[i].SubItems.Add(pn.dVT1.vTen);
                lvPhieuNhap.Items[i].SubItems.Add(pn.nctsoluong + "");
                lvPhieuNhap.Items[i].SubItems.Add(pn.pN.nmaso);
                DateTime dtNgayTao = new DateTime();
                dtNgayTao = (DateTime)pn.pN.ndate;
                string thoigiantao = dtNgayTao.ToString("dd/MM/yyyy hh:mm");
                lvPhieuNhap.Items[i].SubItems.Add(thoigiantao);
                i++;
            }

        }

        private void lvPhieuNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem listviewItem in lvPhieuNhap.SelectedItems)
            {
                objPhieuNhap = new pNCT();
                objPhieuNhap = lpn[listviewItem.Index];
                tbVatTu.Text = objPhieuNhap.dVT1.vTen;
                tbSoLuong.Text = objPhieuNhap.nctsoluong+"";
            }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            lpn = SPhieuNhap.SearchThongKeNhap(textBox2.Text,tbTuNgay.Text,tbDenNgay.Text);
            Load_LvVatTu();
        }

        private void btXemBaoCao_Click(object sender, EventArgs e)
        {
           
        }

        private void tbTuNgay_KeyUp(object sender, KeyEventArgs e)
        {
            lpn = SPhieuNhap.SearchThongKeNhap(textBox2.Text, tbTuNgay.Text, tbDenNgay.Text);
            Load_LvVatTu();
        }

        private void tbDenNgay_KeyUp(object sender, KeyEventArgs e)
        {
            lpn = SPhieuNhap.SearchThongKeNhap(textBox2.Text, tbTuNgay.Text, tbDenNgay.Text);
            Load_LvVatTu();
        }

        private void tbSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            Unit.IsNumberic(sender, e);
        }
    }
}
