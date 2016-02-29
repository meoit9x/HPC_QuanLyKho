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
            
            switch (value)
            {
                case 0:
                    QuanLyKho.BaoCao.nhapkho.baocaoton();
                    break;
                case 1:
                    from = DateTime.Parse(tbTuNgay.Text);
                    to = DateTime.Parse(tbDenNgay.Text);
                    ms = QuanLyKho.BaoCao.nhapkho.baocaonhap(from, to);
                    break;
                case 2:
                    from = DateTime.Parse(tbTuNgay.Text);
                    to = DateTime.Parse(tbDenNgay.Text);
                    ms = QuanLyKho.BaoCao.nhapkho.baocaoxuat(from, to);
                    break;
                case 3:
                    from = DateTime.Parse(tbTuNgay.Text);
                    to = DateTime.Parse(tbDenNgay.Text);
                    ms = QuanLyKho.BaoCao.nhapkho.baocaoxuatnhapton(from, to);
                    break;
                case 4:
                    from = DateTime.Parse(tbTuNgay.Text);
                    to = DateTime.Parse(tbDenNgay.Text);
                    //ms = QuanLyKho.BaoCao.nhapkho.baocaosudung(from, to);
                    break;
                case 5:
                    from = DateTime.Parse(tbTuNgay.Text);
                    to = DateTime.Parse(tbDenNgay.Text);
                    //ms = QuanLyKho.BaoCao.nhapkho.baocaosudungmay(from, to);
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
