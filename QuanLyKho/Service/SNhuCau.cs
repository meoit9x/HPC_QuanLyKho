using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.Design;

namespace QuanLyKho.Service
{
    class SNhuCau
    {
        public static List<pNC> GetAll()
        {
            return (from nc in Main.db.pNC where nc.kid == Main.OBJ_KHO.kid select nc).ToList();
        }

        public static List<pNCCT> GetNCCTByIDNC(int id)
        {
            return (from ncct in Main.db.pNCCT where ncct.pNC.ncid == id select ncct).ToList();
        }

        public static List<pNC> GetNCByDate(DateTime tungay, DateTime denngay)
        {
            return (from nc in Main.db.pNC where nc.kid == Main.OBJ_KHO.kid where nc.ncdate >= tungay where nc.ncdate <= denngay select nc).ToList();
        }
    }
}
