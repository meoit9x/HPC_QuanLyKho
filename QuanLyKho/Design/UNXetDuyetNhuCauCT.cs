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
using System.IO;
using QuanLyKho.Service;

namespace QuanLyKho.Design
{
    public partial class UNXetDuyetNhuCauCT : UserControl
    {
        pNC objNC = new pNC();
        List<pNCCT> lpncct = new List<pNCCT>();
        pNCCT objPNCCT = new pNCCT();
        List<dKH> lKH;
        private string inphieu = "In phiếu";
        pN phieunhap = new pN();

        public UNXetDuyetNhuCauCT(pNC objNC)
        {
            InitializeComponent();
            this.objNC = objNC;
            if (objNC.idpn != 0)
            {
                phieunhap = SPhieuNhap.SearchPhieuNhapByID(Convert.ToInt32(objNC.idpn));
                if(phieunhap != null)
                {
                    tbSoHoaDon.Text = phieunhap.nmaso;
                    tbNHD.Text = phieunhap.ngayhd.ToString();
                }
                if (objNC.xetduyet == 2)
                {
                    tbNHD.Enabled = false;
                    tbSoHoaDon.Enabled = false;
                    gbContent.Enabled = false;
                    btHoanTat.Text = inphieu;
                }
             }
        }

        private void UNNhapNhuCau_Load(object sender, EventArgs e)
        {
            Load_LvVatTu();
            SetupComboBox();
        }

        private void SetupComboBox()
        {
            lKH = new List<dKH>();
            lKH = SKH.GetAll();
            foreach (dKH objKH in lKH)
            {
                cbKhachHang.Items.Add(objKH.ten);
            }

            cbKhachHang.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void Load_LvVatTu()
        {
            if (objNC == null)
                return;
            lpncct = SNhuCau.GetNCCTByIDNC(objNC.ncid);
            if (lpncct.Count != 0)
                btHoanTat.Enabled = true;
            else
                btHoanTat.Enabled = false;
            lvNhuCau.Items.Clear();
            lvNhuCau.Columns.Clear();
            lvNhuCau.View = View.Details;

            ColumnHeader chSTT;
            chSTT = new ColumnHeader();
            chSTT.Text = "STT";
            chSTT.Width = 40;
            chSTT.TextAlign = HorizontalAlignment.Center;
            lvNhuCau.Columns.Add(chSTT);

            ColumnHeader chTenVatTu;
            chTenVatTu = new ColumnHeader();
            chTenVatTu.Text = "Tên vật tư";
            chTenVatTu.Width = 125;
            chTenVatTu.TextAlign = HorizontalAlignment.Center;
            lvNhuCau.Columns.Add(chTenVatTu);

            ColumnHeader chSoLuong;
            chSoLuong = new ColumnHeader();
            chSoLuong.Text = "Số lượng";
            chSoLuong.Width = 55;
            chSoLuong.TextAlign = HorizontalAlignment.Center;
            lvNhuCau.Columns.Add(chSoLuong);

            ColumnHeader chTon;
            chTon = new ColumnHeader();
            chTon.Text = "Tồn kho";
            chTon.Width = 55;
            chTon.TextAlign = HorizontalAlignment.Center;
            lvNhuCau.Columns.Add(chTon);

            ColumnHeader chTongTien;
            chTongTien = new ColumnHeader();
            chTongTien.Text = "Tổng tiền";
            chTongTien.Width = 100;
            chTongTien.TextAlign = HorizontalAlignment.Center;
            lvNhuCau.Columns.Add(chTongTien);

            ColumnHeader chDuyet;
            chDuyet = new ColumnHeader();
            chDuyet.Text = "Trạng thái";
            chDuyet.Width = 70;
            chTon.TextAlign = HorizontalAlignment.Center;
            lvNhuCau.Columns.Add(chDuyet);

            lvNhuCau.GridLines = true;
            lvNhuCau.FullRowSelect = true;

            int i = 0;
            foreach (pNCCT dutruct in lpncct)
            {
                lvNhuCau.Items.Add((i + 1) + "");
                lvNhuCau.Items[i].SubItems.Add(dutruct.dVT.vTen);
                lvNhuCau.Items[i].SubItems.Add(dutruct.ncsoluong + "");
                lvNhuCau.Items[i].SubItems.Add(dutruct.tonsoluong + "");
                lvNhuCau.Items[i].SubItems.Add(dutruct.tongtien + "");
                lvNhuCau.Items[i].SubItems.Add(dutruct.accept == 1 ? "Đã duyệt" : "");
                i++;
            }
        }

        private void cbDateTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewEdit(false);
        }

        private void lvNhuCau_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem listviewItem in lvNhuCau.SelectedItems)
            {
                objPNCCT = lpncct[listviewItem.Index];
                ViewEdit(true);
            }
        }

        private void ViewEdit(bool isEdit)
        {
            tbVatTu.Text = isEdit ? objPNCCT.dVT.vTen : "";
            tbDienGiai.Text = isEdit ? objPNCCT.diengiai : "";
            tbSoLuong.Text = isEdit ? objPNCCT.ncsoluong + "" : "";
            tbTongTien.Text = isEdit ? objPNCCT.tongtien + "" : "";
            btThoat.Enabled = isEdit;
            btTao.Enabled = isEdit;
        }

        private void btQuayLai_Click(object sender, EventArgs e)
        {
            Main.AddNhuCau();
        }

        private void tbTongTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            Unit.IsNumberic(sender, e);
        }

        private void tbSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            Unit.IsNumberic(sender, e);
        }

        private void btTao_Click(object sender, EventArgs e)
        {
            if (tbSoLuong.Text.Equals(""))
            {
                lbLoi.Text = "Số lượng không được để trống.";
                tbSoLuong.Focus();
                return;
            }
            if (tbTongTien.Text.Equals(""))
            {
                lbLoi.Text = "Tổng tiền không được để trống.";
                tbTongTien.Focus();
                return;
            }
            objPNCCT.tongtien = Convert.ToDouble(tbTongTien.Text);
            objPNCCT.accept = 1;
            objPNCCT.ncsoluong = Convert.ToDouble(tbSoLuong.Text);
            var objKH = SKH.SearchMaKH(cbKhachHang.Text);
            if (objKH != null)
            {
                objPNCCT.idkh = objKH.id;
            }
            Main.db.SaveChanges();
            Load_LvVatTu();
            ViewEdit(false);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            ViewEdit(false);
        }

        private void btHoanTat_Click(object sender, EventArgs e)
        {
            if (btHoanTat.Text.Equals(inphieu))
            {
                BaoCao.nhapkho.xuatbaocaonhap(phieunhap.nid);
            }
            else
            {
                int index = lpncct.FindIndex(x => x.tongtien != null);
                if (index == -1)
                {
                    lbLoi.Text = "Chi tiết nhu cầu chưa được xác nhận.";
                    return;
                }
                if (tbSoHoaDon.Text.Equals(""))
                {
                    lbLoi.Text = "Số hóa đơn không được để trống.";
                    tbSoHoaDon.Focus();
                    return;
                }

                DateTime ngayhoadon = new DateTime();
                try
                {
                    ngayhoadon = Convert.ToDateTime(tbNHD.Text);
                }
                catch
                {
                    lbLoi.Text = "Sai định dạng ngày tháng.";
                    tbNgayHoaDon.Focus();
                    return;
                }
                // show dialog
                DialogLoading loading = new DialogLoading();
                loading.Show();

                if (phieunhap == null)
                {
                    phieunhap = new pN();
                    phieunhap.kid = objNC.dK.kid;
                    phieunhap.ngayhd = ngayhoadon;
                    phieunhap.nmaso = tbSoHoaDon.Text;
                    phieunhap.ndate = Main.getDateServer();
                    Main.db.pN.Add(phieunhap);
                    Main.db.SaveChanges();
                }
                
                foreach (pNCCT objPNCCT in lpncct)
                {
                    if (objPNCCT.tongtien != null)
                    {
                        pNCT objPNCT = new pNCT();
                        objPNCT.nctsoluong = objPNCCT.ncsoluong;
                        objPNCT.giathanh = objPNCCT.tongtien;
                        objPNCT.idKH = objPNCCT.idkh;
                        objPNCT.nid = phieunhap.nid;
                        objPNCT.vid = objPNCCT.vid;
                        Main.db.pNCT.Add(objPNCT);
                        Main.db.SaveChanges();
                        STon.AddTon(Convert.ToDouble(objPNCT.nctsoluong), Convert.ToInt32(objPNCT.vid), 
                            Convert.ToDouble(objPNCT.giathanh / objPNCT.nctsoluong), true, Convert.ToInt32(Main.OBJ_KHO.kid));
                    }
                    
                }
                objNC.xetduyet = 2;
                objNC.idpn = phieunhap.nid;
                Main.db.SaveChanges();
                btHoanTat.Text = inphieu;
                gbContent.Enabled = false;
                tbNHD.Enabled = false;
                tbSoHoaDon.Enabled = false;

                String subject = "Xác nhận nhu cầu vật tư " + Main.OBJ_KHO.dK.kten;
                String body = "Kính gửi TGĐ, PTGĐ, KTCĐ,"
                    + "\n\nTổ trưởng tổ sửa chữa đơn vị " + Main.OBJ_KHO.dK.kten + "."
                    + "\nXin phép được gửi nhu cầu vật tư, chi tiết trong file đính kèm."
                    + "\n\nKính thư!"
                    + "\nNhân viên : " + Main.OBJ_KHO.uname;

                var lEmail = (from objEmail in Main.db.dEmail select objEmail).ToList();
                List<string> touser = lEmail.Select(x => x.addEmail).ToList();
                // lấy báo cáo
                MemoryStream ms = null;
                ms = QuanLyKho.BaoCao.nhapkho.xuatbaocaonhap(phieunhap.nid);

                // gửi mail và báo cáo
                QuanLyKho.Util.Utils.SendMail(subject, body, touser, "ktcd.hpc@gmail.com", "1AnhTuan1*", "NhuCau_" + Main.OBJ_KHO.dK.kten + ".xlsx", ms);
                loading.Dispose();
                lbLoi.Text = "Hoàn tất nhu cầu.";
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            // show dialog
            DialogLoading loading = new DialogLoading();
            loading.Show();
            String subject = "Hủy nhu cầu vật tư " + Main.OBJ_KHO.dK.kten;
            String body = "Kính gửi TGĐ, PTGĐ, KTCĐ,"
                + "\n\nTổ trưởng tổ sửa chữa đơn vị " + Main.OBJ_KHO.dK.kten + "."
                + "\nXin phép được gửi nhu cầu vật tư, chi tiết trong file đính kèm."
                + "\n\nKính thư!"
                + "\nNhân viên : " + Main.OBJ_KHO.uname;

            var lEmail = (from objEmail in Main.db.dEmail select objEmail).ToList();
            List<string> touser = lEmail.Select(x => x.addEmail).ToList();
            // lấy báo cáo

            // gửi mail và báo cáo
            QuanLyKho.Util.Utils.SendMail(subject, body, touser, "ktcd.hpc@gmail.com",
                "1AnhTuan1*", "NhuCau_" + Main.OBJ_KHO.dK.kten + ".xlsx", null);
            loading.Dispose();
            lbLoi.Text = "Hoàn tất nhu cầu.";
        }

    }
}
