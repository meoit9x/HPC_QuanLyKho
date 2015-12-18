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

namespace QuanLyKho.Design
{
    public partial class UNNhuCau : UserControl
    {
        private List<pNC> lNC = new List<pNC>();

        public UNNhuCau()
        {
            InitializeComponent();
        }

        private void UNNhuCau_Load(object sender, EventArgs e)
        {
            lNC = SNhuCau.GetAll();
            Load_LvHoaDon();
        }

        private void Load_LvHoaDon()
        {
            lvPhieuNhap.Items.Clear();
            lvPhieuNhap.Columns.Clear();
            lvPhieuNhap.View = View.Details;

            ColumnHeader chSTT;
            chSTT = new ColumnHeader();
            chSTT.Text = "STT";
            chSTT.Width = 40;
            chSTT.TextAlign = HorizontalAlignment.Center;
            lvPhieuNhap.Columns.Add(chSTT);

            ColumnHeader chMaVT;
            chMaVT = new ColumnHeader();
            chMaVT.Text = "Mã số";
            chMaVT.Width = 80;
            chMaVT.TextAlign = HorizontalAlignment.Center;
            lvPhieuNhap.Columns.Add(chMaVT);

            ColumnHeader chTenNhom;
            chTenNhom = new ColumnHeader();
            chTenNhom.Text = "Ngày tạo";
            chTenNhom.Width = 120;
            chTenNhom.TextAlign = HorizontalAlignment.Center;
            lvPhieuNhap.Columns.Add(chTenNhom);

            ColumnHeader chDiaChi;
            chDiaChi = new ColumnHeader();
            chDiaChi.Text = "Ngày cần vật tư";
            chDiaChi.Width = 120;
            chDiaChi.TextAlign = HorizontalAlignment.Center;
            lvPhieuNhap.Columns.Add(chDiaChi);

            ColumnHeader chTrangThai;
            chTrangThai = new ColumnHeader();
            chTrangThai.Text = "Trạng thái";
            chTrangThai.Width = 120;
            chTrangThai.TextAlign = HorizontalAlignment.Center;
            lvPhieuNhap.Columns.Add(chTrangThai);

            ColumnHeader chMucDichSD;
            chMucDichSD = new ColumnHeader();
            chMucDichSD.Text = "Mục đích sử dụng";
            chMucDichSD.Width = 200;
            chMucDichSD.TextAlign = HorizontalAlignment.Center;
            lvPhieuNhap.Columns.Add(chMucDichSD);


            lvPhieuNhap.GridLines = true;
            lvPhieuNhap.FullRowSelect = true;

            int i = 0;
            foreach (pNC pn in lNC)
            {
                lvPhieuNhap.Items.Add((i + 1) + "");
                lvPhieuNhap.Items[i].SubItems.Add(pn.maso);
                lvPhieuNhap.Items[i].SubItems.Add(Convert.ToString(pn.ncdate));
                lvPhieuNhap.Items[i].SubItems.Add(pn.isgui == 1 ?"Đã gửi chờ duyệt":"Chưa gửi");
                lvPhieuNhap.Items[i].SubItems.Add(Convert.ToString(pn.tgcan));
                lvPhieuNhap.Items[i].SubItems.Add(pn.mucdich);
                i++;
            }
        }

        private void lvPhieuNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem listviewItem in lvPhieuNhap.SelectedItems)
            {
                pNC objPNC = new pNC();
                objPNC = lNC[listviewItem.Index];
                Main.AddNhuCauCT(objPNC);
            }
        }

        private void btHoanTat_Click(object sender, EventArgs e)
        {
            Main.AddNhuCauCT(null);
        }

        private void Search()
        {
            try
            {
                DateTime tungay = new DateTime();
                DateTime denngay = new DateTime();
                tungay = Convert.ToDateTime(tbTuNgay.Text);
                denngay = Convert.ToDateTime(tbDenNgay.Text);
                lNC = SNhuCau.GetNCByDate(tungay, denngay);
                Load_LvHoaDon();
            }
            catch
            {
                lNC = SNhuCau.GetAll();
                Load_LvHoaDon();
                return;
            }
        }

        private void tbTuNgay_KeyUp(object sender, KeyEventArgs e)
        {
            Search();
        }

        private void tbDenNgay_KeyUp(object sender, KeyEventArgs e)
        {
            Search();
        }

    }
}
