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
using QuanLyKho.ObjectRefrence;

namespace QuanLyKho.Design
{
    public partial class UNSuDungCT : UserControl
    {
        pSD objSD = new pSD();
        pSDCT objSDCT;
        List<pSDCT> lsd = new List<pSDCT>();
        List<dMay> lMSD;
        private int indexlv = 0;
        List<ItemPhieu> lTonKho;
        private ItemPhieu itemphieu;
        private int indexTon;
        private double soluong;

        public UNSuDungCT(pSD objSD)
        {
            InitializeComponent();
            if (objSD == null)
            {
                btXuatThang.Enabled = false;
            }
            else
            {
                btHoanTat.Text = "Sửa";
                this.objSD = objSD;
                lsd = SPhieuSuDung.SearchSDChiTietByID(objSD.sdid);
                tbSoHoaDon.Text = objSD.smaso;
                var ngayhoadon = objSD.sdate;
                btTao.Enabled = false;
                tbVatTu.Enabled = false;
                tbDienGiai.Enabled = false;
                tbSoLuong.Enabled = false;
                cbMaySuDung.Enabled = false;
            }
            this.lTonKho = Unit.TinhTonKho("");
            Load_LvVatTu();
        }

        private void UNSDChiTiet_Load(object sender, EventArgs e)
        {
            SetupComboBoxMay();
            Load_LvSuDung();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UNSuDung sudung = new UNSuDung();
            Main.pnParent.Controls.Clear();
            Main.pnParent.Controls.Add(sudung);
        }

        private void SetupComboBoxMay()
        {
            lMSD = SMay.GetAll();
            foreach (dMay objMSD in lMSD)
            {
                cbMaySuDung.Items.Add(objMSD.maso);
            }

            if (cbMaySuDung.Items.Count > 0)
                cbMaySuDung.SelectedIndex = 0;

            if (objSDCT == null)
                return;
            else
                cbMaySuDung.SelectedValue = objSDCT.dMay.id;

            cbMaySuDung.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void EditForm(bool isEdit)
        {
            btTao.Text = (isEdit && objSD.dK == null) ? "Sửa" : "Tạo";
            btThoat.Enabled = (isEdit && objSD.dK == null) ? true : false;
            btXoa.Enabled = (isEdit && objSD.dK == null) ? true : false;
            tbVatTu.Text = isEdit ? objSDCT.dVT.vTen : "";
            tbSoLuong.Text = isEdit ? objSDCT.sdctsoluong + "" : "";
            tbDienGiai.Text = isEdit ? objSDCT.diengiai + "" : "";
            cbMaySuDung.SelectedIndex = isEdit ? cbMaySuDung.FindStringExact(objSDCT.dMay.maso) : 0;
        }

        private void tbSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            Unit.IsNumberic(sender, e);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            EditForm(false);
        }

        private void Load_LvSuDung()
        {
            lvSuDung.Items.Clear();
            lvSuDung.Columns.Clear();
            lvSuDung.View = View.Details;

            ColumnHeader chSTT;
            chSTT = new ColumnHeader();
            chSTT.Text = "STT";
            chSTT.Width = 35;
            chSTT.TextAlign = HorizontalAlignment.Center;
            lvSuDung.Columns.Add(chSTT);

            ColumnHeader chTenNhom;
            chTenNhom = new ColumnHeader();
            chTenNhom.Text = "Tên vật tư";
            chTenNhom.Width = 120;
            chTenNhom.TextAlign = HorizontalAlignment.Center;
            lvSuDung.Columns.Add(chTenNhom);

            ColumnHeader chMaySuDung;
            chMaySuDung = new ColumnHeader();
            chMaySuDung.Text = "Máy sử dụng";
            chMaySuDung.Width = 35;
            chMaySuDung.TextAlign = HorizontalAlignment.Center;
            lvSuDung.Columns.Add(chMaySuDung);

            ColumnHeader chDiaChi;
            chDiaChi = new ColumnHeader();
            chDiaChi.Text = "Số lượng";
            chDiaChi.Width = 55;
            chDiaChi.TextAlign = HorizontalAlignment.Center;
            lvSuDung.Columns.Add(chDiaChi);

            ColumnHeader chSoDienThoai;
            chSoDienThoai = new ColumnHeader();
            chSoDienThoai.Text = "DVT";
            chSoDienThoai.Width = 35;
            chSoDienThoai.TextAlign = HorizontalAlignment.Center;
            lvSuDung.Columns.Add(chSoDienThoai);

            lvSuDung.GridLines = true;
            lvSuDung.FullRowSelect = true;

            int i = 0;
            double tongtien = 0;
            foreach (pSDCT pSDCT in lsd)
            {
                lvSuDung.Items.Add((i + 1) + "");
                lvSuDung.Items[i].SubItems.Add(pSDCT.dVT.vTen);
                if (pSDCT.dMay == null)
                {
                    pSDCT.dMay = SMay.SearchMay(Convert.ToInt32(pSDCT.mid));
                }
                string tenmay;
                if (pSDCT.dMay != null)
                    tenmay = pSDCT.dMay.tenmay;
                else
                    tenmay = "";
                lvSuDung.Items[i].SubItems.Add(tenmay);
                lvSuDung.Items[i].SubItems.Add(pSDCT.sdctsoluong + "");
                lvSuDung.Items[i].SubItems.Add(pSDCT.dVT.dvt1);
                Double giathanh = Math.Round((Convert.ToDouble(pSDCT.dongia) * Convert.ToDouble(pSDCT.sdctsoluong)), 2);
                //lvPhieuNhap.Items[i].SubItems.Add(giathanh + "");
                tongtien += Convert.ToDouble(giathanh);
                i++;
            }
        }

        private void Load_LvVatTu()
        {
            lvTonKho.Items.Clear();
            lvTonKho.Columns.Clear();
            lvTonKho.View = View.Details;

            ColumnHeader chSTT;
            chSTT = new ColumnHeader();
            chSTT.Text = "STT";
            chSTT.Width = 35;
            chSTT.TextAlign = HorizontalAlignment.Center;
            lvTonKho.Columns.Add(chSTT);

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
            chDVT.Text = "DVT";
            chDVT.Width = 35;
            chDVT.TextAlign = HorizontalAlignment.Center;
            lvTonKho.Columns.Add(chDVT);

            lvTonKho.GridLines = true;
            lvTonKho.FullRowSelect = true;

            int i = 0;
            foreach (ItemPhieu item in lTonKho)
            {
                lvTonKho.Items.Add((i + 1) + "");
                var vattu = SVatTu.SelectVTbyID(item.IdVatTu);
                string tenvt, donvitinh;
                if (vattu != null)
                {
                    tenvt = vattu.vTen;
                    donvitinh = vattu.dvt1;
                }
                else
                {
                    tenvt = "";
                    donvitinh = "";
                }
                lvTonKho.Items[i].SubItems.Add(tenvt);
                lvTonKho.Items[i].SubItems.Add(item.SoLuong + "");
                lvTonKho.Items[i].SubItems.Add(donvitinh);
                i++;
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            pSDCT objSDCT = new pSDCT();
            objSDCT = lsd[indexlv];
            lsd.RemoveAt(indexlv);
            ItemPhieu itemphieu = new ItemPhieu();
            itemphieu.DonGia = Convert.ToDouble(objSDCT.dongia);
            itemphieu.IdVatTu = Convert.ToInt32(objSDCT.vid);
            itemphieu.SoLuong = Convert.ToDouble(objSDCT.sdctsoluong);

            ItemPhieu objItem = new ItemPhieu();
            objItem = lTonKho.Find(x => x.IdVatTu == itemphieu.IdVatTu);
            if (objItem == null)
            {
                lTonKho.Add(itemphieu);
            }
            else
            {
                for (int i = 0; i < lTonKho.Count; i++)
                {
                    objItem = lTonKho[i];
                    if (itemphieu.IdVatTu == objItem.IdVatTu)
                    {
                        itemphieu.SoLuong += objItem.SoLuong;
                        lTonKho.RemoveAt(i);
                        lTonKho.Add(itemphieu);
                        break;
                    }
                }
            }
            Load_LvVatTu();
            Load_LvSuDung();
            EditForm(false);
        }

        private void lvSuDung_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem listviewItem in lvSuDung.SelectedItems)
            {
                if (!"".Equals(listviewItem.Text))
                {
                    btTao.Text = "Sửa";
                    btThoat.Enabled = true;
                    btXoa.Enabled = true;
                    objSDCT = new pSDCT();
                    objSDCT = lsd[listviewItem.Index];
                    indexlv = listviewItem.Index;
                    EditForm(true);
                    lbLoi.Text = "";
                    return;
                }
            }
        }

        private void btTao_Click(object sender, EventArgs e)
        {
            var vattu = SVatTu.SelectVTbyTen(tbVatTu.Text);
            if (vattu == null)
            {
                lbLoi.Text = "Tên vật tư " + tbVatTu.Text + " không tồn tại.";
                tbVatTu.Focus();
                return;
            }

            if ("".Equals(tbSoLuong.Text))
            {
                lbLoi.Text = "Số lượng không được để trống.";
                tbSoLuong.Focus();
                return;
            }

            if ("".Equals(tbDienGiai.Text))
            {
                lbLoi.Text = "Diễn giải không được để trống.";
                tbDienGiai.Focus();
                return;
            }

            if (btThoat.Enabled == true)
            {
                objSDCT.sdctsoluong = long.Parse(tbSoLuong.Text);
                objSDCT.vid = vattu.vid;
                objSDCT.dongia = Unit.GetGiaVTTB(vattu.vid);
                objSDCT.diengiai = tbDienGiai.Text;
                objSDCT.mid = lMSD[cbMaySuDung.SelectedIndex].id;
                /*if (objSD.dK != null)
                {
                    lsd = SPhieuChuyen.EditMotPhieuChuyen(objSDCT);
                }
                else
                {*/
                lsd.RemoveAt(indexlv);
                lsd.Add(objSDCT);
                //}
                int indexfind = lTonKho.FindIndex(x => x.IdVatTu == objSDCT.vid);
                ItemPhieu objItem = new ItemPhieu();
                if (indexfind >= 0)
                {
                    objItem = lTonKho[indexfind];
                    double soluongthuc = soluong - Convert.ToDouble(objSDCT.sdctsoluong);
                    objItem.SoLuong = soluongthuc;
                    lTonKho.RemoveAt(indexfind);
                    if (soluongthuc != 0)
                        lTonKho.Add(objItem);
                }
                else
                {
                    objItem.IdVatTu = vattu.vid;
                    objItem.SoLuong = soluong - Convert.ToDouble(tbSoLuong.Text);
                    lTonKho.Add(objItem);
                }
                lbLoi.Text = "Sửa thành công.";
            }
            else
            {
                objSDCT = new pSDCT();
                objSDCT.sdctsoluong = long.Parse(tbSoLuong.Text);
                objSDCT.vid = vattu.vid;
                objSDCT.dVT = vattu;
                objSDCT.dongia = Unit.GetGiaVTTB(vattu.vid);
                objSDCT.diengiai = tbDienGiai.Text;
                if (lMSD.Count != 0)
                    objSDCT.mid = lMSD[cbMaySuDung.SelectedIndex].id;
                else
                {
                    lbLoi.Text = "Máy sử dụng không được để trống.";
                    return;
                }
                if (objSD.dK != null)
                {
                    lsd = SPhieuSuDung.EditMotPhieuSD(objSDCT);
                }
                else
                {
                    lsd.Add(objSDCT);
                }

                lbLoi.Text = "Tạo thành công.";

                double soluong = itemphieu.SoLuong - Convert.ToDouble(objSDCT.sdctsoluong);
                lTonKho.RemoveAt(indexTon);
                itemphieu.SoLuong = soluong;
                if (soluong != 0)
                    lTonKho.Add(itemphieu);
                EditForm(false);
            }
            Load_LvVatTu();
            Load_LvSuDung();
        }

        private void lvTonKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem listviewItem in lvTonKho.SelectedItems)
            {
                btTao.Text = "Tạo";
                btXoa.Enabled = false;
                btThoat.Enabled = false;
                itemphieu = new ItemPhieu();
                indexTon = listviewItem.Index;
                itemphieu = lTonKho[indexTon];
                tbSoLuong.Text = itemphieu.SoLuong + "";
                //cbMaySuDung.Text = itemphieu.
                var vattu = SVatTu.SelectVTbyID(itemphieu.IdVatTu);
                tbVatTu.Text = vattu.vTen;
                lbLoi.Text = "";
            }
        }

        private void tbSoLuong_KeyUp(object sender, KeyEventArgs e)
        {
            var vattu = SVatTu.SelectVTbyTen(tbVatTu.Text);
            string soLuong = tbSoLuong.Text;
            if (soLuong.IndexOf("-") != -1)
            {
                tbSoLuong.Text = soLuong.Replace("-", "");
                lbLoi.Text = "Số lượng không được chứa giá trị âm.";
            }
            try
            {
                soluong = itemphieu.SoLuong;
                if (lsd.Count == 0)
                {
                    soluong = itemphieu.SoLuong;
                }
                else if (btThoat.Enabled == true)
                {
                    foreach (pSDCT objItem in lsd)
                    {
                        if (objItem.vid == vattu.vid)
                            soluong += Convert.ToDouble(objItem.sdctsoluong);
                    }
                }
                if (Convert.ToInt32(tbSoLuong.Text) > soluong)
                {
                    lbLoi.Text = "Số lượng không được vượt quá số tồn.";
                    tbSoLuong.Text = soluong + "";
                }
            }
            catch
            {
            }
        }

        private void btHoanTat_Click(object sender, EventArgs e)
        {
            if (tbSoHoaDon.Text.Equals(""))
            {
                lbLoi.Text = "Số hóa đơn không được để trống.";
                tbSoHoaDon.Focus();
                return;
            }

            if (lsd.Count == 0)
            {
                lbLoi.Text = "Nhập chi tiết sử dụng.";
                tbSoLuong.Focus();
                return;
            }
            if (btHoanTat.Text.Equals("Sửa"))
            {
                objSD.smaso = tbSoHoaDon.Text;
                Main.db.SaveChanges();
            }
            else
            {
                objSD = new pSD();
                objSD.smaso = tbSoHoaDon.Text;
                objSD.sdate = Main.getDateServer();
                objSD.kid = Convert.ToInt32(Main.OBJ_KHO.kid);

                Main.db.pSD.Add(objSD);
                Main.db.SaveChanges();
                foreach (pSDCT objSDCT in lsd)
                {
                    objSDCT.sdid = objSD.sdid;
                    Main.db.pSDCT.Add(objSDCT);
                    Main.db.SaveChanges();
                }
                lbLoi.Text = "Dữ liệu đã được lưu";
                btHoanTat.Text = "Sửa";
                tbSoHoaDon.Text = objSD.smaso;
                btTao.Enabled = false;
                tbVatTu.Enabled = false;
                btXoa.Enabled = false;
                btThoat.Enabled = false;
                cbMaySuDung.Enabled = false;
                tbDienGiai.Enabled = false;
                tbSoLuong.Enabled = false;
                btXuatThang.Enabled = true;
                tbSoHoaDon.Text = objSD.smaso;
            }
        }

        private void btXuatThang_Click(object sender, EventArgs e)
        {
            QuanLyKho.BaoCao.nhapkho.xuatbaocaosudung(lsd);
        }

        private void cbDonVi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
