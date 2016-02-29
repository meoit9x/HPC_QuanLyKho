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
            var item = Main.db.pN.FirstOrDefault(x => x.nid == id);
            return item;
        }

        public static List<pSDCT> GetSuDung(int id, DateTime fromDate, DateTime toDate)
        {
            

            var items = Main.db.pSDCT.Where(x => x.dMay.id == id && (x.pSD.sdate >= fromDate && x.pSD.sdate <= fromDate)).ToList();
            return items;
        }

        public static pC GetChuyen(int id)
        {
            var item = (from pc in Main.db.pC where pc.cid == id select pc).FirstOrDefault();
            return item;
        }

        public static List<phieuton> GetTon(int? idK)
        {
            List<phieuton> items = Main.db.Database.SqlQuery<phieuton>("exec baocaoton @id",
                new SqlParameter("@id", idK)).ToList();

            return items;
        }

        public static List<baocaonhap> GetNhap(int? idK, DateTime from, DateTime to)
        {
            List<baocaonhap> items = Main.db.Database.SqlQuery<baocaonhap>("exec baocaonhap @id",
                new SqlParameter("@id", idK),
                new SqlParameter("@fromdate", from),
                new SqlParameter("@todate", to)).ToList();

            return items;
        }

        public static List<baocaoxuat> GetXuat(int? idK, DateTime from, DateTime to)
        {
            List<baocaoxuat> items = Main.db.Database.SqlQuery<baocaoxuat>("exec baocaoxuat @id",
                new SqlParameter("@id", idK),
                new SqlParameter("@fromdate", from),
                new SqlParameter("@todate", to)).ToList();

            return items;
        }
    }
}
