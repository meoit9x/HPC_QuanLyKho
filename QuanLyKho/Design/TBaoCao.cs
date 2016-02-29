using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho.Design
{
    public partial class TBaoCao : UserControl
    {
        public TBaoCao()
        {
            InitializeComponent();
        }

        private void TBaoCao_Load(object sender, EventArgs e)
        {

        }

        private void btXoa_Click(object sender, EventArgs e)
        {

        }

        private void btIn_Click(object sender, EventArgs e)
        {
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
                    QuanLyKho.BaoCao.nhapkho.baocaonhap(from, to);
                    break;
                case 2:
                    from = DateTime.Parse(tbTuNgay.Text);
                    to = DateTime.Parse(tbDenNgay.Text);
                    QuanLyKho.BaoCao.nhapkho.baocaoxuat(from, to);
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
