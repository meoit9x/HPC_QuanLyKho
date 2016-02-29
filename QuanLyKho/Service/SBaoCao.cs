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
            List<baocaonhap> items = Main.db.Database.SqlQuery<baocaonhap>("exec baocaonhap @id, @fromdate, @todate",
                new SqlParameter("@id", idK),
                new SqlParameter("@fromdate", from),
                new SqlParameter("@todate", to)).ToList();

            return items;
        }

        public static List<baocaoxuat> GetXuat(int? idK, DateTime from, DateTime to)
        {
            List<baocaoxuat> items = Main.db.Database.SqlQuery<baocaoxuat>("exec baocaoxuat @id, @fromdate, @todate",
                new SqlParameter("@id", idK),
                new SqlParameter("@fromdate", from),
                new SqlParameter("@todate", to)).ToList();

            return items;
        }

        public static List<baocaonhapxuatton> GetXuatNhapTon(int? idK, DateTime from, DateTime to)
        {
            List<baocaonhapxuatton> items = Main.db.Database.SqlQuery<baocaonhapxuatton>("exec baocaoxuatnhapton @id, @fromdate, @todate",
                new SqlParameter("@id", idK),
                new SqlParameter("@fromdate", from),
                new SqlParameter("@todate", to)).ToList();

            return items;
        }

        public static List<baocaosudung> GetSuDung(int? idK, DateTime from, DateTime to, int? idVT)
        {
            List<baocaosudung> items = Main.db.Database.SqlQuery<baocaosudung>("exec baocaosudungvt @id, @fromdate, @todate, @idVT",
                new SqlParameter("@id", idK),
                new SqlParameter("@fromdate", from),
                new SqlParameter("@todate", to),
                new SqlParameter("@idVT", idVT)).ToList();

            return items;
        }

        public static List<baocaosudungmay> GetSuDungMay(int? idK, DateTime from, DateTime to, int? idMay)
        {
            List<baocaosudungmay> items = Main.db.Database.SqlQuery<baocaosudungmay>("exec nhatkysudungmay @id, @fromdate, @todate, @idMay",
                new SqlParameter("@id", idK),
                new SqlParameter("@fromdate", from),
                new SqlParameter("@todate", to),
                new SqlParameter("@idMay", idMay)).ToList();

            return items;
        }
    }
}
