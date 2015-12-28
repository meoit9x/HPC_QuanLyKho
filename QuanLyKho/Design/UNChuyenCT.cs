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
        private pC objPhieuChuyen = new pC();
        private pCCT objCCT;
        private List<pCCT> lpcct = new List<pCCT>();
        private List<dK> lkho;
        private int indexlv = 0;
        private List<pTon> tonkho = new List<pTon>();
        private pTon objectton;
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
            tonkho = STon.getTon();
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
            foreach (pTon item in tonkho)
            {
                lvTonKho.Items.Add((i + 1) + "");
                lvTonKho.Items[i].SubItems.Add(item.dVT.vTen);
                lvTonKho.Items[i].SubItems.Add(item.soluong + "");
                lvTonKho.Items[i].SubItems.Add(item.dVT.dvt1);
                i++;
            }

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            pCCT objPCCT = new pCCT();
            objPCCT = lpcct[indexlv];
            lpcct.RemoveAt(indexlv);

            pTon objTon = new pTon();
            objTon.dongia = Convert.ToDouble(objPCCT.dongia);
            objTon.vid = Convert.ToInt32(objPCCT.vid);
            objTon.soluong = Convert.ToDouble(objPCCT.cctsoluong);

            pTon objItem = new pTon();
            objItem = tonkho.Find(x => x.vid == objTon.vid);
            if (objItem == null)
            {
                tonkho.Add(objTon);
            }
            else
            {
                for (int i = 0; i < tonkho.Count; i++)
                {
                    objItem = tonkho[i];
                    if (objectton.vid == objItem.vid)
                    {
                        objectton.soluong += Convert.ToDouble(objItem.soluong);
                        tonkho.RemoveAt(i);
                        tonkho.Add(objItem);
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
                int indexfind = tonkho.FindIndex(x => x.vid == objCCT.vid);
                pTon objItem = new pTon();
                if (indexfind >= 0)
                {
                    objItem = tonkho[indexfind];
                    double soluongthuc = soluong - Convert.ToDouble(objCCT.cctsoluong);
                    objItem.soluong = soluongthuc;
                    tonkho.RemoveAt(indexfind);
                    if (soluongthuc != 0)
                        tonkho.Add(objItem);
                }
                else
                {
                    objItem.vid = vattu.vid;
                    objItem.soluong = soluong - Convert.ToDouble(tbSoLuong.Text);
                    tonkho.Add(objItem);
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

                double soluong = Convert.ToDouble(objectton.soluong) - Convert.ToDouble(objCCT.cctsoluong);
                tonkho.RemoveAt(indexTon);
                objectton.soluong = soluong;
                if (soluong != 0)
                    tonkho.Add(objectton);
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
                objectton = new pTon();
                indexTon = listviewItem.Index;
                objectton = tonkho[indexTon];
                tbSoLuong.Text = objectton.soluong + "";
                tbVatTu.Text = objectton.dVT.vTen;
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
                soluong = Convert.ToDouble(objectton.soluong);
                if (lpcct.Count == 0)
                {
                    soluong = Convert.ToDouble(objectton.soluong);
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
                    STon.AddTon(Convert.ToDouble(objPCCT.cctsoluong), Convert.ToInt32(objPCCT.vid), Convert.ToDouble(objPCCT.dongia), false, Convert.ToInt32(Main.OBJ_KHO.kid));
                    STon.AddTon(Convert.ToDouble(objPCCT.cctsoluong), Convert.ToInt32(objPCCT.vid), Convert.ToDouble(objPCCT.dongia), true, Convert.ToInt32(objPhieuChuyen.pto));
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
