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
    public partial class UNChuyenCT : UserControl
    {
        pC objPhieuChuyen = new pC();
        pCCT objCCT;
        List<pCCT> lpcct = new List<pCCT>();
        List<dK> lkho;
        private int indexlv = 0;
        List<ItemPhieu> lTonKho;
        private ItemPhieu itemphieu;
        private int indexTon;
        private double soluong;

        public UNChuyenCT(pC objPhieuChuyen)
        {
            InitializeComponent();
            if (objPhieuChuyen == null)
            {
                btXuatThang.Enabled = false;
            }
            else
            {
                btHoanTat.Text = "Sửa";
                this.objPhieuChuyen = objPhieuChuyen;
                lpcct = SPhieuChuyenCT.SearchChuyenChiTietByIDPN(objPhieuChuyen.cid);
                tbSoHoaDon.Text = objPhieuChuyen.cmaso;
                DateTime ngayhoadon = new DateTime();
                ngayhoadon = objPhieuChuyen.pdate;
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

            if (objPhieuChuyen.dK == null)
            {
                cbDonVi.SelectedIndex = 0;
            }
            else
            {
                cbDonVi.Text = objPhieuChuyen.dK1.kten;
            }
            cbDonVi.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void EditForm(bool isEdit)
        {
            btTao.Text = (isEdit && objPhieuChuyen.dK == null) ? "Sửa" : "Tạo";
            btThoat.Enabled = (isEdit && objPhieuChuyen.dK == null) ? true : false;
            btXoa.Enabled = (isEdit && objPhieuChuyen.dK == null) ? true : false;
            tbVatTu.Text = isEdit ? objCCT.dVT.vTen : "";
            tbSoLuong.Text = isEdit ? objCCT.cctsoluong + "" : "";
            tbDienGiai.Text = isEdit ? objCCT.diengiai + "" : "";
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
            lvPhieuNhap.Items.Clear();
            lvPhieuNhap.Columns.Clear();
            lvPhieuNhap.View = View.Details;

            ColumnHeader chSTT;
            chSTT = new ColumnHeader();
            chSTT.Text = "STT";
            chSTT.Width = 35;
            chSTT.TextAlign = HorizontalAlignment.Center;
            lvPhieuNhap.Columns.Add(chSTT);

            ColumnHeader chTenNhom;
            chTenNhom = new ColumnHeader();
            chTenNhom.Text = "Tên vật tư";
            chTenNhom.Width = 120;
            chTenNhom.TextAlign = HorizontalAlignment.Center;
            lvPhieuNhap.Columns.Add(chTenNhom);

            ColumnHeader chDiaChi;
            chDiaChi = new ColumnHeader();
            chDiaChi.Text = "Số lượng";
            chDiaChi.Width = 55;
            chDiaChi.TextAlign = HorizontalAlignment.Center;
            lvPhieuNhap.Columns.Add(chDiaChi);

            ColumnHeader chSoDienThoai;
            chSoDienThoai = new ColumnHeader();
            chSoDienThoai.Text = "DVT";
            chSoDienThoai.Width = 35;
            chSoDienThoai.TextAlign = HorizontalAlignment.Center;
            lvPhieuNhap.Columns.Add(chSoDienThoai);

            lvPhieuNhap.GridLines = true;
            lvPhieuNhap.FullRowSelect = true;

            int i = 0;
            double tongtien = 0;
            foreach (pCCT pcct in lpcct)
            {
                lvPhieuNhap.Items.Add((i + 1) + "");
                //lvPhieuNhap.Items[i].SubItems.Add(pcct.dVT.mavt);
                lvPhieuNhap.Items[i].SubItems.Add(pcct.dVT.vTen);
                lvPhieuNhap.Items[i].SubItems.Add(pcct.cctsoluong + "");
                lvPhieuNhap.Items[i].SubItems.Add(pcct.dVT.dvt1);
                Double giathanh = Math.Round((Convert.ToDouble(pcct.dongia) * Convert.ToDouble(pcct.cctsoluong)), 2);
                //lvPhieuNhap.Items[i].SubItems.Add(giathanh + "");
                tongtien += Convert.ToDouble(giathanh);
                i++;
            }

            /*if (lpcct.Count != 0)
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
            pCCT objPCCT = new pCCT();
            objPCCT = lpcct[indexlv];
            lpcct.RemoveAt(indexlv);
            ItemPhieu itemphieu = new ItemPhieu();
            itemphieu.DonGia = Convert.ToDouble(objPCCT.dongia);
            itemphieu.IdVatTu = Convert.ToInt32(objPCCT.vid);
            itemphieu.SoLuong = Convert.ToDouble(objPCCT.cctsoluong);

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

        private void lvPhieuNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem listviewItem in lvPhieuNhap.SelectedItems)
            {
                if (!"".Equals(listviewItem.Text))
                {
                    btTao.Text = "Sửa";
                    btThoat.Enabled = true;
                    btXoa.Enabled = true;
                    objCCT = new pCCT();
                    objCCT = lpcct[listviewItem.Index];
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
                objCCT.cctsoluong = Convert.ToDouble(tbSoLuong.Text);
                objCCT.vid = vattu.vid;
                objCCT.dongia = Unit.GetGiaVTTB(vattu.vid);
                objCCT.diengiai = tbDienGiai.Text;
                /*if (objPhieuChuyen.dK != null)
                {
                    lpcct = SPhieuChuyen.EditMotPhieuChuyen(objCCT);
                }
                else
                {*/
                lpcct.RemoveAt(indexlv);
                lpcct.Add(objCCT);
                //}
                int indexfind = lTonKho.FindIndex(x => x.IdVatTu == objCCT.vid);
                ItemPhieu objItem = new ItemPhieu();
                if (indexfind >= 0)
                {
                    objItem = lTonKho[indexfind];
                    double soluongthuc = soluong - Convert.ToDouble(objCCT.cctsoluong);
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
                objCCT = new pCCT();
                objCCT.cctsoluong = Convert.ToDouble(tbSoLuong.Text);
                objCCT.vid = vattu.vid;
                objCCT.dVT = vattu;
                objCCT.dongia = Unit.GetGiaVTTB(vattu.vid);
                objCCT.diengiai = tbDienGiai.Text;
                if (objPhieuChuyen.dK != null)
                {
                    lpcct = SPhieuChuyen.EditMotPhieuChuyen(objCCT);
                }
                else
                {
                    lpcct.Add(objCCT);
                }

                lbLoi.Text = "Tạo thành công.";

                double soluong = itemphieu.SoLuong - Convert.ToDouble(objCCT.cctsoluong);
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
                if (lpcct.Count == 0)
                {
                    soluong = itemphieu.SoLuong;
                }
                else if(btThoat.Enabled == true)
                {
                    foreach (pCCT objItem in lpcct)
                    {
                        if (objItem.vid == vattu.vid)
                            soluong += Convert.ToDouble(objItem.cctsoluong);
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
                objPhieuChuyen.cmaso = tbSoHoaDon.Text;
                Main.db.SaveChanges();
            }
            else
            {
                objPhieuChuyen = new pC();
                objPhieuChuyen.cmaso = tbSoHoaDon.Text;
                objPhieuChuyen.pdate = Main.getDateServer();
                objPhieuChuyen.pfrom = Convert.ToInt32(Main.OBJ_KHO.kid);
                objPhieuChuyen.pto = lkho[cbDonVi.SelectedIndex].kid;
                Main.db.pC.Add(objPhieuChuyen);
                Main.db.SaveChanges();
                foreach (pCCT objPCCT in lpcct)
                {
                    objPCCT.cid = objPhieuChuyen.cid;
                    Main.db.pCCT.Add(objPCCT);
                    Main.db.SaveChanges();
                }
                lbLoi.Text = "Dữ liệu đã được lưu";
                btHoanTat.Text = "Sửa";
                tbSoHoaDon.Text = objPhieuChuyen.cmaso;
                cbDonVi.Enabled = false;
                btTao.Enabled = false;
                tbVatTu.Enabled = false;
                btXoa.Enabled = false;
                btThoat.Enabled = false;
                cbDonVi.Enabled = false;
                tbDienGiai.Enabled = false;
                tbSoLuong.Enabled = false;
                btXuatThang.Enabled = true;
                tbSoHoaDon.Text = objPhieuChuyen.cmaso;
            }
        }

        private void btXuatThang_Click(object sender, EventArgs e)
        {
            QuanLyKho.BaoCao.nhapkho.xuatbaocaochuyen(objPhieuChuyen.cid);
        }

    }
}
