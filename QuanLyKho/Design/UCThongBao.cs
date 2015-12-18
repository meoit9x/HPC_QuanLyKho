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
    public partial class UCThongBao : UserControl
    {
        List<pTB> lTB = new List<pTB>();

        public UCThongBao(List<pTB> lTB)
        {
            InitializeComponent();
            this.lTB = lTB;
            Load_LvNhomHang();
        }

        private void Load_LvNhomHang()
        {
            lvThongBao.Items.Clear();
            lvThongBao.Columns.Clear();
            lvThongBao.View = View.Details;

            ColumnHeader chSTT;
            chSTT = new ColumnHeader();
            chSTT.Text = "STT";
            chSTT.Width = 40;
            chSTT.TextAlign = HorizontalAlignment.Center;
            lvThongBao.Columns.Add(chSTT);

            ColumnHeader chTenNhom;
            chTenNhom = new ColumnHeader();
            chTenNhom.Text = "Diễn giải";
            chTenNhom.Width = 500;
            chTenNhom.TextAlign = HorizontalAlignment.Center;
            lvThongBao.Columns.Add(chTenNhom);

            lvThongBao.GridLines = true;
            lvThongBao.FullRowSelect = true;

            int i = 0;
            foreach (pTB tb in lTB)
            {
                lvThongBao.Items.Add((i + 1) + "");

                lvThongBao.Items[i].SubItems.Add(tb.diengiai);
                if(tb.accept == 0)
                    lvThongBao.Items[i].Font = new Font(lvThongBao.Font, FontStyle.Bold);
                i++;
            }
        }

        private void lvThongBao_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem listviewItem in lvThongBao.SelectedItems)
            {
                pTB tb = new pTB();
                tb = lTB[listviewItem.Index];
                if ("".Equals(tb.tacvu) || tb.tacvu == null)
                    return;
                tb.accept = 1;
                Main.db.SaveChanges();
                UCThongBaoChiTiet ucthongbaochitiet = new UCThongBaoChiTiet(tb.tacvu,tb.tbid);
                Main.pnParent.Controls.Clear();
                Main.pnParent.Controls.Add(ucthongbaochitiet);
            }
        }
    }
}
