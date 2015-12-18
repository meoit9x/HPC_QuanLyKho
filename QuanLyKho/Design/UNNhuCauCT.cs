﻿using System;
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
                if (objNC.isgui == 0)
                {
                    btInPhieu.Text = xoaphieu;
                }
                else
                {
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

            lvNhuCau.GridLines = true;
            lvNhuCau.FullRowSelect = true;

            int i = 0;
            foreach (pNCCT dutruct in lpncct)
            {
                lvNhuCau.Items.Add((i + 1) + "");
                lvNhuCau.Items[i].SubItems.Add(dutruct.dVT.vTen);
                lvNhuCau.Items[i].SubItems.Add(dutruct.ncsoluong + "");
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
        }

        private void btHoanTat_Click(object sender, EventArgs e)
        {
            //string reportPath = "D:\\PhanMemKCS\\BaoCao\\BaoCaoKCS_" + dateBaoCao.Date.ToString("dd_MM_yyy") + ".jpg";

            objNC.isgui = 1;
            Main.db.SaveChanges();
            String from = "ktcd.hpc@gmail.com";
            
            String subject = "Nhu cầu vật tư ";

            DateTime dateNow = DateTime.Now.Date;
            String body = "";
            var lEmail = (from objEmail in Main.db.dEmail select objEmail).ToList();

            NetworkCredential loginInfo = new NetworkCredential("ktcd.hpc@gmail.com", "1AnhTuan1*");

            MailMessage email = new MailMessage(from, lEmail[0].addEmail, subject, body);
            /*if (error.Length != 0)
            {
                ImageExportOptions image = baocao.ExportOptions.Image;

                baocao.ExportToImage(reportPath, image);
                Attachment data = new Attachment(reportPath);
                email.Attachments.Add(data);
            }*/

            foreach (var objEmail in lEmail)
            {
                email.CC.Add(objEmail.addEmail);
            }

            for (int i = 0; i < lEmail.Count; i++)
            {
                if (i != 0)
                {
                    var objEmail = lEmail[i];
                    email.CC.Add(objEmail.addEmail);
                }
            }

            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.EnableSsl = true;
            client.Port = 25;
            client.UseDefaultCredentials = true;
            client.Credentials = loginInfo;
            client.Send(email);
            lbLoi.Text = "Gửi mail thành công.";
            
            
        }

    }
}
