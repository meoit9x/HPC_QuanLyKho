using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.Design;

namespace QuanLyKho.Service
{
    class SPhieuNhap
    {
        public static void AddNewPhieuNhap(List<pNCT> lpnct)
        {
            DateTime dateserver = new DateTime();
            dateserver = Main.getDateServer();
            pN objPhieuNhap = new pN();
            objPhieuNhap.kid = Main.OBJ_KHO.kid;
            objPhieuNhap.ndate = dateserver;
            string maso = "";
            maso = SKho.SelectKhoID(Convert.ToInt32(Main.OBJ_KHO.kid)).kten + "-" + dateserver.Day + "" + dateserver.Month + "" + dateserver.Year;
            maso = CheckMaSoPN(maso);
            objPhieuNhap.nmaso = maso;
            Main.db.pN.Add(objPhieuNhap);
            Main.db.SaveChanges();
            foreach (pNCT objPNCT in lpnct)
            {
                objPNCT.nid = objPhieuNhap.nid;
                Main.db.pNCT.Add(objPNCT);
                Main.db.SaveChanges();
            }
        }

        public static List<pN> GetAll()
        {
            return (from pn in Main.db.pN select pn).ToList();
        }

        public static List<pN> SearchSoHoaDon(string text,string ttuNgay, string tdenngay)
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
                return (from pn in Main.db.pN select pn).ToList();
            else if (!"".Equals(text) && tuNgay == ss && denngay == ss)
                return (from pn in Main.db.pN where pn.nmaso.Contains(text) select pn).ToList();
            else if (!"".Equals(text) && tuNgay != ss && denngay == ss)
                return (from pn in Main.db.pN where pn.nmaso.Contains(text) where pn.ngayhd == tuNgay select pn).ToList();
            else if ("".Equals(text) && tuNgay != ss && denngay == ss)
                return (from pn in Main.db.pN where pn.ngayhd == tuNgay select pn).ToList();
            else if (!"".Equals(text) && tuNgay == ss && denngay != ss)
                return (from pn in Main.db.pN where pn.nmaso.Contains(text) where pn.ngayhd == denngay select pn).ToList();
            else if ("".Equals(text) && tuNgay == ss && denngay != ss)
                return (from pn in Main.db.pN where pn.ngayhd == denngay select pn).ToList();
            else
                return (from pn in Main.db.pN where pn.nmaso.Contains(text) where pn.ngayhd <= denngay where pn.ngayhd >= tuNgay select pn).ToList();
        }

        public static List<pNCT> AddNewMotPhieuNhap(pNCT objPNCT)
        {
            Main.db.pNCT.Add(objPNCT);
            Main.db.SaveChanges();
            return (from pnct in Main.db.pNCT where pnct.pN.kid == Main.OBJ_KHO.kid select pnct).ToList();
        }

        public static List<pNCT> EditMotPhieuNhap(pNCT objPNCT)
        {
            Main.db.SaveChanges();
            return (from pnct in Main.db.pNCT where pnct.pN.kid == Main.OBJ_KHO.kid select pnct).ToList();
        }

        public static string CheckMaSoPN(string maso)
        {
            var lPN = (from pn in Main.db.pN where pn.nmaso.Contains(maso) where pn.kid == Main.OBJ_KHO.kid select pn).ToList();
            maso = lPN.Count == 0 ? maso + "-" + 1 : maso + "-" + (lPN.Count + 1);
            return maso;
        }

        public static List<pNCT> SearchPhieuNhap(string search)
        {

            if ("".Equals(search))
                return (from pn in Main.db.pNCT where pn.pN.kid == Main.OBJ_KHO.kid select pn).ToList();
            else
            {
                return (from pn in Main.db.pNCT where pn.pN.kid == Main.OBJ_KHO.kid where pn.dVT1.vTen.Contains(search) select pn).ToList();
            }
        }

        public static pN SearchPhieuNhapByID(int idPN)
        {
            return (from pn in Main.db.pN where pn.nid == idPN select pn).FirstOrDefault();
        }

        public static List<pNCT> SearchThongKeNhap(string search, string tungay, string denngay)
        {
            List<pNCT> lpnct = new List<pNCT>();
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
                lpnct = (from pn in Main.db.pNCT
                         where pn.pN.kid == Main.OBJ_KHO.kid
                         where pn.pN.ndate <= dtDenNgay
                         select pn).ToList();
            else if ("".Equals(search) && dtDenNgay == dtSS && dtTuNgay != dtSS)
                lpnct = (from pn in Main.db.pNCT
                         where pn.pN.kid == Main.OBJ_KHO.kid
                         where pn.pN.ndate >= dtTuNgay
                         select pn).ToList();
            else if ("".Equals(search) && dtDenNgay != dtSS && dtTuNgay != dtSS)
                lpnct = (from pn in Main.db.pNCT
                         where pn.pN.kid == Main.OBJ_KHO.kid
                         where pn.pN.ndate >= dtTuNgay
                         where pn.pN.ndate <= dtDenNgay
                         select pn).ToList();
            else if (!"".Equals(search) && dtDenNgay == dtSS && dtTuNgay == dtSS)
                lpnct = (from pn in Main.db.pNCT where pn.pN.kid == Main.OBJ_KHO.kid where pn.dVT1.vTen.Contains(search) select pn).ToList();
            else if (!"".Equals(search) && dtDenNgay == dtSS && dtTuNgay != dtSS)
                lpnct = (from pn in Main.db.pNCT
                         where pn.pN.kid == Main.OBJ_KHO.kid
                         where pn.dVT1.vTen.Contains(search)
                         where pn.pN.ndate >= dtTuNgay
                         select pn).ToList();
            else if (!"".Equals(search) && dtDenNgay != dtSS && dtTuNgay == dtSS)
                lpnct = (from pn in Main.db.pNCT
                         where pn.pN.kid == Main.OBJ_KHO.kid
                         where pn.dVT1.vTen.Contains(search)
                         where pn.pN.ndate <= dtDenNgay
                         select pn).ToList();
            else if (!"".Equals(search) && dtDenNgay != dtSS && dtTuNgay != dtSS)
                lpnct = (from pn in Main.db.pNCT
                         where pn.pN.kid == Main.OBJ_KHO.kid
                         where pn.dVT1.vTen.Contains(search)
                         where pn.pN.ndate >= dtTuNgay
                         where pn.pN.ndate <= dtDenNgay
                         select pn).ToList();
            else if ("".Equals(search) && dtDenNgay == dtSS && dtTuNgay == dtSS)
                lpnct = (from pn in Main.db.pNCT where pn.pN.kid == Main.OBJ_KHO.kid select pn).ToList();
            return lpnct;
        }
    }
}
