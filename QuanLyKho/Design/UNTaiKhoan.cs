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
    public partial class UNTaiKhoan : UserControl
    {
        public UNTaiKhoan()
        {
            InitializeComponent();
        }

        private void UNTaiKhoan_Load(object sender, EventArgs e)
        {
            tbTDN.Text = Main.OBJ_KHO.uname;
            tbMatKhau.Text = Main.OBJ_KHO.upass;
        }

        private void btTao_Click(object sender, EventArgs e)
        {
            Main.OBJ_KHO.uname = tbTDN.Text;
            Main.OBJ_KHO.upass = tbMatKhau.Text;
            Main.db.SaveChanges();
            lbError.Text = "Thông tin tài khoản đã được lưu.";
        }
    }
}
