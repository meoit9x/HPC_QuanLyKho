using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.Design;

namespace QuanLyKho.Service
{
    class SPhieuChuyen
    {
        public static string CheckMaSoPC(string maso)
        {
            var lPN = (from pn in Main.db.pN where pn.nmaso.Contains(maso) where pn.kid == Main.OBJ_KHO.kid select pn).ToList();
            maso = lPN.Count == 0 ? maso + "-" + 1 : maso + "-" + (lPN.Count + 1);
            return maso;
        }

        public static List<pCCT> EditMotPhieuChuyen(pCCT objPCCT)
        {
            Main.db.SaveChanges();
            return (from pnct in Main.db.pCCT where pnct.pC.cid == objPCCT.pC.cid select pnct).ToList();
        }

        public static List<pC> SearchPhieuChuyen(string text, string ttuNgay, string tdenngay)
        {
            DateTime tuNgay = new DateTime();
            DateTime denngay = new DateTime();
            DateTime ss = new DateTime();
            try
            {
                tuNgay = Convert.ToDateTime(ttuNgay);
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }

            try
            {
                denngay = Convert.ToDateTime(tdenngay);
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }


            if ("".Equals(text) && tuNgay == ss && denngay == ss)
                return (from pn in Main.db.pC where pn.pfrom == Main.OBJ_KHO.kid select pn).ToList();
            else if (!"".Equals(text) && tuNgay == ss && denngay == ss)
                return (from pn in Main.db.pC where pn.pfrom == Main.OBJ_KHO.kid where pn.cmaso.Contains(text) select pn).ToList();
            else if (!"".Equals(text) && tuNgay != ss && denngay == ss)
                return (from pn in Main.db.pC where pn.pfrom == Main.OBJ_KHO.kid where pn.cmaso.Contains(text) where pn.pdate == tuNgay select pn).ToList();
            else if ("".Equals(text) && tuNgay != ss && denngay == ss)
                return (from pn in Main.db.pC where pn.pfrom == Main.OBJ_KHO.kid where pn.pdate == tuNgay select pn).ToList();
            else if (!"".Equals(text) && tuNgay == ss && denngay != ss)
                return (from pn in Main.db.pC where pn.pfrom == Main.OBJ_KHO.kid where pn.cmaso.Contains(text) where pn.pdate == denngay select pn).ToList();
            else if ("".Equals(text) && tuNgay == ss && denngay != ss)
                return (from pn in Main.db.pC where pn.pfrom == Main.OBJ_KHO.kid where pn.pdate == denngay select pn).ToList();
            else
                return (from pn in Main.db.pC where pn.pfrom == Main.OBJ_KHO.kid where pn.cmaso.Contains(text) where pn.pdate <= denngay where pn.pdate >= tuNgay select pn).ToList();
        }

        public static List<pC> GetPhieuChuyenDi()
        {
            return (from pc in Main.db.pC where pc.pfrom == Main.OBJ_KHO.kid select pc).ToList();
        }

        public static void AddNewPhieuChuyen(pC objPhieuChuyen)
        {
            Main.db.pC.Add(objPhieuChuyen);
            Main.db.SaveChanges();
        }

        public static List<pCCT> SearchThongDieuChuyen(string search, string tungay, string denngay)
        {
            List<pCCT> lpnct = new List<pCCT>();
            DateTime dtSS = new DateTime();
            DateTime dtDenNgay = new DateTime();
            try
            {
                dtDenNgay = DateTime.ParseExact(denngay, "dd/MM/yyyy", null);
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }

            DateTime dtTuNgay = new DateTime();
            try
            {
                dtTuNgay = DateTime.ParseExact(tungay, "dd/MM/yyyy", null);
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
            if ("".Equals(search) && dtDenNgay != dtSS && dtTuNgay == dtSS)
                lpnct = (from pn in Main.db.pCCT
                         where pn.pC.pfrom == Main.OBJ_KHO.kid
                         where pn.pC.pdate <= dtDenNgay
                         select pn).ToList();
            else if ("".Equals(search) && dtDenNgay == dtSS && dtTuNgay != dtSS)
                lpnct = (from pn in Main.db.pCCT
                         where pn.pC.pfrom == Main.OBJ_KHO.kid
                         where pn.pC.pdate >= dtTuNgay
                         select pn).ToList();
            else if ("".Equals(search) && dtDenNgay != dtSS && dtTuNgay != dtSS)
                lpnct = (from pn in Main.db.pCCT
                         where pn.pC.pfrom == Main.OBJ_KHO.kid
                         where pn.pC.pdate >= dtTuNgay
                         where pn.pC.pdate <= dtDenNgay
                         select pn).ToList();
            else if (!"".Equals(search) && dtDenNgay == dtSS && dtTuNgay == dtSS)
                lpnct = (from pn in Main.db.pCCT where pn.pC.pfrom == Main.OBJ_KHO.kid where pn.dVT.vTen.Contains(search) select pn).ToList();
            else if (!"".Equals(search) && dtDenNgay == dtSS && dtTuNgay != dtSS)
                lpnct = (from pn in Main.db.pCCT
                         where pn.pC.pfrom == Main.OBJ_KHO.kid
                         where pn.dVT.vTen.Contains(search)
                         where pn.pC.pdate >= dtTuNgay
                         select pn).ToList();
            else if (!"".Equals(search) && dtDenNgay != dtSS && dtTuNgay == dtSS)
                lpnct = (from pn in Main.db.pCCT
                         where pn.pC.pfrom == Main.OBJ_KHO.kid
                         where pn.dVT.vTen.Contains(search)
                         where pn.pC.pdate <= dtDenNgay
                         select pn).ToList();
            else if (!"".Equals(search) && dtDenNgay != dtSS && dtTuNgay != dtSS)
                lpnct = (from pn in Main.db.pCCT
                         where pn.pC.pfrom == Main.OBJ_KHO.kid
                         where pn.dVT.vTen.Contains(search)
                         where pn.pC.pdate >= dtTuNgay
                         where pn.pC.pdate <= dtDenNgay
                         select pn).ToList();
            else if ("".Equals(search) && dtDenNgay == dtSS && dtTuNgay == dtSS)
                lpnct = (from pn in Main.db.pCCT where pn.pC.pfrom == Main.OBJ_KHO.kid select pn).ToList();
            return lpnct;
        }

    }
}
