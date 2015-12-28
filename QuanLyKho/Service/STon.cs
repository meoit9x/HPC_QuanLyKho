using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.Design;

namespace QuanLyKho.Service
{
    class STon
    {
        public static void AddTon(double soluong, int vid, double dongia, bool isAdd,int kid)
        {
            var objTon = (from ton in Main.db.pTon where ton.kid == kid where ton.vid == vid select ton).FirstOrDefault();
            if (objTon != null)
            {
                objTon.soluong = isAdd ? (objTon.soluong + soluong) : (objTon.soluong - soluong);
                objTon.dongia = dongia;
                if (objTon.soluong == 0)
                {
                    Main.db.pTon.Remove(objTon);
                }
                Main.db.SaveChanges();
            }
            else
            {
                objTon = new pTon();
                objTon.vid = vid;
                objTon.kid = kid;
                objTon.soluong = soluong;
                objTon.dongia = dongia;
                if (isAdd)
                {
                    Main.db.pTon.Add(objTon);
                    Main.db.SaveChanges();
                }
                else
                {
                    return;
                }
            }
        }

        public static List<pTon> getTon()
        {
            return (from ton in Main.db.pTon where ton.kid == Main.OBJ_KHO.kid select ton).ToList();
        }

    }
}
