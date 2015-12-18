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
    public partial class UNNhapCT : UserControl
    {
        private pN objPN = new pN();
        private pNCT objPNCT = new pNCT();
        private List<pNCT> lpnc = new List<pNCT>();
        private List<dKH> lKH;
        private int indexlv;

        public UNNhapCT(pN objPN)
        {
            InitializeComponent();
            if (objPN == null)
            {
                btXuatThang.Enabled = false;
                return;
            }
            else
            {
                btHoanTat.Text = "Sửa";
                this.objPN = objPN;
                lpnc = SPhieuNhapCT.SearchNhapChiTietByIDPN(objPN.nid);
                tbSoHoaDon.Text = objPN.nmaso;
                btTao.Enabled = false;
                tbTongTien.Enabled = false;
                tbVatTu.Enabled = false;
                cbKhachHang.Enabled = false;
                tbSoLuong.Enabled = false;
            }
        }

        private void UNNhapVatTu_Load(object sender, EventArgs e)
        {
            autoCompleteTBVatTu();
            SetupComboBox();
            Load_LvPhieuNhap();
        }

        private void autoCompleteTBVatTu()
        {
            var dmNVT = SVatTu.SearchVatTubyMa("");
            AutoCompleteStringCollection combData = new AutoCompleteStringCollection();
            foreach (dVT vt in dmNVT)
            {
                combData.Add(vt.mavt);
            }
            tbVatTu.AutoCompleteMode = AutoCompleteMode.Append;
            tbVatTu.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbVatTu.AutoCompleteCustomSource = combData;
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

        private void Load_LvPhieuNhap()
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

            ColumnHeader chMaVT;
            chMaVT = new ColumnHeader();
            chMaVT.Text = "Mã vật tư";
            chMaVT.Width = 80;
            chMaVT.TextAlign = HorizontalAlignment.Center;
            lvPhieuNhap.Columns.Add(chMaVT);

            ColumnHeader chTenNhom;
            chTenNhom = new ColumnHeader();
            chTenNhom.Text = "Tên vật tư";
            chTenNhom.Width = 120;
            chTenNhom.TextAlign = HorizontalAlignment.Center;
            lvPhieuNhap.Columns.Add(chTenNhom);

            ColumnHeader chDiaChi;
            chDiaChi = new ColumnHeader();
            chDiaChi.Text = "Số lượng";
            chDiaChi.Width = 60;
            chDiaChi.TextAlign = HorizontalAlignment.Center;
            lvPhieuNhap.Columns.Add(chDiaChi);

            ColumnHeader chSoDienThoai;
            chSoDienThoai = new ColumnHeader();
            chSoDienThoai.Text = "Đơn vị tính";
            chSoDienThoai.Width = 85;
            chSoDienThoai.TextAlign = HorizontalAlignment.Center;
            lvPhieuNhap.Columns.Add(chSoDienThoai);

            ColumnHeader chTongTien;
            chTongTien = new ColumnHeader();
            chTongTien.Text = "Tổng tiền";
            chTongTien.Width = 85;
            chTongTien.TextAlign = HorizontalAlignment.Center;
            lvPhieuNhap.Columns.Add(chTongTien);

            lvPhieuNhap.GridLines = true;
            lvPhieuNhap.FullRowSelect = true;

            int i = 0;
            double tongtien = 0;
            foreach (pNCT pnct in lpnc)
            {
                lvPhieuNhap.Items.Add((i + 1) + "");
                lvPhieuNhap.Items[i].SubItems.Add(pnct.dVT1.mavt);
                lvPhieuNhap.Items[i].SubItems.Add(pnct.dVT1.vTen);
                lvPhieuNhap.Items[i].SubItems.Add(pnct.nctsoluong+"");
                lvPhieuNhap.Items[i].SubItems.Add(pnct.dVT1.dvt1);
                lvPhieuNhap.Items[i].SubItems.Add(pnct.giathanh+"");
                tongtien += Convert.ToDouble(pnct.giathanh);
                i++;
            }

            if (lpnc.Count != 0)
            {
                lvPhieuNhap.Items.Add( "");
                lvPhieuNhap.Items[i].SubItems.Add("");
                lvPhieuNhap.Items[i].SubItems.Add("Tổng tiền : ");
                lvPhieuNhap.Items[i].SubItems.Add("");
                lvPhieuNhap.Items[i].SubItems.Add("");
                lvPhieuNhap.Items[i].SubItems.Add(tongtien+"");
            }

        }

        private void EditForm(bool isEdit)
        {
            btTao.Text = (isEdit && objPN.dK == null) ? "Sửa" : "Tạo";
            btThoat.Enabled = (isEdit && objPN.dK == null)? true : false;
            btXoa.Enabled = (isEdit && objPN.dK == null) ? true : false;
            tbVatTu.Text = isEdit ? objPNCT.dVT1.mavt : "";
            tbSoLuong.Text = isEdit ? objPNCT.nctsoluong + "" : "";
            tbTongTien.Text = isEdit ? objPNCT.giathanh + "" : "";
            if (isEdit)
                cbKhachHang.Text = objPNCT.dDVT.dvt;
            else
                cbKhachHang.SelectedIndex = -1;
        }

        private void btTao_Click(object sender, EventArgs e)
        {
            var vattu = SVatTu.SelectVTbyMa(tbVatTu.Text);
            if (vattu == null)
            {
                lbLoi.Text = "Mã vật tư "+tbVatTu.Text+" không tồn tại.";
                tbVatTu.Focus();
                return;
            }

            if ("".Equals(tbSoLuong.Text))
            {
                lbLoi.Text = "Số lượng không được để trống.";
                tbSoLuong.Focus();
                return;
            }

            if ("".Equals(tbTongTien.Text))
            {
                lbLoi.Text = "Tổng tiền không được để trống.";
                tbTongTien.Focus();
                return;
            }

            if (btThoat.Enabled == true)
            {
                objPNCT.giathanh = Convert.ToDouble(tbTongTien.Text);
                objPNCT.nctsoluong = Convert.ToDouble(tbSoLuong.Text);
                objPNCT.vid = vattu.vid;
                objPNCT.dVT1 = vattu;
                var objKH = SKH.SearchMaKH(cbKhachHang.Text);
                if (objKH != null)
                {
                    objPNCT.idKH = objKH.id;
                    objPNCT.dKH = objKH;
                }
                if (objPN.dK != null)
                {
                    lpnc = SPhieuNhap.EditMotPhieuNhap(objPNCT);
                }
                else
                {
                    lpnc.RemoveAt(indexlv);
                    lpnc.Add(objPNCT);
                }

                lbLoi.Text = "Sửa thành công.";
            }
            else
            {
                pNCT objPNCT = new pNCT();
                objPNCT.giathanh = Convert.ToDouble(tbTongTien.Text);
                objPNCT.nctsoluong = Convert.ToDouble(tbSoLuong.Text);
                objPNCT.vid = vattu.vid;
                objPNCT.dVT1 = vattu;
                var objKH = SKH.SearchMaKH(cbKhachHang.Text);
                if (objKH != null)
                {
                    objPNCT.idKH = objKH.id;
                    objPNCT.dKH = objKH;
                }
                if (objPN.dK != null)
                {
                    objPNCT.nid = objPN.nid;
                    lpnc = SPhieuNhap.AddNewMotPhieuNhap(objPNCT);
                }
                else
                {
                    lpnc.Add(objPNCT);
                    EditForm(false);
                }
                lbLoi.Text = "Tạo thành công.";
            }
            
            Load_LvPhieuNhap();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            EditForm(false);
        }
        
        private void lvPhieuNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem listviewItem in lvPhieuNhap.SelectedItems)
            {
                if (!"".Equals(listviewItem.Text))
                {
                    objPNCT = new pNCT();
                    objPNCT = lpnc[listviewItem.Index];
                    indexlv = listviewItem.Index;
                    EditForm(true);
                    return;
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (objPN.dK != null)
            {
                lpnc =  SPhieuNhapCT.XoaPhieuNhapChiTiet(objPNCT);
            }
            else
            {
                lpnc.RemoveAt(indexlv);
            }
            Load_LvPhieuNhap();
            EditForm(false);

        }

        private void btHoanTat_Click(object sender, EventArgs e)
        {
            if ("".Equals(tbSoHoaDon.Text))
            {
                lbLoi.Text = "Số hóa đơn không được để trống.";
                tbSoHoaDon.Focus();
                return;
            }

            if (lpnc.Count == 0 )
            {
                lbLoi.Text = "Nhập chi tiết hóa đơn.";
                tbVatTu.Focus();
                return;
            }
            DateTime ngayhoadon = new DateTime();
            try
            {
                ngayhoadon = Convert.ToDateTime(tbNHD.Text);
            }
            catch (Exception ex)
            {
                lbLoi.Text = "Sai định dạng ngày tháng.";
                tbNgayHoaDon.Focus();
                return;
            }

            if (objPN.dK == null)
            {
                objPN.kid = Main.OBJ_KHO.kid;
                objPN.ndate = Main.getDateServer();
                objPN.nmaso = tbSoHoaDon.Text;
                objPN.ngayhd = ngayhoadon;
                Main.db.pN.Add(objPN);
                Main.db.SaveChanges();
                foreach (pNCT objPNCT in lpnc)
                {
                    objPNCT.nid = objPN.nid;
                    Main.db.pNCT.Add(objPNCT);
                    Main.db.SaveChanges();
                }
                lbLoi.Text = "Dữ liệu đã được lưu.";
                btXuatThang.Enabled = true;
                btXuatThang.Text = "Báo cáo";
            }
            else
            {
                objPN.nmaso = tbSoHoaDon.Text;
                objPN.ngayhd = ngayhoadon;
                Main.db.SaveChanges();
                lbLoi.Text = "Dữ liệu đã được sửa.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main.AddPhieuNhap();
        }

        private void btXuatThang_Click(object sender, EventArgs e)
        {
            QuanLyKho.BaoCao.nhapkho.xuatbaocaonhap(objPN.nid);
        }

    }
}
