using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.Design;

namespace QuanLyKho.Service
{
    class SPhieuSuDung
    {
        public static void AddNewPhieuSuDung(pSD objPSD)
        {
            Main.db.pSD.Add(objPSD);
            Main.db.SaveChanges();
        }

        public static List<pSDCT> GetAll()
        {
            return (from pn in Main.db.pSDCT where pn.pSD.kid == Main.OBJ_KHO.kid select pn).ToList();
        }

        public static string CheckMaSoPSD(string maso)
        {
            var lPN = (from pn in Main.db.pSD where pn.smaso.Contains(maso) where pn.kid == Main.OBJ_KHO.kid select pn).ToList();
            maso = lPN.Count == 0 ? maso + "-" + 1 : maso + "-" + (lPN.Count + 1);
            return maso;
        }

        public static void AddNewPhieuSuDungChiTiet(List<pSDCT> lpsdct)
        {
            pSD objSD = new pSD();
            objSD.sdate = Main.getDateServer();
            objSD.kid = Main.OBJ_KHO.kid;
            AddNewPhieuSuDung(objSD);
            foreach (pSDCT objSDCT in lpsdct)
            {
                objSDCT.sdid = objSD.sdid;
                Main.db.pSDCT.Add(objSDCT);
                Main.db.SaveChanges();
            }
        }

        public static List<pSDCT> SearchThongKeSuDung(string search, string tungay, string denngay)
        {
            List<pSDCT> lpnct = new List<pSDCT>();
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
                lpnct = (from pn in Main.db.pSDCT
                         where pn.pSD.kid == Main.OBJ_KHO.kid
                         where pn.pSD.sdate <= dtDenNgay
                         select pn).ToList();
            else if ("".Equals(search) && dtDenNgay == dtSS && dtTuNgay != dtSS)
                lpnct = (from pn in Main.db.pSDCT
                         where pn.pSD.kid == Main.OBJ_KHO.kid
                         where pn.pSD.sdate >= dtTuNgay
                         select pn).ToList();
            else if ("".Equals(search) && dtDenNgay != dtSS && dtTuNgay != dtSS)
                lpnct = (from pn in Main.db.pSDCT
                         where pn.pSD.kid == Main.OBJ_KHO.kid
                         where pn.pSD.sdate >= dtTuNgay
                         where pn.pSD.sdate <= dtDenNgay
                         select pn).ToList();
            else if (!"".Equals(search) && dtDenNgay == dtSS && dtTuNgay == dtSS)
                lpnct = (from pn in Main.db.pSDCT where pn.pSD.kid == Main.OBJ_KHO.kid where pn.dVT.vTen.Contains(search) select pn).ToList();
            else if (!"".Equals(search) && dtDenNgay == dtSS && dtTuNgay != dtSS)
                lpnct = (from pn in Main.db.pSDCT
                         where pn.pSD.kid == Main.OBJ_KHO.kid
                         where pn.dVT.vTen.Contains(search)
                         where pn.pSD.sdate >= dtTuNgay
                         select pn).ToList();
            else if (!"".Equals(search) && dtDenNgay != dtSS && dtTuNgay == dtSS)
                lpnct = (from pn in Main.db.pSDCT
                         where pn.pSD.kid == Main.OBJ_KHO.kid
                         where pn.dVT.vTen.Contains(search)
                         where pn.pSD.sdate <= dtDenNgay
                         select pn).ToList();
            else if (!"".Equals(search) && dtDenNgay != dtSS && dtTuNgay != dtSS)
                lpnct = (from pn in Main.db.pSDCT
                         where pn.pSD.kid == Main.OBJ_KHO.kid
                         where pn.dVT.vTen.Contains(search)
                         where pn.pSD.sdate >= dtTuNgay
                         where pn.pSD.sdate <= dtDenNgay
                         select pn).ToList();
            else if ("".Equals(search) && dtDenNgay == dtSS && dtTuNgay == dtSS)
                lpnct = (from pn in Main.db.pSDCT where pn.pSD.kid == Main.OBJ_KHO.kid select pn).ToList();
            return lpnct;
        }

        public static List<pSDCT> SearchThongKeByMay(int idmay, string tungay, string denngay)
        {
            List<pSDCT> lpnct = new List<pSDCT>();
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
            if (idmay == 0 && dtDenNgay != dtSS && dtTuNgay == dtSS)
                lpnct = (from pn in Main.db.pSDCT
                         where pn.pSD.kid == Main.OBJ_KHO.kid
                         where pn.pSD.sdate <= dtDenNgay
                         select pn).ToList();
            else if (idmay == 0 && dtDenNgay == dtSS && dtTuNgay != dtSS)
                lpnct = (from pn in Main.db.pSDCT
                         where pn.pSD.kid == Main.OBJ_KHO.kid
                         where pn.pSD.sdate >= dtTuNgay
                         select pn).ToList();
            else if (idmay == 0 && dtDenNgay != dtSS && dtTuNgay != dtSS)
                lpnct = (from pn in Main.db.pSDCT
                         where pn.pSD.kid == Main.OBJ_KHO.kid
                         where pn.pSD.sdate >= dtTuNgay
                         where pn.pSD.sdate <= dtDenNgay
                         select pn).ToList();
            else if (idmay != 0 && dtDenNgay == dtSS && dtTuNgay == dtSS)
                lpnct = (from pn in Main.db.pSDCT where pn.pSD.kid == Main.OBJ_KHO.kid where pn.dMay.id == idmay select pn).ToList();
            else if (idmay != 0 && dtDenNgay == dtSS && dtTuNgay != dtSS)
                lpnct = (from pn in Main.db.pSDCT
                         where pn.pSD.kid == Main.OBJ_KHO.kid
                         where pn.dMay.id == idmay
                         where pn.pSD.sdate >= dtTuNgay
                         select pn).ToList();
            else if (idmay != 0 && dtDenNgay != dtSS && dtTuNgay == dtSS)
                lpnct = (from pn in Main.db.pSDCT
                         where pn.pSD.kid == Main.OBJ_KHO.kid
                         where pn.dMay.id == idmay
                         where pn.pSD.sdate <= dtDenNgay
                         select pn).ToList();
            else if (idmay != 0 && dtDenNgay != dtSS && dtTuNgay != dtSS)
                lpnct = (from pn in Main.db.pSDCT
                         where pn.pSD.kid == Main.OBJ_KHO.kid
                         where pn.dMay.id == idmay
                         where pn.pSD.sdate >= dtTuNgay
                         where pn.pSD.sdate <= dtDenNgay
                         select pn).ToList();
            else if (idmay == 0 && dtDenNgay == dtSS && dtTuNgay == dtSS)
                lpnct = (from pn in Main.db.pSDCT where pn.pSD.kid == Main.OBJ_KHO.kid select pn).ToList();
            return lpnct;
        }
    }
}
