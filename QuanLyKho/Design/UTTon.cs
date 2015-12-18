using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKho.ObjectRefrence;
using QuanLyKho.Service;

namespace QuanLyKho.Design
{
    public partial class UTTon : UserControl
    {
        List<ItemPhieu> lItemPhieu;
        ItemPhieu objItemPhieu;

        public UTTon(List<ItemPhieu> lItemPhieu)
        {
            InitializeComponent();
            this.lItemPhieu = lItemPhieu;
            Load_LvVatTu();
        }

        private void Load_LvVatTu()
        {
            lvTKSD.Items.Clear();
            lvTKSD.Columns.Clear();
            lvTKSD.View = View.Details;

            ColumnHeader chSTT;
            chSTT = new ColumnHeader();
            chSTT.Text = "STT";
            chSTT.Width = 40;
            chSTT.TextAlign = HorizontalAlignment.Center;
            lvTKSD.Columns.Add(chSTT);

            ColumnHeader chTenVatTu;
            chTenVatTu = new ColumnHeader();
            chTenVatTu.Text = "Tên vật tư";
            chTenVatTu.Width = 125;
            chTenVatTu.TextAlign = HorizontalAlignment.Center;
            lvTKSD.Columns.Add(chTenVatTu);

            ColumnHeader chSoLuong;
            chSoLuong = new ColumnHeader();
            chSoLuong.Text = "Số lượng";
            chSoLuong.Width = 55;
            chSoLuong.TextAlign = HorizontalAlignment.Center;
            lvTKSD.Columns.Add(chSoLuong);

            lvTKSD.GridLines = true;
            lvTKSD.FullRowSelect = true;

            int i = 0;
            foreach (ItemPhieu itemPhieu in lItemPhieu)
            {
                lvTKSD.Items.Add((i + 1) + "");
                lvTKSD.Items[i].SubItems.Add(SVatTu.SelectVTbyID(itemPhieu.IdVatTu).vTen);
                lvTKSD.Items[i].SubItems.Add(itemPhieu.SoLuong+ "");
                i++;
            }

        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            lItemPhieu = Unit.TinhTonKhoThongKe(textBox2.Text, "", "");
            Load_LvVatTu();
        }

        private void lvTKSD_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem listviewItem in lvTKSD.SelectedItems)
            {
                objItemPhieu = new ItemPhieu();
                objItemPhieu = lItemPhieu[listviewItem.Index];
                tbVatTu.Text = SVatTu.SelectVTbyID(objItemPhieu.IdVatTu).vTen;
                tbSoLuong.Text = objItemPhieu.SoLuong + "";
            }
        }


    }
}
