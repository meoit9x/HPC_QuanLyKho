using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKho.ObjectRefrence;
using QuanLyKho.Service;

namespace QuanLyKho.Design
{
    public partial class UNSuDungCT : UserControl
    {
        List<ItemPhieu> lTonKho;
        List<dMay> lMSD;
        private ItemPhieu objItemPhieu = new ItemPhieu();

        public UNSuDungCT()
        {
            InitializeComponent();
            this.lTonKho = Unit.TinhTonKho("");
            Load_LvVatTu();
            SetupComboBoxMSD();
        }

        private void Load_LvVatTu()
        {
            lvTonKho.Items.Clear();
            lvTonKho.Columns.Clear();
            lvTonKho.View = View.Details;

            ColumnHeader chSTT;
            chSTT = new ColumnHeader();
            chSTT.Text = "STT";
            chSTT.Width = 40;
            chSTT.TextAlign = HorizontalAlignment.Center;
            lvTonKho.Columns.Add(chSTT);

            ColumnHeader chMaVT;
            chMaVT = new ColumnHeader();
            chMaVT.Text = "Mã vật tư";
            chMaVT.Width = 125;
            chMaVT.TextAlign = HorizontalAlignment.Center;
            lvTonKho.Columns.Add(chMaVT);

            ColumnHeader chTenVatTu;
            chTenVatTu = new ColumnHeader();
            chTenVatTu.Text = "Tên vật tư";
            chTenVatTu.Width = 125;
            chTenVatTu.TextAlign = HorizontalAlignment.Center;
            lvTonKho.Columns.Add(chTenVatTu);

            ColumnHeader chSoLuong;
            chSoLuong = new ColumnHeader();
            chSoLuong.Text = "Số lượng";
            chSoLuong.Width = 55;
            chSoLuong.TextAlign = HorizontalAlignment.Center;
            lvTonKho.Columns.Add(chSoLuong);

            ColumnHeader chDVT;
            chDVT = new ColumnHeader();
            chDVT.Text = "Đơn vị tính";
            chDVT.Width = 70;
            chDVT.TextAlign = HorizontalAlignment.Center;
            lvTonKho.Columns.Add(chDVT);

            lvTonKho.GridLines = true;
            lvTonKho.FullRowSelect = true;

            int i = 0;
            foreach (ItemPhieu item in lTonKho)
            {
                lvTonKho.Items.Add((i + 1) + "");
                var vattu = SVatTu.SelectVTbyID(item.IdVatTu);
                lvTonKho.Items[i].SubItems.Add(vattu.mavt);
                lvTonKho.Items[i].SubItems.Add(vattu.vTen);
                lvTonKho.Items[i].SubItems.Add(item.SoLuong + "");
                lvTonKho.Items[i].SubItems.Add(vattu.dvt1);
                i++;
            }

        }

        private void SetupComboBoxMSD()
        {
            lMSD = SMay.GetAll();
            foreach (dMay objMSD in lMSD)
            {
                cbMaySuDung.Items.Add(objMSD.maso);
            }
            if (cbMaySuDung.Items.Count > 0)
                cbMaySuDung.SelectedIndex = 0;
            cbMaySuDung.DropDownStyle = ComboBoxStyle.DropDownList;
            if (cbDVTNgaySD.Items.Count > 0)
                cbDVTNgaySD.SelectedIndex = 0;
            cbDVTNgaySD.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void tbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            this.lTonKho = Unit.TinhTonKho(tbSearch.Text);
            Load_LvVatTu();
        }

        private void lvTonKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem listviewItem in lvTonKho.SelectedItems)
            {
                objItemPhieu = lTonKho[listviewItem.Index];
                tbSoLuong.Text = objItemPhieu.SoLuong + "";
                var vattu = SVatTu.SelectVTbyID(objItemPhieu.IdVatTu);
                tbVatTu.Text = vattu.vTen;
            }
        }
            
        private void ResetFormAction()
        {
            lTonKho = new List<ItemPhieu>();
            tbSoLuong.Text = "";
            tbGhiChu.Text = "";
            tbVatTu.Text = "";
            this.lTonKho = Unit.TinhTonKho("");
            Load_LvVatTu();
        }

        private void btSuDung_Click(object sender, EventArgs e)
        {
            if ("".Equals(tbGhiChu.Text))
            {
                lbLoi.Text = "Diễn giải không được để trống.";
                return;
            }

            if ("".Equals(tbSoLuong.Text))
            {
                lbLoi.Text = "Số lượng không được để trống.";
                return;
            }
            pSDCT objSDCT = new pSDCT();
            objSDCT.vid = objItemPhieu.IdVatTu;
            objSDCT.sdctsoluong = Convert.ToInt32(tbSoLuong.Text);
            objSDCT.diengiai = tbGhiChu.Text;
            objSDCT.mid = lMSD[cbMaySuDung.SelectedIndex].id;
            objSDCT.dongia = Unit.GetGiaVTTB(objItemPhieu.IdVatTu);
            double hansudung = 0;
            switch (cbDVTNgaySD.SelectedIndex)
            {
                case 0:
                    hansudung = Convert.ToDouble(tbHanSuDung.Text);
                    break;
                case 1:
                    hansudung = Convert.ToDouble(tbHanSuDung.Text)*7;
                    break;
                case 2:
                    hansudung = Convert.ToDouble(tbHanSuDung.Text)*30;
                    break;
                case 3:
                    hansudung = Convert.ToDouble(tbHanSuDung.Text)*365;
                    break;
            }
            objSDCT.hansudung = hansudung;
            SPhieuSuDung.AddNewPhieuSuDungChiTiet(new List<pSDCT> { objSDCT });
            lbLoi.Text = "Nhập sử dụng thành công.";
            ResetFormAction();
        }

        private void tbSoLuong_KeyUp(object sender, KeyEventArgs e)
        {
            string soLuong = tbSoLuong.Text;
            if (soLuong.IndexOf("-") != -1)
            {
                tbSoLuong.Text = soLuong.Replace("-", "");
                lbLoi.Text = "Số lượng không được chứa giá trị âm.";
            }
            try
            {
                if (Convert.ToInt32(tbSoLuong.Text) > objItemPhieu.SoLuong)
                {
                    lbLoi.Text = "Số lượng không được vượt quá số tồn.";
                    tbSoLuong.Text = objItemPhieu.SoLuong + "";
                }
            }
            catch
            {
            }

        }

        private void tbSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            Unit.IsNumberic(sender, e);
        }


        private void tbHanSuDung_KeyPress(object sender, KeyPressEventArgs e)
        {
            Unit.IsNumberic(sender, e);
        }
    }
}
