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
    public partial class UCQuyCachChiTiet : UserControl
    {
        List<dQCCT> lqcct;
        dQCCT dqcct = new dQCCT();
        int vid = 0;
        public UCQuyCachChiTiet(List<dQCCT> lqcct,int vid)
        {
            InitializeComponent();
            this.lqcct = lqcct;
            this.vid = vid;
            Load_LvNhomHang();
            autoCompleteTBNVT();
            autoCompleteTBDVT();
        }

        private void Load_LvNhomHang()
        {
            lvNhomHang.Items.Clear();
            lvNhomHang.Columns.Clear();
            lvNhomHang.View = View.Details;

            ColumnHeader chSTT;
            chSTT = new ColumnHeader();
            chSTT.Text = "STT";
            chSTT.Width = 40;
            chSTT.TextAlign = HorizontalAlignment.Center;
            lvNhomHang.Columns.Add(chSTT);

            ColumnHeader chTenNhom;
            chTenNhom = new ColumnHeader();
            chTenNhom.Text = "Tên quy cách";
            chTenNhom.Width = 167;
            chTenNhom.TextAlign = HorizontalAlignment.Center;
            lvNhomHang.Columns.Add(chTenNhom);

            ColumnHeader chThongSo;
            chThongSo = new ColumnHeader();
            chThongSo.Text = "Thông số";
            chThongSo.Width = 75;
            chThongSo.TextAlign = HorizontalAlignment.Center;
            lvNhomHang.Columns.Add(chThongSo);

            ColumnHeader chDVT;
            chDVT = new ColumnHeader();
            chDVT.Text = "Đơn vị tính";
            chDVT.Width = 75;
            chDVT.TextAlign = HorizontalAlignment.Center;
            lvNhomHang.Columns.Add(chDVT);


            lvNhomHang.GridLines = true;
            lvNhomHang.FullRowSelect = true;

            int i = 0;
            foreach (dQCCT qcct in lqcct)
            {
                int qid = (int)qcct.qid;
                int idDVT = (int)qcct.dvtid;
                lvNhomHang.Items.Add((i + 1) + "");
                lvNhomHang.Items[i].SubItems.Add(SQC.SelectQCbyID(qid).qten);
                lvNhomHang.Items[i].SubItems.Add(qcct.qthongso);
                lvNhomHang.Items[i].SubItems.Add(SDVT.SelectDVTbyID(idDVT).dvt);
                i++;
            }

        }

        private void btTao_Click(object sender, EventArgs e)
        {
            if ("".Equals(tbTenQC.Text))
            {
                lbLoi.Text = "Quy cách không được để trống.";
                tbTenQC.Focus();
                return;
            }

            if ("".Equals(tbThongSo.Text))
            {
                lbLoi.Text = "Thông số không được để trống.";
                tbThongSo.Focus();
                return;
            }

            if ("".Equals(tbDVT.Text))
            {
                lbLoi.Text = "Đơn vị tính không được để trống.";
                tbDVT.Focus();
                return;
            }


            dQC objQC = new dQC();
            objQC = SQC.SelectQCbyTen(tbTenQC.Text);
            if (objQC == null)
            {
                lbLoi.Text = "Quy cách này không tồn tại.";
                return;
            }
                        
            var objDVT = SDVT.SelectDVTbyTen(tbDVT.Text);
            if (objDVT == null)
            {
                lbLoi.Text = "Đơn vị tính này không tồn tại.";
                return;
            }
            var ckQC = SQCCT.SelectQCCTbyQidVid(objQC.qid, vid);
            if (ckQC != null)
            {
                ckQC.qid = objQC.qid;
                ckQC.qthongso = tbThongSo.Text;
                ckQC.dvtid = objDVT.dvtid;
                lqcct = SQCCT.EditQCCT(ckQC, vid);
                dqcct = new dQCCT();
                dqcct = ckQC;
                Load_LvNhomHang();
                lbLoi.Text = "Sửa thành công.";
                return;
            }

            if (btThoat.Visible == true)
            {
                dqcct.qid = objQC.qid;
                dqcct.qthongso = tbThongSo.Text;
                dqcct.dvtid = objDVT.dvtid;
                lqcct = SQCCT.EditQCCT(dqcct, vid);
                Load_LvNhomHang();
                lbLoi.Text = "Sửa thành công.";
            }
            else
            {
                dqcct = new dQCCT();
                dqcct.qid = objQC.qid;
                dqcct.vid = vid;
                dqcct.qthongso = tbThongSo.Text;
                dqcct.dvtid = objDVT.dvtid;
                lqcct = SQCCT.AddNewQCCT(dqcct, vid);
                Load_LvNhomHang();
                tbTenQC.Text = "";
                tbDVT.Text = "";
                tbThongSo.Text = "";
                lbLoi.Text = "Tạo thành công.";
            }
        }

        private void lvNhomHang_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            foreach (ListViewItem listviewItem in lvNhomHang.SelectedItems)
            {
                dqcct = lqcct[listviewItem.Index];
                int idQC = (int)dqcct.qid;
                int idDVT = (int)dqcct.dvtid;
                tbTenQC.Text = dqcct.dQC.qten;
                tbDVT.Text = dqcct.dDVT.dvt;
                tbThongSo.Text = dqcct.qthongso;
            }

            DisplayEdit(true);
        }

        private void DisplayEdit(bool isShow)
        {
            btXoa.Visible = isShow;
            btThoat.Visible = isShow;
            if (isShow)
            {
                btTao.Text = "Sửa";
            }
            else
            {
                btTao.Text = "Tạo";
                tbTenQC.Text = "";
                tbThongSo.Text = "";
                tbDVT.Text = "";
                lbLoi.Text = "";
            }
        }

        private void autoCompleteTBNVT()
        {
            var dmNVT = SQC.SearchQuyCach("");
            AutoCompleteStringCollection combData = new AutoCompleteStringCollection();
            foreach (dQC qc in dmNVT)
            {
                combData.Add(qc.qten+"");
            }
            tbTenQC.AutoCompleteMode = AutoCompleteMode.Append;
            tbTenQC.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbTenQC.AutoCompleteCustomSource = combData;

            tbTenQC.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbTenQC.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbTenQC.AutoCompleteCustomSource = combData;
        }

        private void autoCompleteTBDVT()
        {
            var dmDVT = SDVT.SearchDVT("");
            AutoCompleteStringCollection combData = new AutoCompleteStringCollection();
            foreach (dDVT dvt in dmDVT)
            {
                combData.Add(dvt.dvt);
            }
            tbDVT.AutoCompleteMode = AutoCompleteMode.Append;
            tbDVT.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbDVT.AutoCompleteCustomSource = combData;

            tbDVT.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbDVT.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbDVT.AutoCompleteCustomSource = combData;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DisplayEdit(false);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            lqcct =  SQCCT.XoaQCCT(dqcct, vid);
            Load_LvNhomHang();
            DisplayEdit(false);
            lbLoi.Text = "Xóa thành công.";
        }

        private void tbThongSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btQuayLai_Click(object sender, EventArgs e)
        {
            Main.QuayLaiVatTu();
        }

    }
}
