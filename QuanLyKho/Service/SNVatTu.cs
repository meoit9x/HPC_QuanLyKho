using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.Design;

namespace QuanLyKho.Service
{
    class SNVatTu
    {
        public static dNVT SelectNVTbyTen(string tenNVT)
        {
            return (from dnvt in Main.db.dNVT where dnvt.tennhom == tenNVT select dnvt).FirstOrDefault();
        }

        public static List<dNVT> GetAll()
        {
            var NhomHang = (from nh in Main.db.dNVT select nh).ToList();
            return NhomHang;
        }

        public static List<dNVT> SearchNVT(string tenNhom)
        {
            if ("".Equals(tenNhom))
                return (from nvt in Main.db.dNVT select nvt).ToList();
            else
                return (from nvt in Main.db.dNVT where nvt.tennhom.Contains(tenNhom) select nvt).ToList();
        }

        public static List<dNVT> AddNewNhomHang(dNVT objNVT, string tenNhom)
        {
            Main.db.dNVT.Add(objNVT);
            Main.db.SaveChanges();
            return SearchNVT(tenNhom);
        }

        public static List<dNVT> EditNhomHang(dNVT objNVT, string tenNhom)
        {
            Main.db.SaveChanges();
            var lvt = (from vt in Main.db.dVT where vt.nvtid == objNVT.nvtid select vt).ToList();
            //foreach (dVT dvt in lvt)
            //{
            //EditTenVatTu(dvt);
            //}
            return SearchNVT(tenNhom);
        }

        public static dNVT SelectNVTbyID(int idNVT)
        {
            return (from dnvt in Main.db.dNVT where dnvt.nvtid == idNVT select dnvt).FirstOrDefault();
        }

        public static void EditTenVatTu1(dVT dvt)
        {
            string vten;
            int idvt = (int)dvt.nvtid;
            dNVT dnvt = new dNVT();
            dnvt = SelectNVTbyID(idvt);
            List<dQCCT> lQCCT = new List<dQCCT>();
            lQCCT = SQCCT.SelectQCCTByidVT(dvt.vid);
            vten = dnvt.tennhom;
            if (lQCCT.Count() != 0)
            {
                vten += " ";
                foreach (dQCCT qcct in lQCCT)
                {
                    vten += qcct.qthongso + "/";
                }
                vten = vten.Substring(0, vten.Length - 1);
            }
            dvt.vTen = vten;
            Main.db.SaveChanges();

        }



        public static List<dNVT> XoaNhomHang(dNVT objNVT, string tenNhom)
        {
            if (SelectVTByidNVT(objNVT.nvtid).Count() == 0)
            {
                Main.db.dNVT.Remove(objNVT);
                Main.db.SaveChanges();
            }
            return SearchNVT(tenNhom);
        }

        public static List<dVT> SelectVTByidNVT(int idVatTu)
        {
            return (from dvt in Main.db.dVT where dvt.nvtid == idVatTu select dvt).ToList();
        }
    }
}
