using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.Design;

namespace QuanLyKho.Service
{
    class SPhieuChuyenCT
    {
        public static List<pCCT> SearchChuyenChiTietByIDPN(int cid)
        {
            return (from pnct in Main.db.pCCT where pnct.cid == cid select pnct).ToList();
        }

        public static void AddNewPhieuChuyenChiTiet(List<pCCT> lcct, int kto)
        {
            pC objPC = new pC();
            objPC.pdate = Main.getDateServer();
            objPC.pfrom = Main.OBJ_KHO.kid;
            objPC.pto = kto;
            SPhieuChuyen.AddNewPhieuChuyen(objPC);
            foreach (pCCT objPCCT in lcct)
            {
                objPCCT.cid = objPC.cid;
                Main.db.pCCT.Add(objPCCT);
                Main.db.SaveChanges();
            }
        }
    }
}
