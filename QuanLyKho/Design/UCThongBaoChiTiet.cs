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
    public partial class UCThongBaoChiTiet : UserControl
    {
        private string tacvu;
        private List<pCCT> lpcct = new List<pCCT>();
        private pCCT objpCCT = new pCCT();
        private int pCid = 0;
        private int idtb = 0;

        public UCThongBaoChiTiet(string tacvu,int idTB)
        {
            InitializeComponent();
            this.tacvu = tacvu;
            idtb = idTB;
            LoadFormEdit();
        }

        private void UCThongBaoChiTiet_Load(object sender, EventArgs e)
        {
            if ("C".Equals(tacvu.Substring(0, 1)))
            {
                try
                {
                    string id = tacvu.Substring(1);
                    pCid = Convert.ToInt32(id);
                }
                catch
                {
                    return;
                }

                lpcct = (from pcct in Main.db.pCCT where pcct.cid == pCid select pcct).ToList();
                Load_LvVatTu();
            }
        }

        private void Load_LvVatTu()
        {
            lpcct = (from pcct in Main.db.pCCT where pcct.cid == pCid where pcct.accept == 0 select pcct).ToList();
            if (lpcct.Count == 0)
            {
                var objTB = (from tb in Main.db.pTB where tb.tbid == idtb select tb).FirstOrDefault();
                objTB.tacvu = "";
                Main.db.SaveChanges();
                Main.AddFormThongBao();
            }
            lvTBCT.Items.Clear();
            lvTBCT.Columns.Clear();
            lvTBCT.View = View.Details;

            ColumnHeader chSTT;
            chSTT = new ColumnHeader();
            chSTT.Text = "STT";
            chSTT.Width = 40;
            chSTT.TextAlign = HorizontalAlignment.Center;
            lvTBCT.Columns.Add(chSTT);

            ColumnHeader chMaSo;
            chMaSo = new ColumnHeader();
            chMaSo.Text = "Tên vật tư";
            chMaSo.Width = 150;
            chMaSo.TextAlign = HorizontalAlignment.Center;
            lvTBCT.Columns.Add(chMaSo);

            ColumnHeader chTime;
            chTime = new ColumnHeader();
            chTime.Text = "Số lượng";
            chTime.Width = 55;
            chTime.TextAlign = HorizontalAlignment.Center;
            lvTBCT.Columns.Add(chTime);

            lvTBCT.GridLines = true;
            lvTBCT.FullRowSelect = true;

            int i = 0;
            foreach (pCCT pnct in lpcct)
            {
                lvTBCT.Items.Add((i + 1) + "");
                int vid = (int)pnct.vid;

                lvTBCT.Items[i].SubItems.Add(SVatTu.SelectVTbyID(vid).vTen);
                lvTBCT.Items[i].SubItems.Add(pnct.cctsoluong + "");
                i++;
            }

        }

        private void lvTBCT_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem listviewItem in lvTBCT.SelectedItems)
            {
                objpCCT = lpcct[listviewItem.Index];
                tbVatTu.Text = objpCCT.dVT.vTen;
                tbSoLuong.Text = objpCCT.cctsoluong+"";
                tbDienGiai.Text = objpCCT.diengiai;
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Main.AddFormThongBao();
        }

        private void btHuyBo_Click(object sender, EventArgs e)
        {
            pTB objTB = new pTB();
            objTB.tacvu = "";
            objTB.kid = objpCCT.pC.pfrom;
            objTB.diengiai = "Đơn vị " + objpCCT.pC.dK1.kten + " không đồng ý điều chuyển " + objpCCT.dVT.vTen + " số lượng " + objpCCT.cctsoluong;
            Main.db.pTB.Add(objTB);

            Main.db.pCCT.Remove(objpCCT);
            Main.db.SaveChanges();
            Load_LvVatTu();
            LoadFormEdit();
        }

        private void LoadFormEdit()
        {
            tbDienGiai.Text = "";
            tbDienGiai.Enabled = false;
            tbVatTu.Enabled = false;
            tbSoLuong.Enabled = false;
            tbSoLuong.Text = "";
            tbVatTu.Text = "";
        }

        private void btChapNhan_Click(object sender, EventArgs e)
        {
            pTB objTB = new pTB();
            objTB.tacvu = "";
            objTB.kid = objpCCT.pC.pfrom;
            objTB.diengiai = "Đơn vị " + objpCCT.pC.dK1.kten + " chấp nhận điều chuyển " + objpCCT.dVT.vTen + " số lượng " + objpCCT.cctsoluong;
            Main.db.pTB.Add(objTB);

            objpCCT.accept = 1;
            Main.db.SaveChanges();
            Load_LvVatTu();
            LoadFormEdit();
        }

        
    }
}
