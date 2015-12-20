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
    public partial class UTXuat : UserControl
    {
        List<pSDCT> lpsdct;
        pSDCT objPSD = new pSDCT();
        List<dMay> lMSD;

        public UTXuat()
        {
            InitializeComponent();
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

            ColumnHeader chDVT;
            chDVT = new ColumnHeader();
            chDVT.Text = "Đơn vị tính";
            chDVT.Width = 75;
            chDVT.TextAlign = HorizontalAlignment.Center;
            lvTKSD.Columns.Add(chDVT);

            ColumnHeader chMSD;
            chMSD = new ColumnHeader();
            chMSD.Text = "Máy sử dụng";
            chMSD.Width = 120;
            chMSD.TextAlign = HorizontalAlignment.Center;
            lvTKSD.Columns.Add(chMSD);

            ColumnHeader chNSD;
            chNSD = new ColumnHeader();
            chNSD.Text = "Ngày sử dụng";
            chNSD.Width = 120;
            chNSD.TextAlign = HorizontalAlignment.Center;
            lvTKSD.Columns.Add(chNSD);

            ColumnHeader chTime;
            chTime = new ColumnHeader();
            chTime.Text = "Thời hạn sử dụng";
            chTime.Width = 120;
            chTime.TextAlign = HorizontalAlignment.Center;
            lvTKSD.Columns.Add(chTime);

            lvTKSD.GridLines = true;
            lvTKSD.FullRowSelect = true;

            int i = 0;
            foreach (pSDCT sdct in lpsdct)
            {
                lvTKSD.Items.Add((i + 1) + "");
                lvTKSD.Items[i].SubItems.Add(sdct.dVT.vTen);
                lvTKSD.Items[i].SubItems.Add(sdct.sdctsoluong + "");
                lvTKSD.Items[i].SubItems.Add(sdct.dVT.dvt1 + "");
                lvTKSD.Items[i].SubItems.Add(sdct.dMay.tenmay + "");
                DateTime dtNgayTao = new DateTime();
                dtNgayTao = (DateTime)sdct.pSD.sdate;
                string thoigiantao = dtNgayTao.ToString("dd/MM/yyyy hh:mm");
                lvTKSD.Items[i].SubItems.Add(thoigiantao);
                lvTKSD.Items[i].SubItems.Add(sdct.hansudung + " ngày");
                i++;
            }

        }

        private void lvTKSD_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem listviewItem in lvTKSD.SelectedItems)
            {
                objPSD = new pSDCT();
                objPSD = lpsdct[listviewItem.Index];
                tbVatTu.Text = objPSD.dVT.vTen;
                tbSoLuong.Text = objPSD.sdctsoluong + "";
                tbDVT.Text = objPSD.dVT.dvt1;
                tbHanSuDung.Text = objPSD.hansudung + "";
                tbMaySuDung.Text = objPSD.dMay.tenmay;
                tbDienGiai.Text = objPSD.diengiai;
            }
        }

        private void tbDienGiai_TextChanged(object sender, EventArgs e)
        {
            tbDienGiai.SelectionStart = tbDienGiai.Text.Length;
            tbDienGiai.ScrollToCaret();
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            lpsdct = SPhieuSuDung.SearchThongKeSuDung("", tbTuNgay.Text, tbDenNgay.Text);
            Load_LvVatTu();
        }

        private void tbTuNgay_KeyUp(object sender, KeyEventArgs e)
        {
            SearchPhieu();
            Load_LvVatTu();
        }

        private void tbDenNgay_KeyUp(object sender, KeyEventArgs e)
        {
            SearchPhieu();
            Load_LvVatTu();
        }

        private void SearchPhieu()
        {
            if (cbMaySuDung.SelectedIndex == 0)
            {
                lpsdct = SPhieuSuDung.GetAll();
                Load_LvVatTu();
                lpsdct = SPhieuSuDung.SearchThongKeByMay(0, tbTuNgay.Text, tbDenNgay.Text);
                return;
            }
            else
            {
                dMay objMay = new dMay();
                objMay = lMSD[cbMaySuDung.SelectedIndex - 1];
                lpsdct = SPhieuSuDung.SearchThongKeByMay(objMay.id, tbTuNgay.Text, tbDenNgay.Text);
            }
            Load_LvVatTu();
        }

        private void btXemBaoCao_Click(object sender, EventArgs e)
        {
            QuanLyKho.BaoCao.nhapkho.xuatbaocaosudung(lpsdct);
        }

        private void SetupComboBoxMSD()
        {
            lMSD = SMay.GetAll();
            cbMaySuDung.Items.Add("Tất cả");
            foreach (dMay objMSD in lMSD)
            {
                cbMaySuDung.Items.Add(objMSD.maso);
            }
            if (cbMaySuDung.Items.Count > 0)
                cbMaySuDung.SelectedIndex = 0;
            cbMaySuDung.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void UTXuat_Load(object sender, EventArgs e)
        {
            SetupComboBoxMSD();
            lpsdct = SPhieuSuDung.GetAll();
            Load_LvVatTu();
        }

        private void cbMaySuDung_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchPhieu();
            Load_LvVatTu();
        }


    }
}
