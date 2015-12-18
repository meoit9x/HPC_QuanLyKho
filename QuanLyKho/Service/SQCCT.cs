using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.Design;

namespace QuanLyKho.Service
{
    class SQCCT
    {
        public static List<dQCCT> SearchQuyCachChiTiet(int idVT)
        {
            return (from qcct in Main.db.dQCCT where qcct.vid == idVT select qcct).ToList();
        }

        public static List<dQCCT> AddNewQCCT(dQCCT objQCCT, int idVT)
        {
            Main.db.dQCCT.Add(objQCCT);
            Main.db.SaveChanges();
            SVatTu.SuaTenVatTu(idVT);
            return SearchQuyCachChiTiet(idVT);
        }

        public static List<dQCCT> EditQCCT(dQCCT objQCCT, int idVT)
        {
            Main.db.SaveChanges();
            SVatTu.SuaTenVatTu(idVT);
            return SearchQuyCachChiTiet(idVT);
        }

        public static List<dQCCT> XoaQCCT(dQCCT objQCCT, int idVT)
        {
            Main.db.dQCCT.Remove(objQCCT);
            Main.db.SaveChanges();
            SVatTu.SuaTenVatTu(idVT);
            return SearchQuyCachChiTiet(idVT);
        }

        public static dQCCT SelectQCCTbyQidVid(int qid, int vid)
        {
            return (from dqcct in Main.db.dQCCT where dqcct.vid == vid where dqcct.qid == qid select dqcct).FirstOrDefault();
        }

        public static List<dQCCT> SelectQCCTByidVT(int idVatTu)
        {
            return (from qcct in Main.db.dQCCT where qcct.vid == idVatTu select qcct).ToList();
        }

    }
}
