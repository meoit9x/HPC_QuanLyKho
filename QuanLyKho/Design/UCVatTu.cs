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
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrintingLinks;

namespace QuanLyKho.Design
{
    public partial class UCVatTu : UserControl
    {
        private List<dVT> lvt;
        private dVT dvt = new dVT();

        public UCVatTu()
        {
            InitializeComponent();            
        }

        private void UCVatTu_Load(object sender, EventArgs e)
        {
            lvt = new List<dVT>();
            lvt = SVatTu.SearchVatTu("");
            autoCompleteTBVatTu();
            Load_LvVatTu();
        }

        private void Load_LvVatTu()
        {
            lvVatTu.Items.Clear();
            lvVatTu.Columns.Clear();
            lvVatTu.View = View.Details;

            ColumnHeader chSTT;
            chSTT = new ColumnHeader();
            chSTT.Text = "STT";
            chSTT.Width = 40;
            chSTT.TextAlign = HorizontalAlignment.Center;
            lvVatTu.Columns.Add(chSTT);

            ColumnHeader chTenNhom;
            chTenNhom = new ColumnHeader();
            chTenNhom.Text = "Mã vật tư";
            chTenNhom.Width = 100;
            chTenNhom.TextAlign = HorizontalAlignment.Center;
            lvVatTu.Columns.Add(chTenNhom);

            ColumnHeader chGiaThanh;
            chGiaThanh = new ColumnHeader();
            chGiaThanh.Text = "Tên vật tư";
            chGiaThanh.Width = 100;
            chGiaThanh.TextAlign = HorizontalAlignment.Center;
            lvVatTu.Columns.Add(chGiaThanh);

            ColumnHeader chDVT;
            chDVT = new ColumnHeader();
            chDVT.Text = "Đơn vị tính";
            chDVT.Width = 100;
            chDVT.TextAlign = HorizontalAlignment.Center;
            lvVatTu.Columns.Add(chDVT);

            lvVatTu.GridLines = true;
            lvVatTu.FullRowSelect = true;

            int i = 0;
            foreach (dVT vt in lvt)
            {
                lvVatTu.Items.Add((i + 1) + "");
                lvVatTu.Items[i].SubItems.Add(vt.mavt);
                lvVatTu.Items[i].SubItems.Add(vt.vTen);
                lvVatTu.Items[i].SubItems.Add(vt.dvt1);
                i++;
            }

        }

        private void btTao_Click(object sender, EventArgs e)
        {
            tbSearch.Text = "";

            if ("".Equals(tbMaVT.Text))
            {
                lbLoi.Text = "Mã vật tư không được để trống.";
                tbMaVT.Focus();
                return;
            }

            dvt = SVatTu.SelectVTbyMa(tbMaVT.Text);
            if (dvt != null)
            {
                lbLoi.Text = "Mã vật tư " + dvt.mavt + " đã tồn tại.";
                tbMaVT.Focus();
                return;
            }

            if ("".Equals(tbTenVT.Text))
            {
                lbLoi.Text = "Tên vật tư không được để trống.";
                tbTenVT.Focus();
                return;
            }
            if (btThoat.Visible == true)
            {
                dvt.vTen = tbTenVT.Text;
                dvt.mavt = tbMaVT.Text;
                dvt.dvt1 = tbDonViTinh.Text;
                lvt = SVatTu.EditVatTu(dvt);
                lbLoi.Text = "Sửa thành công.";
            }
            else
            {
                dvt = new dVT();
                dvt.vTen = tbTenVT.Text;
                dvt.dvt1 = tbDonViTinh.Text;
                dvt.mavt = tbMaVT.Text;
                dvt.isupdate = 0;
                lvt = SVatTu.AddNewVatTu(dvt);
                lbLoi.Text = "Tạo thành công.";
            }

            Load_LvVatTu();
            
        }

        private void lvVatTu_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem listviewItem in lvVatTu.SelectedItems)
            {
                dvt = lvt[listviewItem.Index];

                tbTenVT.Text = dvt.vTen;
                tbMaVT.Text = dvt.mavt;
                tbDonViTinh.Text = dvt.dvt1;
                
            }
            ShowEidtForm(true);
        }

        private void autoCompleteTBVatTu()
        {
            var dmNVT = SDVT.SearchDVT("");
            AutoCompleteStringCollection combData = new AutoCompleteStringCollection();
            foreach (dDVT vt in dmNVT)
            {
                combData.Add(vt.dvt);
            }
            tbDonViTinh.AutoCompleteMode = AutoCompleteMode.Append;
            tbDonViTinh.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbDonViTinh.AutoCompleteCustomSource = combData;
        }

        private void ShowEidtForm(bool isShow)
        {
            btTao.Text = isShow ? "Sửa" : "Tạo";
            tbMaVT.Text = isShow ? dvt.mavt : "";
            tbTenVT.Text = isShow ? dvt.vTen : "";
            lbLoi.Text = "";
            btThoat.Visible = isShow;
            btXoa.Visible = isShow;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            ShowEidtForm(false);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            int result = SVatTu.CheckXoaVatTu(dvt.vid);
            if (result == 1)
            {
                lbLoi.Text = dvt.vTen + " đã được sử dụng.";
                return;
            }
            List<dVT> lVatTu = new List<dVT>();
            lVatTu = SVatTu.XoaVatTu(dvt);
            if (lVatTu.Count() == lvt.Count())
            {
                lbLoi.Text = "Xóa không thành công.";
                return;
            }
            else
            {
                lvt = lVatTu;
                Load_LvVatTu();
                ShowEidtForm(false);
                lbLoi.Text = "Xóa thành công.";
            }
        }

        private void btCoppy_Click(object sender, EventArgs e)
        {
            lvt = SVatTu.SaoChepVatTu(dvt);
            Load_LvVatTu();
            lbLoi.Text = "Sao chép thành công.";
        }

        private void btThongSo_Click(object sender, EventArgs e)
        {
            Main.AddQuyCachChiTiet(dvt);
        }

        private void cbVatTuSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_LvVatTu();
        }

        private void tbGiaThanh_KeyPress(object sender, KeyPressEventArgs e)
        {
            Unit.IsNumberic(sender, e);
        }

        private void btBaoCao_Click(object sender, EventArgs e)
        {
            
        }

        private void tbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            lvt = SVatTu.SearchVatTu(tbSearch.Text);
            Load_LvVatTu();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        

    }
}
