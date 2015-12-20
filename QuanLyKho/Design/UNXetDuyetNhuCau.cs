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
    public partial class UNXetDuyetNhuCau : UserControl
    {
        public UNXetDuyetNhuCau()
        {
            InitializeComponent();
        }

        List<pNC> lNC = new List<pNC>();
        List<dK> lkho = new List<dK>();
        pNC objNC = new pNC();

        private void UNXetDuyet_Load(object sender, EventArgs e)
        {
            lNC = SNhuCau.GetXetDuyet();
            Load_LvHoaDon();
            SetupComboBox();
        }

        private void SetupComboBox()
        {
            lkho = new List<dK>();
            lkho = SKho.SelectKhoByNonUser();
            cbDonVi.Items.Add("Tất cả");
            foreach (dK objKho in lkho)
            {
                cbDonVi.Items.Add(objKho.kten);
            }
            cbDonVi.SelectedIndex = 0;
            cbDonVi.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void Search()
        {
            int idKho = 0;
            if(cbDonVi.SelectedIndex != 0)
            {
                idKho = lkho[cbDonVi.SelectedIndex-1].kid;
            }
            lNC = SNhuCau.Search(idKho, tbTuNgay.Text, tbDenNgay.Text);
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
            chMaVT.Width = 40;
            chMaVT.TextAlign = HorizontalAlignment.Center;
            lvPhieuNhap.Columns.Add(chMaVT);

            ColumnHeader chTenNhom;
            chTenNhom = new ColumnHeader();
            chTenNhom.Text = "Ngày tạo";
            chTenNhom.Width = 120;
            chTenNhom.TextAlign = HorizontalAlignment.Center;
            lvPhieuNhap.Columns.Add(chTenNhom);

            ColumnHeader chMucDichSD;
            chMucDichSD = new ColumnHeader();
            chMucDichSD.Text = "Đơn vị";
            chMucDichSD.Width = 80;
            chMucDichSD.TextAlign = HorizontalAlignment.Center;
            lvPhieuNhap.Columns.Add(chMucDichSD);

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

            ColumnHeader chMucDich;
            chMucDich = new ColumnHeader();
            chMucDich.Text = "Mục đích";
            chMucDich.Width = 120;
            chMucDich.TextAlign = HorizontalAlignment.Center;
            lvPhieuNhap.Columns.Add(chMucDich);

            lvPhieuNhap.GridLines = true;
            lvPhieuNhap.FullRowSelect = true;

            int i = 0;
            foreach (pNC pn in lNC)
            {
                lvPhieuNhap.Items.Add((i + 1) + "");
                lvPhieuNhap.Items[i].SubItems.Add(pn.maso);
                lvPhieuNhap.Items[i].SubItems.Add(Convert.ToString(pn.ncdate));
                lvPhieuNhap.Items[i].SubItems.Add(pn.dK.kten);
                lvPhieuNhap.Items[i].SubItems.Add(Convert.ToString(pn.tgcan));
                lvPhieuNhap.Items[i].SubItems.Add(pn.xetduyet == 2 ? "Đã duyệt" : "Đang chờ");
                lvPhieuNhap.Items[i].SubItems.Add(pn.mucdich);
                i++;
            }
        }

        private void cbDonVi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void tbDenNgay_KeyUp(object sender, KeyEventArgs e)
        {
            Search();
        }

        private void tbTuNgay_KeyUp(object sender, KeyEventArgs e)
        {
            Search();
        }

        private void btHoanTat_Click(object sender, EventArgs e)
        {
            if (objNC.dK != null)
            {
                UNXetDuyetNhuCauCT unxetduyet = new UNXetDuyetNhuCauCT(objNC);
                Main.pnParent.Controls.Clear();
                Main.pnParent.Controls.Add(unxetduyet);
            }
        }
        
        private void lvPhieuNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem listviewItem in lvPhieuNhap.SelectedItems)
            {
                objNC = lNC[listviewItem.Index];
            }
        }
    }
}
