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
using System.IO;

namespace QuanLyKho.Design
{
    public partial class TBaoCao : UserControl
    {
        List<dMay> lMSD = new List<dMay>();

        public TBaoCao()
        {
            InitializeComponent();
        }

        private void TBaoCao_Load(object sender, EventArgs e)
        {
            SetupComboBoxMay();
            autoCompleteTBVatTu();
        }

        private void SetupComboBoxMay()
        {
            lMSD = SMay.GetAll();
            foreach (dMay objMSD in lMSD)
            {
                cbMaySuDung.Items.Add(objMSD.maso);
            }

            if (cbMaySuDung.Items.Count > 0)
                cbMaySuDung.SelectedIndex = 0;

            cbMaySuDung.DropDownStyle = ComboBoxStyle.DropDownList;

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

            tbVatTu.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbVatTu.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbVatTu.AutoCompleteCustomSource = combData;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {

        }

        private void btIn_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            var value = cbBaoCao.SelectedIndex;

            var from = new DateTime();
            var to = new DateTime();

            try
            {
                from = DateTime.Parse(tbTuNgay.Text);
            }
            catch
            {
                lbLoi.Text = "Sai định dạng ngày tháng.";
                tbDenNgay.Focus();
                return;
            }

            try
            {
                to = DateTime.Parse(tbDenNgay.Text);
            }
            catch
            {
                lbLoi.Text = "Sai định dạng ngày tháng.";
                tbTuNgay.Focus();
                return;
            }
            
            switch (value)
            {
                case 6:
                    ms = QuanLyKho.BaoCao.nhapkho.baocaonhapdieuchuyen(from, to);
                    break;
                case 7:
                    ms = QuanLyKho.BaoCao.nhapkho.baocaoxuatdieuchuyen(from, to);
                    break;
                case 3:
                    QuanLyKho.BaoCao.nhapkho.baocaoton();
                    break;
                case 4:
                    from = DateTime.Parse(tbTuNgay.Text);
                    to = DateTime.Parse(tbDenNgay.Text);
                    ms = QuanLyKho.BaoCao.nhapkho.baocaonhap(from, to);
                    break;
                case 5:
                    from = DateTime.Parse(tbTuNgay.Text);
                    to = DateTime.Parse(tbDenNgay.Text);
                    ms = QuanLyKho.BaoCao.nhapkho.baocaoxuat(from, to);
                    break;
                case 0:
                    ms = QuanLyKho.BaoCao.nhapkho.baocaoxuatnhapton(from, to);
                    break;
                case 1:
                    var objVatTu = SVatTu.SelectVTbyMa(tbVatTu.Text);
                    if (objVatTu == null)
                    {
                        lbLoi.Text = "Mã vật tư không tồn tại.";
                        tbVatTu.Focus();
                        break;
                    }
                    ms = QuanLyKho.BaoCao.nhapkho.baocaosudung(from, to,objVatTu.vid);
                    break;
                case 2:
                    var objMay = SMay.SearchMayTen(cbMaySuDung.Text);
                    ms = QuanLyKho.BaoCao.nhapkho.baocaosudungmay(from, to,objMay.id);
                    break;
                default:
                    break;
            }
        }

        private void cbBaoCao_SelectedIndexChanged(object sender, EventArgs e)
        {
            var value = cbBaoCao.SelectedIndex;
            if (value == 0)
            {
                
            }
        }
    }
}
