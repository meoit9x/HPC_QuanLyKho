using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKho.Service;

namespace QuanLyKho.Design
{
    public partial class DialogXuatThang : Form
    {
        List<pNCT> lpnct;
        List<dK> listNhaMay;

        public DialogXuatThang(List<pNCT> lpnct)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            SetupComboBox();
            this.lpnct = lpnct;
        }

        private void SetupComboBox()
        {
            listNhaMay = SKho.SelectKhoByNonUser();
            foreach (dK objKho in listNhaMay)
            {
                cbDonVi.Items.Add(objKho.kten);
            }
            cbDonVi.SelectedIndex = 0;
            cbDonVi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbChucNang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbChucNang.SelectedIndex = 0;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btDongY_Click(object sender, EventArgs e)
        {
            if("".Equals(tbGhiChu.Text))
            {
                lbLoi.Text = "Ghi chú không được để trống";
                return;
            }
            SPhieuNhap.AddNewPhieuNhap(lpnct);
            if (cbChucNang.SelectedIndex == 0)
            {
                if (Unit.NhapMuaXuatThang(lpnct, tbGhiChu.Text, 0))
                    Main.AddPhieuNhap();
                else
                {
                    lbLoi.Text = "Có lỗi khi sử dụng.";
                }
            }
            else
            {
                int idKho = listNhaMay[cbDonVi.SelectedIndex].kid;
                if (Unit.NhapMuaXuatThang(lpnct, tbGhiChu.Text, idKho))
                    Main.AddPhieuNhap();
                else
                {
                    lbLoi.Text = "Có lỗi khi điều chuyển.";
                }
            }
            this.DialogResult = DialogResult.Cancel;
        }

        private void cbChucNang_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDonVi.Enabled = cbChucNang.SelectedIndex == 1;
        }
    }
}
