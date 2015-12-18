using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.Design;

namespace QuanLyKho.Service
{
    class SKho
    {
        public static List<dK> SearchKho()
        {
            return (from dk in Main.db.dK select dk).ToList();
        }

        public static List<dK> SelectKhoByNonUser()
        {
            return (from dk in Main.db.dK where dk.kid != Main.OBJ_KHO.kid select dk).ToList();
        }

        public static dK SelectKhoID(int kid)
        {
            return (from dk in Main.db.dK where dk.kid == kid select dk).FirstOrDefault();
        }

        public static List<dK> AddNewKho(dK objKho)
        {
            Main.db.dK.Add(objKho);
            Main.db.SaveChanges();
            return SearchKho();
        }

        public static List<dK> EditKho(dK objQC)
        {
            Main.db.SaveChanges();
            return SearchKho();
        }

        public static List<dK> XoaKho(dK objKho)
        {
            Main.db.dK.Remove(objKho);
            Main.db.SaveChanges();
            return SearchKho();
        }

        public static bool CheckXoaKho(dK objKho)
        {
            var pns = (from pn in Main.db.pN where pn.kid == objKho.kid select pn).ToList();
            if (pns.Count != 0)
                return false;
            var pcs = (from pc in Main.db.pC where pc.pfrom == objKho.kid select pc).ToList();
            if (pcs.Count != 0)
                return false;
            var pcs1 = (from pc in Main.db.pC where pc.pto == objKho.kid select pc).ToList();
            if (pcs1.Count != 0)
                return false;
            var psds = (from psd in Main.db.pSD where psd.kid == objKho.kid select psd).ToList();
            if (pns.Count != 0)
                return false;
            return true;
        }

    }
}
