using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKho.ObjectRefrence;
using QuanLyKho.Service;

namespace QuanLyKho.Design
{
    public partial class Main : Form
    {
        public static HPC_DBEntities db;
        public static duser OBJ_KHO = new duser();
        public static Panel pnParent;

        public Main()
        {
            InitializeComponent();
            pnParent = pnContent;
            StartPosition = FormStartPosition.CenterScreen;
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            mncDieuChuyen.ElementClick += mncDieuChuyen_ElementClick;
           
            mncVatTu.ElementClick += mncVatTu_ElementClick;
            mncKho.ElementClick += mncKho_ElementClick;
            mncNhapVatTu.ElementClick += mncNhapVatTu_ElementClick;
            mncSuDung.ElementClick += mncTinhTon_ElementClick;
            mcSLNhap.ElementClick += mncTKNhap_ElementClick;
            mcSLXuat.ElementClick += mncTKXuat_ElementClick;
            mcSLChuyen.ElementClick += mncTKDieuChuyen_ElementClick;
            mcSLTon.ElementClick += mncTon_ElementClick;
            mnThongBao.ElementClick += mnThongBao_ElementClick;
            mncDuTru.ElementClick += mncNhuCau_ElementClick;
            mncKhachHang.ElementClick += mncKhachHang_ElementClick;
            mncMaySuDung.ElementClick += mncTMaySuDung_ElementClick;
            mnTaiKhoan.ElementClick += mnTaiKhoan_ElementClick;
            mncXetDuyet.ElementClick += mncXetNhuCau_ElementClick;
            tbMatKhau.PasswordChar = '*';
        }

        private void Main_Load(object sender, EventArgs e)
        {
            db = new HPC_DBEntities();
        }

        public void AddNhomVat()
        {
            UCNhomVatTu ucNhomHang = new UCNhomVatTu(SNVatTu.GetAll());
            pnContent.Controls.Clear();
            pnContent.Controls.Add(ucNhomHang);
        }

        public void AddPhieuChuyen()
        {
            UNChuyen undieuchuyen = new UNChuyen();
            pnContent.Controls.Clear();
            pnContent.Controls.Add(undieuchuyen);
        }

        public void AddQuyCach()
        {
            var qcs = (from dqc in Main.db.dQC select dqc).ToList();
            UCQuyCach qc = new UCQuyCach(qcs);
            pnContent.Controls.Clear();
            pnContent.Controls.Add(qc);
        }

        public void AddMaySuDung()
        {
            UCMay qc = new UCMay();
            pnContent.Controls.Clear();
            pnContent.Controls.Add(qc);
        }

        public static void AddNhuCau()
        {
            UNXetDuyetNhuCau qc = new UNXetDuyetNhuCau();
            pnParent.Controls.Clear();
            pnParent.Controls.Add(qc);
        }

        public void AddKho()
        {
            var dks = (from dk in Main.db.dK select dk).ToList();
            UCKho uckho = new UCKho(dks);
            pnContent.Controls.Clear();
            pnContent.Controls.Add(uckho);
        }

        public void AddVatTu()
        {
            UCVatTu vt = new UCVatTu();
            pnContent.Controls.Clear();
            pnContent.Controls.Add(vt);
        }

        public static void AddQuyCachChiTiet(dVT objVatTu)
        {
            var qccts = (from dqcct in Main.db.dQCCT where dqcct.vid == objVatTu.vid select dqcct).ToList();
            UCQuyCachChiTiet Ucquycachchitiet = new UCQuyCachChiTiet(qccts, objVatTu.vid);
            pnParent.Controls.Clear();
            pnParent.Controls.Add(Ucquycachchitiet);
        }

        public static void QuayLaiVatTu()
        {
            UCVatTu vt = new UCVatTu();
            pnParent.Controls.Clear();
            pnParent.Controls.Add(vt);
        }

        public static void AddPhieuNhap()
        {
            UNNhap UnNhapVatTu = new UNNhap();
            pnParent.Controls.Clear();
            pnParent.Controls.Add(UnNhapVatTu);
        }

        public static void AddPhieuNhapCT(pN objPN)
        {
            UNNhapCT UnNhapVatTu = new UNNhapCT(objPN);
            pnParent.Controls.Clear();
            pnParent.Controls.Add(UnNhapVatTu);
        }

        public static void AddNhuCauCT(pNC objPNC)
        {
            UNNhuCauCT UnNhapVatTu = new UNNhuCauCT(objPNC);
            pnParent.Controls.Clear();
            pnParent.Controls.Add(UnNhapVatTu);
        }

        public static void AddTongTon()
        {
            UNSuDung thongke = new UNSuDung();
            pnParent.Controls.Clear();
            pnParent.Controls.Add(thongke);
        }

        public static void AddSuDungCT(pSD objSD)
        {
            UNSuDungCT UnSDCT = new UNSuDungCT(objSD);
            pnParent.Controls.Clear();
            pnParent.Controls.Add(UnSDCT);
        }

        public static void AddKhachHang()
        {
            UCKhachHang khachhang = new UCKhachHang();
            pnParent.Controls.Clear();
            pnParent.Controls.Add(khachhang);
        }

        public static void AddTaiKhoan()
        {
            UNTaiKhoan taikhoan = new UNTaiKhoan();
            pnParent.Controls.Clear();
            pnParent.Controls.Add(taikhoan);
        }

        public static void AddNhapNhuCau()
        {
            UNNhuCau ucnhapnhucau = new UNNhuCau();
            pnParent.Controls.Clear();
            pnParent.Controls.Add(ucnhapnhucau);
        }

        public static void AddFormThongBao()
        {
            var objUser = (from user in db.duser where user.kid == OBJ_KHO.kid select user).FirstOrDefault();
            var lTB = (from tb in db.pTB where tb.kid == objUser.kid select tb).ToList();
            UCThongBao ucthongbao = new UCThongBao(lTB);
            pnParent.Controls.Clear();
            pnParent.Controls.Add(ucthongbao);
        }

        public void AddThongKeNhap()
        {
            var pns = (from pn in Main.db.pNCT where pn.pN.kid == OBJ_KHO.kid select pn).ToList();
            UTNhap utnhap = new UTNhap(pns);
            pnContent.Controls.Clear();
            pnContent.Controls.Add(utnhap);
        }

        public void AddThongKeXuat()
        {
            UTXuat utxuat = new UTXuat();
            pnContent.Controls.Clear();
            pnContent.Controls.Add(utxuat);
        }

        public void AddThongKeDieuChuyen()
        {
            var pcct = (from pc in Main.db.pCCT where pc.pC.pfrom == OBJ_KHO.kid select pc).ToList();
            UTDieuChuyen utdieuchuyen = new UTDieuChuyen(pcct);
            pnContent.Controls.Clear();
            pnContent.Controls.Add(utdieuchuyen);
        }

        public void AddThongKeTon()
        {
            var pItemPhieu = Unit.TinhTonKhoThongKe("", "", "");
            UTTon utdieuchuyen = new UTTon(pItemPhieu);
            pnContent.Controls.Clear();
            pnContent.Controls.Add(utdieuchuyen);
        }

        public static DateTime getDateServer()
        {
            var query = db.Database.SqlQuery<DateTime>("SELECT getdate()");
            DateTime dateserver = new DateTime();
            dateserver = query.AsEnumerable().First();
            dateserver = dateserver.Date;
            return dateserver;
        }

        private void LoginForm()
        {
            if ("".Equals(tbTenDangNhap.Text))
            {
                lbLoi.Text = "Tên đăng nhập không được để trống.";
                tbTenDangNhap.Focus();
                return;
            }

            if ("".Equals(tbMatKhau.Text))
            {
                lbLoi.Text = "Mật khẩu không được để trống.";
                tbMatKhau.Focus();
                return;
            }

            OBJ_KHO = (from user in db.duser where user.uuser == tbTenDangNhap.Text where user.upass == tbMatKhau.Text select user).FirstOrDefault();

            if (OBJ_KHO != null)
            {

                HidenLoginForm(Convert.ToInt32(OBJ_KHO.position));

                var lTB = (from tb in db.pTB where tb.kid == OBJ_KHO.kid select tb).ToList();
                UCThongBao ucthongbao = new UCThongBao(lTB);
                pnParent.Controls.Clear();
                pnParent.Controls.Add(ucthongbao);
            }
            else
            {
                lbLoi.Text = "Tài khoản không tồn tại.";
            }
            DateTime sdate = getDateServer();
            Console.Write(sdate.ToString());
        }

        private void HidenLoginForm(int position)
        {
            bool isShow = position != -1 ? true : false;
            mnNghiepVu.Visible = isShow;
            mnThongKe.Visible = isShow;
            mnThongBao.Visible = isShow;
            mnTaiKhoan.Visible = isShow;
            btExit.Visible = isShow;
            pnLogin.Visible = !isShow;
            if (position == 1)
            {
                mnDanhMuc.Visible = false;
                mnNghiepVu.Items.RemoveAt(0);
                mnNghiepVu.Items.RemoveAt(3);
            }
            else if (isShow)
                mnDanhMuc.Visible = true;
            else
                mnDanhMuc.Visible = false;
        }

        private void btExit_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            pnContent.Controls.Clear();
            pnContent.Controls.Add(pnLogin);
            lbLoi.Text = "";
            tbMatKhau.Text = "";
            tbTenDangNhap.Text = "";
            HidenLoginForm(-1);
        }
        
        private void mncTon_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            AddThongKeTon();
            tileNavPane1.HideDropDownWindow();
        }

        private void mncTKDieuChuyen_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            AddThongKeDieuChuyen();
            tileNavPane1.HideDropDownWindow();
        }

        private void mncTKXuat_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            AddThongKeXuat();
            tileNavPane1.HideDropDownWindow();
        }

        private void mncTKNhap_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            AddThongKeNhap();
            tileNavPane1.HideDropDownWindow();
        }

        private void mncTMaySuDung_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            AddMaySuDung();
            tileNavPane1.HideDropDownWindow();
        }

        private void mncXetNhuCau_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            AddNhuCau();
            tileNavPane1.HideDropDownWindow();
        }

        private void mncNhomVatTu_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            AddNhomVat();
            tileNavPane1.HideDropDownWindow();
        }

        private void mncDieuChuyen_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            AddPhieuChuyen();
            tileNavPane1.HideDropDownWindow();
        }

        private void mncQuyCach_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            AddQuyCach();
            tileNavPane1.HideDropDownWindow();
        }


        private void mncNhuCau_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            AddNhapNhuCau();
            tileNavPane1.HideDropDownWindow();
        }

        private void mnThongBao_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            AddFormThongBao();
            tileNavPane1.HideDropDownWindow();
        }

        private void mncVatTu_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            AddVatTu();
            tileNavPane1.HideDropDownWindow();
        }

        private void mncKho_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            AddKho();
            tileNavPane1.HideDropDownWindow();
        }

        private void mncNhapVatTu_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            AddPhieuNhap();
            tileNavPane1.HideDropDownWindow();
        }

        private void mncTinhTon_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            AddTongTon();
            tileNavPane1.HideDropDownWindow();
        }

        private void mncKhachHang_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            AddKhachHang();
            tileNavPane1.HideDropDownWindow();
        }

        private void mnTaiKhoan_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            AddTaiKhoan();
            tileNavPane1.HideDropDownWindow();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            LoginForm();
        }

        private void tbMatKhau_Enter(object sender, EventArgs e)
        {
            LoginForm();
        }

        private void tbMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
                LoginForm();
        }
    }
}
