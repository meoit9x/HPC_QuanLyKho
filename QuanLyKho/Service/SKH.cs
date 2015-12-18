using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.Design;

namespace QuanLyKho.Service
{
    class SKH
    {
        public static List<dKH> GetAll()
        {
            return (from kh in Main.db.dKH select kh).ToList();
        }

        public static List<dKH> SearchTen(string tenKH)
        {
            if ("".Equals(tenKH))
                return (from kh in Main.db.dKH where kh.ten.Contains(tenKH) select kh).ToList();
            else
                return (from kh in Main.db.dKH select kh).ToList();
        }

        public static dKH SearchMaKH(string tenKH)
        {
            return (from kh in Main.db.dKH where kh.ten == tenKH select kh).FirstOrDefault();
        }

    }
}
