using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho.Design
{
    public partial class DialogHuyNC : Form
    {
        private pNC objNC = new pNC();
        public DialogHuyNC(pNC objNC)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.ControlBox = false;
            this.objNC = objNC;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btXacNhan_Click(object sender, EventArgs e)
        {
            objNC.xetduyet = 3;
            Main.db.SaveChanges();
            String subject = "Hủy nhu cầu vật tư " + Main.OBJ_KHO.dK.kten;
            String body = "Kính gửi TGĐ, PTGĐ, KTCĐ,"
                + "\n\nTổ trưởng tổ sửa chữa đơn vị " + Main.OBJ_KHO.dK.kten + "."
                + "\nXin phép được hủy nhu cầu vật tư của đơn vị " + Main.OBJ_KHO.dK.kten
                + "\n\nKính thư!"
                + "\nNhân viên : " + Main.OBJ_KHO.uname;

            var lEmail = (from objEmail in Main.db.dEmail select objEmail).ToList();
            List<string> touser = lEmail.Select(x => x.addEmail).ToList();
            // lấy báo cáo

            // gửi mail và báo cáo
            QuanLyKho.Util.Utils.SendMail(subject, body, touser, "ktcd.hpc@gmail.com",
                "1AnhTuan1*", "NhuCau_" + Main.OBJ_KHO.dK.kten + ".xlsx", null);
            this.Dispose();
       }
    }
}
