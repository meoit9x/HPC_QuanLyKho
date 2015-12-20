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
using System.Net.Mail;
using System.Net;
using QuanLyKho.Service;
using QuanLyKho.ObjectRefrence;

namespace QuanLyKho.Design
{
    public partial class UNNhuCauCT : UserControl
    {
        private pNC objNC;
        private pNCCT objNCCT;
        private List<pNCCT> lpncct = new List<pNCCT>();
        private string xoaphieu = "Xóa phiếu";
        private string inphieu = "In phiếu";

        public UNNhuCauCT(pNC objNC)
        {
            InitializeComponent();
            if (objNC == null)
            {
                btInPhieu.Enabled = false;
                btHoanTat.Enabled = false;
                btInPhieu.Text = xoaphieu;
            }
            else
            {
                tbMucDich.Text = objNC.mucdich;
                if (objNC.tgcan == null)
                    objNC.tgcan = Main.getDateServer();
                tbTgCan.Text = Convert.ToDateTime(objNC.tgcan).ToString("dd/MM/yyyy");
                if (objNC.isgui == 0)
                {
                    btInPhieu.Text = xoaphieu;
                }
                else
                {
                    gbContent.Enabled = false;
                    btHoanTat.Enabled = false;
                    btInPhieu.Text = inphieu;
                }
            }
            this.objNC = objNC;
        }

        private void UNNhapNhuCau_Load(object sender, EventArgs e)
        {

            Load_LvVatTu();
            autoCompleteTBVatTu();
        }

        private void autoCompleteTBVatTu()
        {
            var dmNVT = SVatTu.SearchVatTu("");
            AutoCompleteStringCollection combData = new AutoCompleteStringCollection();
            foreach (dVT vt in dmNVT)
            {
                combData.Add(vt.mavt);
            }
            tbVatTu.AutoCompleteMode = AutoCompleteMode.Append;
            tbVatTu.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbVatTu.AutoCompleteCustomSource = combData;

            tbVatTu.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbVatTu.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbVatTu.AutoCompleteCustomSource = combData;
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

            lvNhuCau.GridLines = true;
            lvNhuCau.FullRowSelect = true;

            int i = 0;
            foreach (pNCCT dutruct in lpncct)
            {
                lvNhuCau.Items.Add((i + 1) + "");
                lvNhuCau.Items[i].SubItems.Add(dutruct.dVT.vTen);
                lvNhuCau.Items[i].SubItems.Add(dutruct.ncsoluong + "");
                lvNhuCau.Items[i].SubItems.Add(dutruct.tonsoluong + "");
                i++;
            }
        }

        private void lvNhuCau_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem listviewItem in lvNhuCau.SelectedItems)
            {
                objNCCT = new pNCCT();
                objNCCT = lpncct[listviewItem.Index];
                ViewEdit(true);
            }
        }

        private void ViewEdit(bool isEdit)
        {
            tbVatTu.Text = (isEdit && objNCCT.dVT != null) ? objNCCT.dVT.mavt : "";
            tbSoLuong.Text = isEdit ? objNCCT.ncsoluong + "" : "";
            tbDienGiai.Text = isEdit ? objNCCT.diengiai : "";
            btXoa.Enabled = isEdit;
            btThoat.Enabled = isEdit;
            btTao.Text = !isEdit ? "Tạo" : "Sửa";
            lbLoi.Text = "";
        }

        private void AddAndEdit(bool isEdit)
        {
            if ("".Equals(tbVatTu.Text))
            {
                lbLoi.Text = "Mã vật tư không được để trống.";
                return;
            }

            if ("".Equals(tbSoLuong.Text))
            {
                lbLoi.Text = "Số lượng không được để trống.";
                return;
            }

            var objVatTu = SVatTu.SelectVTbyMa(tbVatTu.Text);
            if (objVatTu == null)
            {
                lbLoi.Text = "Vật tư này không tồn tại.";
                return;
            }

            if (isEdit)
            {
                objNCCT.ncsoluong = Convert.ToDouble(tbSoLuong.Text);
                objNCCT.diengiai = tbDienGiai.Text;
                objNCCT.vid = objVatTu.vid;
                Main.db.SaveChanges();
                lbLoi.Text = "Sửa thành công!";
            }
            else
            {
                objNCCT = new pNCCT();
                objNCCT.ncsoluong = Convert.ToDouble(tbSoLuong.Text);
                objNCCT.diengiai = tbDienGiai.Text;
                objNCCT.ncid = objNC.ncid;
                objNCCT.vid = objVatTu.vid;
                List<ItemPhieu> litem = new List<ItemPhieu>();
                litem = Unit.TinhTonKhoThongKe(objVatTu.vTen, "", "");
                if (litem.Count > 0)
                {
                    objNCCT.tonsoluong = litem[0].SoLuong;
                }
                else
                    objNCCT.tonsoluong = 0;
                Main.db.pNCCT.Add(objNCCT);
                Main.db.SaveChanges();
                lbLoi.Text = "Tạo thành công!";
            }
            Load_LvVatTu();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            Main.db.pNCCT.Remove(objNCCT);
            Main.db.SaveChanges();
            Load_LvVatTu();
            ViewEdit(false);
        }

        private void tbSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            Unit.IsNumberic(sender, e);
        }

        private void btQuayLai_Click(object sender, EventArgs e)
        {
            Main.AddNhapNhuCau();
        }

        private void btThoat_Click_1(object sender, EventArgs e)
        {
            ViewEdit(false);
        }

        private void btTao_Click_1(object sender, EventArgs e)
        {
            if (objNC == null)
            {
                objNC = new pNC();
                objNC.kid = Main.OBJ_KHO.kid;
                objNC.isgui = 0;
                objNC.ncdate = Main.getDateServer();
                Main.db.pNC.Add(objNC);
                Main.db.SaveChanges();
                btInPhieu.Enabled = true;
                btHoanTat.Enabled = true;
            }
            AddAndEdit(btThoat.Enabled == false ? false : true);
        }

        private void btInPhieu_Click(object sender, EventArgs e)
        {
            if (objNC == null)
                return;
            if (btInPhieu.Text.Equals(xoaphieu))
            {
                foreach (pNCCT objItem in lpncct)
                {
                    Main.db.pNCCT.Remove(objItem);
                    Main.db.SaveChanges();
                }
                Main.db.pNC.Remove(objNC);
                Main.db.SaveChanges();
                Main.AddNhapNhuCau();

            }
            else
            {
                QuanLyKho.BaoCao.nhapkho.xuatbaocaonhucau(objNC, lpncct);
            }
            ViewEdit(false);
        }

        private void btHoanTat_Click(object sender, EventArgs e)
        {
            DialogLoading loading = new DialogLoading();
            loading.Show();
            //string reportPath = "D:\\PhanMemKCS\\BaoCao\\BaoCaoKCS_" + dateBaoCao.Date.ToString("dd_MM_yyy") + ".jpg";
            DateTime tgCan = new DateTime();
            try
            {
                tgCan = Convert.ToDateTime(tbTgCan.Text);
            }
            catch (Exception ex)
            {
                lbLoi.Text = "Định dạng ngày tháng không đúng.";
                tbTgCan.Focus();
                return;
            }

            if (tbMucDich.Text.Equals(""))
            {
                lbLoi.Text = "Mục đích không được để trống.";
                tbMucDich.Focus();
                return;
            }

            objNC.isgui = 1;
            objNC.mucdich = tbMucDich.Text;
            objNC.tgcan = tgCan;
            Main.db.SaveChanges();

            String subject = "Nhu cầu vật tư ";
            String body = "Kính gửi TGĐ, PTGĐ, KTCĐ,"
                + "\n\nTổ trưởng tổ sửa chữa đơn vị " + Main.OBJ_KHO.dK.kten + "."
                + "\nXin phép được gửi nhu cầu vật tư, chi tiết trong file đính kèm."
                + "\n\nKính thư!"
                + "\nNhân viên : " + Main.OBJ_KHO.uname;
            Unit.sendMail(subject, body);

            lbLoi.Text = "Gửi mail thành công.";
            btInPhieu.Text = inphieu;
            gbContent.Enabled = false;
            loading.Dispose();
        }

    }
}
