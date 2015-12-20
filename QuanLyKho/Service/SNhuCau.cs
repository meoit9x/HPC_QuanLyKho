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

        public static List<pNC> GetXetDuyet()
        {
            return (from nc in Main.db.pNC where nc.isgui != 0 select nc).ToList();
        }

        public static List<pNC> Search(int idKho, string ttuNgay, string tdenngay)
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


            if (idKho == 0 && tuNgay == ss && denngay == ss)
                return (from pnc in Main.db.pNC where pnc.isgui != 0 select pnc).ToList();
            else if (idKho != 0 && tuNgay == ss && denngay == ss)
                return (from pnc in Main.db.pNC where pnc.isgui != 0 where pnc.kid == idKho select pnc).ToList();
            else if (idKho != 0 && tuNgay != ss && denngay == ss)
                return (from pnc in Main.db.pNC where pnc.isgui != 0 where pnc.kid == idKho where pnc.ncdate == tuNgay select pnc).ToList();
            else if (idKho == 0 && tuNgay != ss && denngay == ss)
                return (from pnc in Main.db.pNC where pnc.isgui != 0 where pnc.ncdate == tuNgay select pnc).ToList();
            else if (idKho != 0 && tuNgay == ss && denngay != ss)
                return (from pnc in Main.db.pNC where pnc.isgui != 0 where pnc.kid == idKho where pnc.ncdate == tuNgay select pnc).ToList();
            else if (idKho == 0 && tuNgay == ss && denngay != ss)
                return (from pnc in Main.db.pNC where pnc.isgui != 0 where pnc.ncdate == denngay select pnc).ToList();
            else if (idKho == 0 && tuNgay != ss && denngay != ss)
                return (from pnc in Main.db.pNC where pnc.isgui != 0 where pnc.ncdate >= tuNgay where pnc.ncdate <= denngay select pnc).ToList();
            else
                return (from pnc in Main.db.pNC where pnc.isgui != 0 where pnc.kid == idKho where pnc.ncdate >= tuNgay where pnc.ncdate <= denngay select pnc).ToList();
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
