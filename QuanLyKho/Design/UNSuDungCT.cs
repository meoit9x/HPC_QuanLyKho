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
        List<dK> lkho;
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
                cbDonVi.Enabled = false;
                tbDienGiai.Enabled = false;
                tbSoLuong.Enabled = false;
            }
            this.lTonKho = Unit.TinhTonKho("");
            Load_LvVatTu();
        }

        private void UNChuyenChiTiet_Load(object sender, EventArgs e)
        {
            SetupComboBox();
            Load_LvPhieuNhap();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UNChuyen dieuchuyen = new UNChuyen();
            Main.pnParent.Controls.Clear();
            Main.pnParent.Controls.Add(dieuchuyen);
        }
        
        private void SetupComboBox()
        {
            lkho = new List<dK>();
            lkho = SKho.SelectKhoByNonUser();
            foreach (dK objKho in lkho)
            {
                cbDonVi.Items.Add(objKho.kten);
            }

            if (objSD.dK == null)
            {
                cbDonVi.SelectedIndex = 0;
            }
            else
            {
                cbDonVi.Text = objSD.dK.kten;
            }
            cbDonVi.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void EditForm(bool isEdit)
        {
            btTao.Text = (isEdit && objSD.dK == null) ? "Sửa" : "Tạo";
            btThoat.Enabled = (isEdit && objSD.dK == null) ? true : false;
            btXoa.Enabled = (isEdit && objSD.dK == null) ? true : false;
            tbVatTu.Text = isEdit ? objSDCT.dVT.vTen : "";
            tbSoLuong.Text = isEdit ? objSDCT.sdctsoluong + "" : "";
            tbDienGiai.Text = isEdit ? objSDCT.diengiai + "" : "";
        }

        private void tbSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            Unit.IsNumberic(sender, e);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            EditForm(false);
        }

        private void Load_LvPhieuNhap()
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
            foreach (pSDCT pcct in lsd)
            {
                lvSuDung.Items.Add((i + 1) + "");
                //lvPhieuNhap.Items[i].SubItems.Add(pcct.dVT.mavt);
                lvSuDung.Items[i].SubItems.Add(pcct.dVT.vTen);
                lvSuDung.Items[i].SubItems.Add(pcct.sdctsoluong + "");
                lvSuDung.Items[i].SubItems.Add(pcct.dVT.dvt1);
                Double giathanh = Math.Round((Convert.ToDouble(pcct.dongia) * Convert.ToDouble(pcct.sdctsoluong)), 2);
                //lvPhieuNhap.Items[i].SubItems.Add(giathanh + "");
                tongtien += Convert.ToDouble(giathanh);
                i++;
            }

            /*if (lsd.Count != 0)
            {
                lvPhieuNhap.Items.Add("");
                lvPhieuNhap.Items[i].SubItems.Add("");
                lvPhieuNhap.Items[i].SubItems.Add("Tổng tiền : ");
                lvPhieuNhap.Items[i].SubItems.Add("");
                lvPhieuNhap.Items[i].SubItems.Add("");
                lvPhieuNhap.Items[i].SubItems.Add(tongtien + "");
            }*/

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
                string tenvt,donvitinh;
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
            Load_LvPhieuNhap();
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
            Load_LvPhieuNhap();
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
                else if(btThoat.Enabled == true)
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
            if(tbSoHoaDon.Text.Equals(""))
            {
                lbLoi.Text = "Số hóa đơn không được để trống.";
                tbSoHoaDon.Focus();
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
                cbDonVi.Enabled = false;
                btTao.Enabled = false;
                tbVatTu.Enabled = false;
                btXoa.Enabled = false;
                btThoat.Enabled = false;
                cbDonVi.Enabled = false;
                tbDienGiai.Enabled = false;
                tbSoLuong.Enabled = false;
                btXuatThang.Enabled = true;
                tbSoHoaDon.Text = objSD.smaso;
            }
        }

        private void btXuatThang_Click(object sender, EventArgs e)
        {
            QuanLyKho.BaoCao.nhapkho.xuatbaocaochuyen(objSD.sdid);
        }

        private void cbDonVi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
