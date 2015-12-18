using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.Design;

namespace QuanLyKho.Service
{
    class SVatTu
    {

        public static List<dVT> GetAll()
        {
            return (from vt in Main.db.dVT where vt.isupdate == 0 select vt).ToList();
        }

        public static dVT SelectVTbyID(int idVT)
        {
            return (from vt in Main.db.dVT where vt.vid == idVT select vt).FirstOrDefault();
        }

        public static dVT SelectVTbyTen(string vten)
        {
            return (from vt in Main.db.dVT where vt.vTen == vten select vt).FirstOrDefault();
        }

        public static dVT SelectVTbyMa(string vma)
        {
            return (from vt in Main.db.dVT where vt.mavt == vma select vt).FirstOrDefault();
        }

        public static void SuaTenVatTu(int idVT)
        {
            var objvt = (from dvt in Main.db.dVT where dvt.vid == idVT select dvt).FirstOrDefault();
            //SNVatTu.EditTenVatTu(objvt);
        }

        public static int CheckXoaVatTu(int idVT)
        {
            var query = Main.db.Database.SqlQuery<Int32>("Exec KTXoaVatTu " + idVT);
            return query.AsEnumerable().First();
        }

        public static List<dVT> XoaVatTu(dVT dvt)
        {
            List<dQCCT> lQCCT = new List<dQCCT>();
            lQCCT = (from qcct in Main.db.dQCCT where qcct.vid == dvt.vid select qcct).ToList();
            foreach (dQCCT qcct in lQCCT)
            {
                Main.db.dQCCT.Remove(qcct);
                Main.db.SaveChanges();
            }
            Main.db.dVT.Remove(dvt);
            Main.db.SaveChanges();
            return SearchVatTu("");
        }

        public static List<dVT> SearchVatTu(string text)
        {
            if ("".Equals(text))
            {
                return (from dvt in Main.db.dVT  select dvt).ToList();
            }
            else
            {
                List<dVT> lVT = new List<dVT>();
                lVT = (from dvt in Main.db.dVT where dvt.vTen.Contains(text)  select dvt).ToList();
                return lVT;
            }
        }

        public static List<dVT> SearchVatTubyMa(string text)
        {
            if ("".Equals(text))
            {
                return (from dvt in Main.db.dVT  select dvt).ToList();
            }
            else
            {
                List<dVT> lVT = new List<dVT>();
                lVT = (from dvt in Main.db.dVT where dvt.mavt.Contains(text)  select dvt).ToList();
                return lVT;
            }
        }

        public static List<dVT> AddNewVatTu(dVT dvt)
        {
            Main.db.dVT.Add(dvt);
            Main.db.SaveChanges();
            return SearchVatTu("");
        }

        public static List<dVT> EditVatTu(dVT dvt)
        {
            Main.db.SaveChanges();
            return SearchVatTu("");
        }

        public static List<dVT> GetVTByNVT(int idNVT)
        {
            return (from dvt in Main.db.dVT where dvt.dNVT.nvtid == idNVT where dvt.isupdate ==0 select dvt).ToList();
        }

        public static List<dVT> SaoChepVatTu(dVT dvt)
        {
            dVT objVatTu = new dVT();
            objVatTu.vTen = dvt.vTen;
            objVatTu.nvtid = dvt.nvtid;
            objVatTu.isupdate = 0;
            Main.db.dVT.Add(objVatTu);
            Main.db.SaveChanges();
            List<dQCCT> lqcct = new List<dQCCT>();
            lqcct = SQCCT.SelectQCCTByidVT(dvt.vid);
            foreach (dQCCT dqcct in lqcct)
            {
                dQCCT objQCCT = new dQCCT();
                objQCCT.dvtid = dqcct.dvtid;
                objQCCT.qid = dqcct.qid;
                objQCCT.vid = objVatTu.vid;
                objQCCT.qthongso = dqcct.qthongso;
                Main.db.dQCCT.Add(objQCCT);
                Main.db.SaveChanges();
            }

            return SearchVatTu("");
        }


    }
}
