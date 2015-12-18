using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.Design;

namespace QuanLyKho.Service
{
    class SPhieuNhapCT
    {
        public static List<pNCT> XoaPhieuNhapChiTiet(pNCT objPNCT)
        {
            int nid = (int)objPNCT.nid;
            Main.db.pNCT.Remove(objPNCT);
            Main.db.SaveChanges();
            return (from pnct in Main.db.pNCT where pnct.nid == nid select pnct).ToList();
        }

        public static List<pNCT> EditPhieuNhapChiTiet(pNCT objPNCT)
        {
            int nid = (int)objPNCT.nid;
            Main.db.SaveChanges();
            return (from pnct in Main.db.pNCT where pnct.nid == nid select pnct).ToList();
        }

        public static List<pNCT> AddNewPhieuNhapChiTiet(pNCT objPNCT)
        {
            int nid = (int)objPNCT.nid;
            var _pnct = (from pnct in Main.db.pNCT where pnct.nid == nid where pnct.vid == objPNCT.vid select pnct).FirstOrDefault();
            if (_pnct != null)
            {
                _pnct.nctsoluong = _pnct.nctsoluong + objPNCT.nctsoluong;
            }
            else
            {
                Main.db.pNCT.Add(objPNCT);
            }
            Main.db.SaveChanges();
            return (from pnct in Main.db.pNCT where pnct.nid == nid select pnct).ToList();
        }

        public static List<pNCT> SearchNhapChiTiet(string search, int nid)
        {
            if (!"".Equals(search))
                return (from pnct in Main.db.pNCT where pnct.dVT1.vTen.Contains(search) where pnct.nid == nid select pnct).ToList();
            else
                return (from pnct in Main.db.pNCT where pnct.nid == nid select pnct).ToList();
        }

        public static List<pNCT> SearchNhapChiTietByIDPN(int nid)
        {
             return (from pnct in Main.db.pNCT where pnct.nid == nid select pnct).ToList();
        }
    }
}
