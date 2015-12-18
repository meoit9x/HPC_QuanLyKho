using QuanLyKho.Design;
using QuanLyKho.ObjectRefrence;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Service
{
    class SBaoCao
    {
        public static pN GetPhieuNhap(int id)
        {
            //var items = Main.db.Database.SqlQuery<phieunhap>("exec nhapvattu @id", new SqlParameter("@id", id)).ToList();

            var item = Main.db.pN.FirstOrDefault(x => x.nid == id);
            return item;
        }

        public static List<pSDCT> GetSuDung(int id, DateTime fromDate, DateTime toDate)
        {
            //var items = Main.db.Database.SqlQuery<phieusudung>("exec phieusudung @id, @fromDate, @toDate", 
            //    new SqlParameter("@id", id),
            //    new SqlParameter("@fromDate", fromDate),
            //    new SqlParameter("@toDate", toDate)).ToList();

            var items = Main.db.pSDCT.Where(x => x.dMay.id == id && (x.pSD.sdate >= fromDate && x.pSD.sdate <= fromDate)).ToList();
            return items;
        }

        public static pC GetChuyen(int id)
        {
            //var items = Main.db.pC.SqlQuery<phieuchuyen>("exec phieuchuyen @id",
            //    new SqlParameter("@id", id)).ToList();

            var item = (from pc in Main.db.pC where pc.cid == id select pc).FirstOrDefault();
            return item;
        }
    }
}
