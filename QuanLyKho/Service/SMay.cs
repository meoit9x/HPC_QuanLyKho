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

        public static List<dMay> GetByKho(int kid)
        {
            return (from smay in Main.db.dMay where smay.kid == kid select smay).ToList();
        }

        public static List<dMay> SearchTen(string tenMay,int kid)
        {
            if (!"".Equals(tenMay))
                return (from smay in Main.db.dMay where smay.maso.Contains(tenMay) where smay.kid == kid select smay).ToList();
            else
                return (from smay in Main.db.dMay where smay.kid == kid select smay).ToList();
        }

        public static dMay SearchMay(int idmay)
        {
            return (from kh in Main.db.dMay where kh.id == idmay where kh.kid == Main.OBJ_KHO.kid select kh).FirstOrDefault();
        }

        public static dMay SearchMayTen(string maso)
        {
            return (from kh in Main.db.dMay where kh.maso == maso where kh.kid == Main.OBJ_KHO.kid select kh).FirstOrDefault();
        }
    }
}
