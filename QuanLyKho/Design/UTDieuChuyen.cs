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
using QuanLyKho.Service;

namespace QuanLyKho.Design
{
    public partial class UTDieuChuyen : UserControl
    {

        List<pCCT> lpcct;
        pCCT objCCT = new pCCT();


        public UTDieuChuyen(List<pCCT> lpcct)
        {
            InitializeComponent();
            this.lpcct = lpcct;
            Load_LvVatTu();
        }


        private void Load_LvVatTu()
        {
            lvTKSD.Items.Clear();
            lvTKSD.Columns.Clear();
            lvTKSD.View = View.Details;

            ColumnHeader chSTT;
            chSTT = new ColumnHeader();
            chSTT.Text = "STT";
            chSTT.Width = 40;
            chSTT.TextAlign = HorizontalAlignment.Center;
            lvTKSD.Columns.Add(chSTT);

            ColumnHeader chTenVatTu;
            chTenVatTu = new ColumnHeader();
            chTenVatTu.Text = "Tên vật tư";
            chTenVatTu.Width = 125;
            chTenVatTu.TextAlign = HorizontalAlignment.Center;
            lvTKSD.Columns.Add(chTenVatTu);

            ColumnHeader chSoLuong;
            chSoLuong = new ColumnHeader();
            chSoLuong.Text = "Số lượng";
            chSoLuong.Width = 75;
            chSoLuong.TextAlign = HorizontalAlignment.Center;
            lvTKSD.Columns.Add(chSoLuong);

            ColumnHeader chTime;
            chTime = new ColumnHeader();
            chTime.Text = "Thời gian tạo";
            chTime.Width = 120;
            chTime.TextAlign = HorizontalAlignment.Center;
            lvTKSD.Columns.Add(chTime);

            ColumnHeader chTo;
            chTo = new ColumnHeader();
            chTo.Text = "Chuyển tới";
            chTo.Width = 80;
            chTo.TextAlign = HorizontalAlignment.Center;
            lvTKSD.Columns.Add(chTo);

            lvTKSD.GridLines = true;
            lvTKSD.FullRowSelect = true;

            int i = 0;
            foreach (pCCT cct in lpcct)
            {
                lvTKSD.Items.Add((i + 1) + "");
                lvTKSD.Items[i].SubItems.Add(cct.dVT.vTen);
                lvTKSD.Items[i].SubItems.Add(cct.cctsoluong + "");
                DateTime dtNgayTao = new DateTime();
                dtNgayTao = (DateTime)cct.pC.pdate;
                string thoigiantao = dtNgayTao.ToString("dd/MM/yyyy hh:mm");
                lvTKSD.Items[i].SubItems.Add(thoigiantao);
                lvTKSD.Items[i].SubItems.Add(SKho.SelectKhoID(Convert.ToInt32(cct.pC.pto)).kten);
                i++;
            }

        }

        private void btXemBaoCao_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            lpcct =  SPhieuChuyen.SearchThongDieuChuyen(textBox2.Text, tbTuNgay.Text, tbDenNgay.Text);
            Load_LvVatTu();
        }

        private void tbTuNgay_KeyUp(object sender, KeyEventArgs e)
        {
            lpcct = SPhieuChuyen.SearchThongDieuChuyen(textBox2.Text, tbTuNgay.Text, tbDenNgay.Text);
            Load_LvVatTu();
        }

        private void tbDenNgay_KeyUp(object sender, KeyEventArgs e)
        {
            lpcct = SPhieuChuyen.SearchThongDieuChuyen(textBox2.Text, tbTuNgay.Text, tbDenNgay.Text);
            Load_LvVatTu();
        }

        private void lvTKSD_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem listviewItem in lvTKSD.SelectedItems)
            {
                objCCT = new pCCT();
                tbVatTu.Text = objCCT.dVT.vTen;
                tbSoLuong.Text = objCCT.cctsoluong+"";
                tbDienGiai.Text = objCCT.diengiai;

            }
        }

    }

}
