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
using QuanLyKho.Service;

namespace QuanLyKho.Design
{
    public partial class UNXetDuyetNhuCauCT : UserControl
    {


        public UNXetDuyetNhuCauCT()
        {
            InitializeComponent();
        }

        private void UNNhapNhuCau_Load(object sender, EventArgs e)
        {
            LoadDataForm();
            autoCompleteTBVatTu();
        }

        private void LoadDataForm()
        {
            
        }

        private void autoCompleteTBVatTu()
        {
            var dmNVT = SVatTu.SearchVatTu("");
            AutoCompleteStringCollection combData = new AutoCompleteStringCollection();
            foreach (dVT vt in dmNVT)
            {
                combData.Add(vt.vTen);
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
            
        }

        private void btTao_Click(object sender, EventArgs e)
        {
            AddAndEdit(false);
        }

        private void cbDateTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            LoadDataForm();
            ViewEdit(false);
        }

        private void tbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            
            Load_LvVatTu();
            ViewEdit(false);
        }

        private void lvNhuCau_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem listviewItem in lvNhuCau.SelectedItems)
            {
               
                ViewEdit(true);
            }
        }

        private void ViewEdit(bool isEdit)
        {
            
            btHuy.Enabled = isEdit;
            btXacNhan.Enabled = !isEdit;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            ViewEdit(false);
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            AddAndEdit(true);
        }

        private void AddAndEdit(bool isEdit)
        {
            if ("".Equals(tbVatTu.Text))
            {
                lbLoi.Text = "Tên vật tư không được để trống.";
                return;
            }

            if ("".Equals(tbSoLuong.Text))
            {
                lbLoi.Text = "Số lượng không được để trống.";
                return;
            }

            var objVatTu = SVatTu.SelectVTbyTen(tbVatTu.Text);
            if (objVatTu == null)
            {
                lbLoi.Text = "Vật tư này không tồn tại.";
                return;
            }

            if (isEdit)
            {
               
                Main.db.SaveChanges();
                lbLoi.Text = "Sửa thành công!";
            }
            else
            {
               
                lbLoi.Text = "Tạo thành công!";
            }
            Load_LvVatTu();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            
            Main.db.SaveChanges();
            ViewEdit(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

    }
}
