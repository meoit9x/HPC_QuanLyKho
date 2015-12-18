using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.Design;

namespace QuanLyKho.Service
{
    class SMay
    {
        public static List<dMay> GetAll()
        {
            return (from smay in Main.db.dMay where smay.kid == Main.OBJ_KHO.kid select smay).ToList();
        }

        public static List<dMay> SearchTen(string tenMay)
        {
            if ("".Equals(tenMay))
                return (from smay in Main.db.dMay where smay.tenmay.Contains(tenMay) where smay.kid == Main.OBJ_KHO.kid select smay).ToList();
            else
                return (from smay in Main.db.dMay where smay.kid == Main.OBJ_KHO.kid select smay).ToList();
        }

        public static dMay SearchMay(string tenKH)
        {
            return (from kh in Main.db.dMay where kh.tenmay == tenKH where kh.kid == Main.OBJ_KHO.kid select kh).FirstOrDefault();
        }
    }
}
