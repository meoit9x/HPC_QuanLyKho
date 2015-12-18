using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.ObjectRefrence
{
    public partial class ItemPhieu
    {
        public ItemPhieu(int id,double soluong,double dongia)
        {
            IdVatTu = id;
            SoLuong = soluong;
            DonGia = dongia;
        }

        public ItemPhieu()
        {
        }

        public int IdVatTu { get; set; }
        public double SoLuong { get; set; }
        public double DonGia { get; set; }
    }
}
