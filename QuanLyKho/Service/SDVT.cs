using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.Design;

namespace QuanLyKho.Service
{
    class SDVT
    {
        public static List<dDVT> SearchDVT(string tenDVT)
        {
            if ("".Equals(tenDVT))
                return (from dvt in Main.db.dDVT select dvt).ToList();
            else
                return (from dvt in Main.db.dDVT where dvt.dvt.Contains(tenDVT) select dvt).ToList();
        }

        public static List<dDVT> AddNewDVT(dDVT objDVT, string tenDVT)
        {
            Main.db.dDVT.Add(objDVT);
            Main.db.SaveChanges();
            return SearchDVT(tenDVT);
        }

        public static List<dDVT> EditDVT(dDVT objDVT, string tenDVT)
        {
            Main.db.SaveChanges();
            return SearchDVT(tenDVT);
        }

        public static List<dDVT> XoaDVT(dDVT objDVT, string tenDVT)
        {
            if (SelectQCCTByidDVT(objDVT.dvtid).Count() == 0)
            {
                Main.db.dDVT.Remove(objDVT);
                Main.db.SaveChanges();
            }
            return SearchDVT(tenDVT);
        }

        public static List<dQCCT> SelectQCCTByidDVT(int idDVT)
        {
            return (from qcct in Main.db.dQCCT where qcct.dvtid == idDVT select qcct).ToList();
        }

        public static dDVT SelectDVTbyTen(string tenDVT)
        {
            return (from ddvt in Main.db.dDVT where ddvt.dvt == tenDVT select ddvt).FirstOrDefault();
        }

        public static dDVT SelectDVTbyID(int iddvt)
        {
            return (from dvt in Main.db.dDVT where dvt.dvtid == iddvt select dvt).FirstOrDefault();
        }

    }
}
