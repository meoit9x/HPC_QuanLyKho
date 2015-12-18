using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.Design;

namespace QuanLyKho.Service
{
    class SQC
    {
        public static dQC SelectQCbyTen(string tenQC)
        {
            return (from dqc in Main.db.dQC where dqc.qten == tenQC select dqc).FirstOrDefault();
        }

        public static dQC SelectQCbyID(int idqc)
        {
            return (from dqc in Main.db.dQC where dqc.qid == idqc select dqc).FirstOrDefault();
        }

        public static List<dQC> SearchQuyCach(string tenQC)
        {
            if ("".Equals(tenQC))
                return (from qc in Main.db.dQC select qc).ToList();
            else
                return (from qc in Main.db.dQC where qc.qten.Contains(tenQC) select qc).ToList();
        }

        public static List<dQC> AddNewQC(dQC objQC, string tenQC)
        {
            Main.db.dQC.Add(objQC);
            Main.db.SaveChanges();
            return SearchQuyCach(tenQC);
        }

        public static List<dQC> EditQC(dQC objQC, string tenQC)
        {
            Main.db.SaveChanges();
            return SearchQuyCach(tenQC);
        }

        public static List<dQC> XoaQC(dQC objQC, string tenQC)
        {
            if (SelectQCCTByidQC(objQC.qid).Count() == 0)
            {
                Main.db.dQC.Remove(objQC);
                Main.db.SaveChanges();
            }
            return SearchQuyCach(tenQC);
        }

        public static List<dQCCT> SelectQCCTByidQC(int idQC)
        {
            return (from qcct in Main.db.dQCCT where qcct.qid == idQC select qcct).ToList();
        }
    }
}
