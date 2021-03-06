﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.Design;
using QuanLyKho.ObjectRefrence;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace QuanLyKho.Service
{
    class Unit
    {
      
        public static void IsNumberic(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        public static double GetGiaVTTB(int idVT)
        {
            double tonggia = Convert.ToDouble(Main.db.pNCT.Where(pnct => pnct.vid == idVT).Sum(d => d.giathanh));
            double tongSL = Convert.ToDouble(Main.db.pNCT.Where(pnct => pnct.vid == idVT).Sum(d => d.nctsoluong));
            return Math.Round(tonggia / tongSL, 2);
        }

        public static void AddNewThongBao(string diengiai)
        {
            pTB objTB = new pTB();
            objTB.tacvu = "";
            objTB.diengiai = diengiai;
            objTB.accept = 1;
            objTB.kid = Main.OBJ_KHO.kid;
            Main.db.pTB.Add(objTB);
            Main.db.SaveChanges();
        }

        public static bool NhapMuaXuatThang(List<pNCT> lpnct, string ghichu, int to)
        {
            try
            {
                if (to != 0)
                {
                    DateTime dateServer = new DateTime();
                    dateServer = Main.getDateServer();
                    pC objPC = new pC();
                    objPC.pdate = dateServer;
                    objPC.pfrom = Main.OBJ_KHO.kid;
                    objPC.pto = to;
                    string maso = "PC" + SKho.SelectKhoID(Convert.ToInt32(Main.OBJ_KHO.kid)).kten + "-" + dateServer.Day + "" + dateServer.Month + "" + dateServer.Year;
                    maso = SPhieuChuyen.CheckMaSoPC(maso);
                    AddNewThongBao("");
                    objPC.cmaso = maso;
                    SPhieuChuyen.AddNewPhieuChuyen(objPC);
                    foreach (pNCT objPNCT in lpnct)
                    {
                        pCCT objPCCT = new pCCT();
                        //objPCCT.cctsoluong = objPNCT.nctsoluong;
                        objPCCT.vid = objPNCT.vid;
                        objPCCT.cid = objPC.cid;
                        objPCCT.diengiai = ghichu;
                        objPCCT.accept = 0;
                        Main.db.pCCT.Add(objPCCT);
                        Main.db.SaveChanges();
                    }

                    return true;
                }
                else
                {
                    DateTime dateServer = new DateTime();
                    dateServer = Main.getDateServer();
                    pSD objSD = new pSD();
                    objSD.sdate = dateServer;
                    string maso = "PSD" + SKho.SelectKhoID(Convert.ToInt32(Main.OBJ_KHO.kid)).kten + "-" + dateServer.Day + "" + dateServer.Month + "" + dateServer.Year;
                    maso = SPhieuSuDung.CheckMaSoPSD(maso);
                    objSD.smaso = maso;
                    objSD.kid = Main.OBJ_KHO.kid;
                    SPhieuSuDung.AddNewPhieuSuDung(objSD);
                    foreach (pNCT objPNCT in lpnct)
                    {

                        pSDCT objPSDCT = new pSDCT();
                        objPSDCT.diengiai = ghichu;
                        objPSDCT.vid = objPNCT.vid;
                        //objPSDCT.sdctsoluong = objPNCT.nctsoluong;
                        objPSDCT.sdid = objSD.sdid;
                        Main.db.pSDCT.Add(objPSDCT);
                        Main.db.SaveChanges();
                    }
                    return true;
                }
            }
            catch 
            {
                return false;

            }
        }

        public static List<ItemPhieu> TinhTongKho(List<ItemPhieu> pns, List<ItemPhieu> pcds)
        {
            bool isAdd = false;
            List<ItemPhieu> ptongs = new List   <ItemPhieu>();
            if (pns == null && pcds != null)
            {
                ptongs = pcds;
            }
            else if (pns != null && pcds == null)
            {
                ptongs = pns;
            }
            else if (pns != null && pcds != null)
            {
                foreach (var item in pns)
                {
                    for (int i = 0; i < pcds.Count; i++)
                    {
                        if (item.IdVatTu == pcds[i].IdVatTu)
                        {
                            isAdd = true;
                            item.SoLuong += pcds[i].SoLuong;
                            pcds.RemoveAt(i);
                            ptongs.Add(item);
                            break;
                        }
                    }
                    if (!isAdd)
                        ptongs.Add(item);
                    isAdd = false;
                }

                ptongs.AddRange(pcds);
            }
            return ptongs;
        }

        public static List<ItemPhieu> TinhTonKhoThongKe(string searchten, string tungay, string denngay)
        {
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

            List<ItemPhieu> tonkho = new List<ItemPhieu>();
            List<ItemPhieu> pns = (from pnct in Main.db.pNCT.Where(pnctk => pnctk.pN.kid == Main.OBJ_KHO.kid).GroupBy(pN => pN.vid).Select(pN => new ItemPhieu { IdVatTu = (int)pN.Key, SoLuong = (int)pN.Sum(pNCT => pNCT.nctsoluong) }) select pnct).ToList();
            List<ItemPhieu> psds = (from pnct in Main.db.pSDCT.Where(pnctk => pnctk.pSD.kid == Main.OBJ_KHO.kid).GroupBy(pN => pN.vid).Select(pN => new ItemPhieu { IdVatTu = (int)pN.Key, SoLuong = (int)pN.Sum(pNCT => pNCT.sdctsoluong) }) select pnct).ToList();
            List<ItemPhieu> pcds = (from pchuyenden in Main.db.pCCT.Where(pnctk => pnctk.pC.pto == Main.OBJ_KHO.kid).GroupBy(pSD => pSD.vid).Select(pSD => new ItemPhieu { IdVatTu = (int)pSD.Key, SoLuong = (int)pSD.Sum(pSDCT => pSDCT.cctsoluong) }) select pchuyenden).ToList();
            List<ItemPhieu> pcdis = (from pchuyenden in Main.db.pCCT.Where(pnctk => pnctk.pC.pfrom == Main.OBJ_KHO.kid).GroupBy(pSD => pSD.vid).Select(pSD => new ItemPhieu { IdVatTu = (int)pSD.Key, SoLuong = (int)pSD.Sum(pSDCT => pSDCT.cctsoluong) }) select pchuyenden).ToList();
            if ("".Equals(searchten) && dtDenNgay != dtSS && dtTuNgay == dtSS)
            {
                pns = (from pnct in Main.db.pNCT.Where(dn => dn.pN.ndate <= dtDenNgay).Where(pnctk => pnctk.pN.kid == Main.OBJ_KHO.kid).GroupBy(pN => pN.vid).Select(pN => new ItemPhieu { IdVatTu = (int)pN.Key, SoLuong = (int)pN.Sum(pNCT => pNCT.nctsoluong) }) select pnct).ToList();
                psds = (from pnct in Main.db.pSDCT.Where(dn => dn.pSD.sdate <= dtDenNgay).Where(pnctk => pnctk.pSD.kid == Main.OBJ_KHO.kid).GroupBy(pN => pN.vid).Select(pN => new ItemPhieu { IdVatTu = (int)pN.Key, SoLuong = (int)pN.Sum(pNCT => pNCT.sdctsoluong) }) select pnct).ToList();
                pcds = (from pchuyenden in Main.db.pCCT.Where(dn => dn.pC.pdate <= dtDenNgay).Where(pnctk => pnctk.pC.pto == Main.OBJ_KHO.kid).GroupBy(pSD => pSD.vid).Select(pSD => new ItemPhieu { IdVatTu = (int)pSD.Key, SoLuong = (int)pSD.Sum(pSDCT => pSDCT.cctsoluong) }) select pchuyenden).ToList();
                pcdis = (from pchuyenden in Main.db.pCCT.Where(dn => dn.pC.pdate <= dtDenNgay).Where(pnctk => pnctk.pC.pfrom == Main.OBJ_KHO.kid).GroupBy(pSD => pSD.vid).Select(pSD => new ItemPhieu { IdVatTu = (int)pSD.Key, SoLuong = (int)pSD.Sum(pSDCT => pSDCT.cctsoluong) }) select pchuyenden).ToList();
            }
            else if ("".Equals(searchten) && dtDenNgay == dtSS && dtTuNgay != dtSS)
            {
                pns = (from pnct in Main.db.pNCT.Where(dn => dn.pN.ndate >= dtTuNgay).Where(pnctk => pnctk.pN.kid == Main.OBJ_KHO.kid).GroupBy(pN => pN.vid).Select(pN => new ItemPhieu { IdVatTu = (int)pN.Key, SoLuong = (int)pN.Sum(pNCT => pNCT.nctsoluong) }) select pnct).ToList();
                psds = (from pnct in Main.db.pSDCT.Where(dn => dn.pSD.sdate >= dtTuNgay).Where(pnctk => pnctk.pSD.kid == Main.OBJ_KHO.kid).GroupBy(pN => pN.vid).Select(pN => new ItemPhieu { IdVatTu = (int)pN.Key, SoLuong = (int)pN.Sum(pNCT => pNCT.sdctsoluong) }) select pnct).ToList();
                pcds = (from pchuyenden in Main.db.pCCT.Where(dn => dn.pC.pdate >= dtTuNgay).Where(pnctk => pnctk.pC.pto == Main.OBJ_KHO.kid).GroupBy(pSD => pSD.vid).Select(pSD => new ItemPhieu { IdVatTu = (int)pSD.Key, SoLuong = (int)pSD.Sum(pSDCT => pSDCT.cctsoluong) }) select pchuyenden).ToList();
                pcdis = (from pchuyenden in Main.db.pCCT.Where(dn => dn.pC.pdate >= dtTuNgay).Where(pnctk => pnctk.pC.pfrom == Main.OBJ_KHO.kid).GroupBy(pSD => pSD.vid).Select(pSD => new ItemPhieu { IdVatTu = (int)pSD.Key, SoLuong = (int)pSD.Sum(pSDCT => pSDCT.cctsoluong) }) select pchuyenden).ToList();
            }
            else if ("".Equals(searchten) && dtDenNgay != dtSS && dtTuNgay != dtSS)
            {
                pns = (from pnct in Main.db.pNCT.Where(dn => dn.pN.ndate <= dtDenNgay).Where(dn => dn.pN.ndate >= dtTuNgay).Where(pnctk => pnctk.pN.kid == Main.OBJ_KHO.kid).GroupBy(pN => pN.vid).Select(pN => new ItemPhieu { IdVatTu = (int)pN.Key, SoLuong = (int)pN.Sum(pNCT => pNCT.nctsoluong) }) select pnct).ToList();
                psds = (from pnct in Main.db.pSDCT.Where(dn => dn.pSD.sdate <= dtDenNgay).Where(dn => dn.pSD.sdate >= dtTuNgay).Where(pnctk => pnctk.pSD.kid == Main.OBJ_KHO.kid).GroupBy(pN => pN.vid).Select(pN => new ItemPhieu { IdVatTu = (int)pN.Key, SoLuong = (int)pN.Sum(pNCT => pNCT.sdctsoluong) }) select pnct).ToList();
                pcds = (from pchuyenden in Main.db.pCCT.Where(dn => dn.pC.pdate <= dtDenNgay).Where(dn => dn.pC.pdate >= dtTuNgay).Where(pnctk => pnctk.pC.pto == Main.OBJ_KHO.kid).GroupBy(pSD => pSD.vid).Select(pSD => new ItemPhieu { IdVatTu = (int)pSD.Key, SoLuong = (int)pSD.Sum(pSDCT => pSDCT.cctsoluong) }) select pchuyenden).ToList();
                pcdis = (from pchuyenden in Main.db.pCCT.Where(dn => dn.pC.pdate <= dtDenNgay).Where(dn => dn.pC.pdate >= dtTuNgay).Where(pnctk => pnctk.pC.pfrom == Main.OBJ_KHO.kid).GroupBy(pSD => pSD.vid).Select(pSD => new ItemPhieu { IdVatTu = (int)pSD.Key, SoLuong = (int)pSD.Sum(pSDCT => pSDCT.cctsoluong) }) select pchuyenden).ToList();
            }
            else if (!"".Equals(searchten) && dtDenNgay == dtSS && dtTuNgay == dtSS)
            {
                pns = (from pnct in Main.db.pNCT.Where(pnctk => pnctk.pN.kid == Main.OBJ_KHO.kid).Where(sten => sten.dVT1.vTen.Contains(searchten)).GroupBy(pN => pN.vid).Select(pN => new ItemPhieu { IdVatTu = (int)pN.Key, SoLuong = (int)pN.Sum(pNCT => pNCT.nctsoluong) }) select pnct).ToList();
                psds = (from pnct in Main.db.pSDCT.Where(pnctk => pnctk.pSD.kid == Main.OBJ_KHO.kid).Where(sten => sten.dVT.vTen.Contains(searchten)).GroupBy(pN => pN.vid).Select(pN => new ItemPhieu { IdVatTu = (int)pN.Key, SoLuong = (int)pN.Sum(pNCT => pNCT.sdctsoluong) }) select pnct).ToList();
                pcds = (from pchuyenden in Main.db.pCCT.Where(pnctk => pnctk.pC.pto == Main.OBJ_KHO.kid).Where(sten => sten.dVT.vTen.Contains(searchten)).GroupBy(pSD => pSD.vid).Select(pSD => new ItemPhieu { IdVatTu = (int)pSD.Key, SoLuong = (int)pSD.Sum(pSDCT => pSDCT.cctsoluong) }) select pchuyenden).ToList();
                pcdis = (from pchuyenden in Main.db.pCCT.Where(pnctk => pnctk.pC.pfrom == Main.OBJ_KHO.kid).Where(sten => sten.dVT.vTen.Contains(searchten)).GroupBy(pSD => pSD.vid).Select(pSD => new ItemPhieu { IdVatTu = (int)pSD.Key, SoLuong = (int)pSD.Sum(pSDCT => pSDCT.cctsoluong) }) select pchuyenden).ToList();
            }
            else if (!"".Equals(searchten) && dtDenNgay == dtSS && dtTuNgay != dtSS)
            {
                pns = (from pnct in Main.db.pNCT.Where(sten => sten.dVT1.vTen.Contains(searchten)).Where(dn => dn.pN.ndate >= dtTuNgay).Where(pnctk => pnctk.pN.kid == Main.OBJ_KHO.kid).GroupBy(pN => pN.vid).Select(pN => new ItemPhieu { IdVatTu = (int)pN.Key, SoLuong = (int)pN.Sum(pNCT => pNCT.nctsoluong) }) select pnct).ToList();
                psds = (from pnct in Main.db.pSDCT.Where(sten => sten.dVT.vTen.Contains(searchten)).Where(dn => dn.pSD.sdate >= dtTuNgay).Where(pnctk => pnctk.pSD.kid == Main.OBJ_KHO.kid).GroupBy(pN => pN.vid).Select(pN => new ItemPhieu { IdVatTu = (int)pN.Key, SoLuong = (int)pN.Sum(pNCT => pNCT.sdctsoluong) }) select pnct).ToList();
                pcds = (from pchuyenden in Main.db.pCCT.Where(sten => sten.dVT.vTen.Contains(searchten)).Where(dn => dn.pC.pdate >= dtTuNgay).Where(pnctk => pnctk.pC.pto == Main.OBJ_KHO.kid).GroupBy(pSD => pSD.vid).Select(pSD => new ItemPhieu { IdVatTu = (int)pSD.Key, SoLuong = (int)pSD.Sum(pSDCT => pSDCT.cctsoluong) }) select pchuyenden).ToList();
                pcdis = (from pchuyenden in Main.db.pCCT.Where(sten => sten.dVT.vTen.Contains(searchten)).Where(dn => dn.pC.pdate >= dtTuNgay).Where(pnctk => pnctk.pC.pfrom == Main.OBJ_KHO.kid).GroupBy(pSD => pSD.vid).Select(pSD => new ItemPhieu { IdVatTu = (int)pSD.Key, SoLuong = (int)pSD.Sum(pSDCT => pSDCT.cctsoluong) }) select pchuyenden).ToList();
            }
            else if (!"".Equals(searchten) && dtDenNgay != dtSS && dtTuNgay == dtSS)
            {
                pns = (from pnct in Main.db.pNCT.Where(sten => sten.dVT1.vTen.Contains(searchten)).Where(dn => dn.pN.ndate <= dtDenNgay).Where(pnctk => pnctk.pN.kid == Main.OBJ_KHO.kid).GroupBy(pN => pN.vid).Select(pN => new ItemPhieu { IdVatTu = (int)pN.Key, SoLuong = (int)pN.Sum(pNCT => pNCT.nctsoluong) }) select pnct).ToList();
                psds = (from pnct in Main.db.pSDCT.Where(sten => sten.dVT.vTen.Contains(searchten)).Where(dn => dn.pSD.sdate <= dtDenNgay).Where(pnctk => pnctk.pSD.kid == Main.OBJ_KHO.kid).GroupBy(pN => pN.vid).Select(pN => new ItemPhieu { IdVatTu = (int)pN.Key, SoLuong = (int)pN.Sum(pNCT => pNCT.sdctsoluong) }) select pnct).ToList();
                pcds = (from pchuyenden in Main.db.pCCT.Where(sten => sten.dVT.vTen.Contains(searchten)).Where(dn => dn.pC.pdate <= dtDenNgay).Where(pnctk => pnctk.pC.pto == Main.OBJ_KHO.kid).GroupBy(pSD => pSD.vid).Select(pSD => new ItemPhieu { IdVatTu = (int)pSD.Key, SoLuong = (int)pSD.Sum(pSDCT => pSDCT.cctsoluong) }) select pchuyenden).ToList();
                pcdis = (from pchuyenden in Main.db.pCCT.Where(sten => sten.dVT.vTen.Contains(searchten)).Where(dn => dn.pC.pdate <= dtDenNgay).Where(pnctk => pnctk.pC.pfrom == Main.OBJ_KHO.kid).GroupBy(pSD => pSD.vid).Select(pSD => new ItemPhieu { IdVatTu = (int)pSD.Key, SoLuong = (int)pSD.Sum(pSDCT => pSDCT.cctsoluong) }) select pchuyenden).ToList();
            }
            else if (!"".Equals(searchten) && dtDenNgay != dtSS && dtTuNgay != dtSS)
            {
                pns = (from pnct in Main.db.pNCT.Where(sten => sten.dVT1.vTen.Contains(searchten)).Where(dn => dn.pN.ndate >= dtTuNgay).Where(dn => dn.pN.ndate <= dtDenNgay).Where(pnctk => pnctk.pN.kid == Main.OBJ_KHO.kid).GroupBy(pN => pN.vid).Select(pN => new ItemPhieu { IdVatTu = (int)pN.Key, SoLuong = (int)pN.Sum(pNCT => pNCT.nctsoluong) }) select pnct).ToList();
                psds = (from pnct in Main.db.pSDCT.Where(sten => sten.dVT.vTen.Contains(searchten)).Where(dn => dn.pSD.sdate >= dtTuNgay).Where(pnctk => pnctk.pSD.kid == Main.OBJ_KHO.kid).GroupBy(pN => pN.vid).Select(pN => new ItemPhieu { IdVatTu = (int)pN.Key, SoLuong = (int)pN.Sum(pNCT => pNCT.sdctsoluong) }) select pnct).ToList();
                pcds = (from pchuyenden in Main.db.pCCT.Where(sten => sten.dVT.vTen.Contains(searchten)).Where(dn => dn.pC.pdate >= dtTuNgay).Where(pnctk => pnctk.pC.pto == Main.OBJ_KHO.kid).GroupBy(pSD => pSD.vid).Select(pSD => new ItemPhieu { IdVatTu = (int)pSD.Key, SoLuong = (int)pSD.Sum(pSDCT => pSDCT.cctsoluong) }) select pchuyenden).ToList();
                pcdis = (from pchuyenden in Main.db.pCCT.Where(sten => sten.dVT.vTen.Contains(searchten)).Where(dn => dn.pC.pdate >= dtTuNgay).Where(pnctk => pnctk.pC.pfrom == Main.OBJ_KHO.kid).GroupBy(pSD => pSD.vid).Select(pSD => new ItemPhieu { IdVatTu = (int)pSD.Key, SoLuong = (int)pSD.Sum(pSDCT => pSDCT.cctsoluong) }) select pchuyenden).ToList();
            }
            else if ("".Equals(searchten) && dtDenNgay == dtSS && dtTuNgay == dtSS)
            {
                pns = (from pnct in Main.db.pNCT.Where(pnctk => pnctk.pN.kid == Main.OBJ_KHO.kid).GroupBy(pN => pN.vid).Select(pN => new ItemPhieu { IdVatTu = (int)pN.Key, SoLuong = (int)pN.Sum(pNCT => pNCT.nctsoluong) }) select pnct).ToList();
                psds = (from pnct in Main.db.pSDCT.Where(pnctk => pnctk.pSD.kid == Main.OBJ_KHO.kid).GroupBy(pN => pN.vid).Select(pN => new ItemPhieu { IdVatTu = (int)pN.Key, SoLuong = (int)pN.Sum(pNCT => pNCT.sdctsoluong) }) select pnct).ToList();
                pcds = (from pchuyenden in Main.db.pCCT.Where(pnctk => pnctk.pC.pto == Main.OBJ_KHO.kid).GroupBy(pSD => pSD.vid).Select(pSD => new ItemPhieu { IdVatTu = (int)pSD.Key, SoLuong = (int)pSD.Sum(pSDCT => pSDCT.cctsoluong) }) select pchuyenden).ToList();
                pcdis = (from pchuyenden in Main.db.pCCT.Where(pnctk => pnctk.pC.pfrom == Main.OBJ_KHO.kid).GroupBy(pSD => pSD.vid).Select(pSD => new ItemPhieu { IdVatTu = (int)pSD.Key, SoLuong = (int)pSD.Sum(pSDCT => pSDCT.cctsoluong) }) select pchuyenden).ToList();
            }
            List<ItemPhieu> ptongs = new List<ItemPhieu>();
            List<ItemPhieu> phieus = new List<ItemPhieu>();
            ptongs = Unit.TinhTongKho(pns, pcds);
            phieus = Unit.TinhTongKho(pcdis, psds);
            if (phieus == null)
                return ptongs;
            foreach (var item in phieus)
            {
                for (int i = 0; i < ptongs.Count; i++)
                {
                    if (item.IdVatTu == ptongs[i].IdVatTu)
                    {
                        ptongs[i].SoLuong = ptongs[i].SoLuong - item.SoLuong;
                        if (ptongs[i].SoLuong != 0)
                            tonkho.Add(ptongs[i]);
                        ptongs.RemoveAt(i);
                    }
                }
            }
            tonkho.AddRange(ptongs);
            return tonkho;
        }

        public static List<ItemPhieu> TinhTonKho(string searchten)
        {
            List<ItemPhieu> tonkho = new List<ItemPhieu>();
            List<ItemPhieu> pns = (from pnct in Main.db.pNCT.Where(pnctk => pnctk.pN.kid == Main.OBJ_KHO.kid).GroupBy(pN => pN.vid).Select(pN => new ItemPhieu { IdVatTu = (int)pN.Key, SoLuong = (int)pN.Sum(pNCT => pNCT.nctsoluong) }) select pnct).ToList();
            List<ItemPhieu> psds = (from pnct in Main.db.pSDCT.Where(pnctk => pnctk.pSD.kid == Main.OBJ_KHO.kid).GroupBy(pN => pN.vid).Select(pN => new ItemPhieu { IdVatTu = (int)pN.Key, SoLuong = (int)pN.Sum(pNCT => pNCT.sdctsoluong) }) select pnct).ToList();
            List<ItemPhieu> pcds = (from pchuyenden in Main.db.pCCT.Where(pnctk => pnctk.pC.pto == Main.OBJ_KHO.kid).GroupBy(pSD => pSD.vid).Select(pSD => new ItemPhieu { IdVatTu = (int)pSD.Key, SoLuong = (int)pSD.Sum(pSDCT => pSDCT.cctsoluong) }) select pchuyenden).ToList();
            List<ItemPhieu> pcdis = (from pchuyenden in Main.db.pCCT.Where(pnctk => pnctk.pC.pfrom == Main.OBJ_KHO.kid).GroupBy(pSD => pSD.vid).Select(pSD => new ItemPhieu { IdVatTu = (int)pSD.Key, SoLuong = (int)pSD.Sum(pSDCT => pSDCT.cctsoluong) }) select pchuyenden).ToList();
            if (!"".Equals(searchten))
            {
                pns = (from pnct in Main.db.pNCT.Where(pnctk => pnctk.pN.kid == Main.OBJ_KHO.kid).Where(sten => sten.dVT1.vTen.Contains(searchten)).GroupBy(pN => pN.vid).Select(pN => new ItemPhieu { IdVatTu = (int)pN.Key, SoLuong = (int)pN.Sum(pNCT => pNCT.nctsoluong) }) select pnct).ToList();
                psds = (from pnct in Main.db.pSDCT.Where(pnctk => pnctk.pSD.kid == Main.OBJ_KHO.kid).Where(sten => sten.dVT.vTen.Contains(searchten)).GroupBy(pN => pN.vid).Select(pN => new ItemPhieu { IdVatTu = (int)pN.Key, SoLuong = (int)pN.Sum(pNCT => pNCT.sdctsoluong) }) select pnct).ToList();
                pcds = (from pchuyenden in Main.db.pCCT.Where(pnctk => pnctk.pC.pto == Main.OBJ_KHO.kid).Where(sten => sten.dVT.vTen.Contains(searchten)).GroupBy(pSD => pSD.vid).Select(pSD => new ItemPhieu { IdVatTu = (int)pSD.Key, SoLuong = (int)pSD.Sum(pSDCT => pSDCT.cctsoluong) }) select pchuyenden).ToList();
                pcdis = (from pchuyenden in Main.db.pCCT.Where(pnctk => pnctk.pC.pfrom == Main.OBJ_KHO.kid).Where(sten => sten.dVT.vTen.Contains(searchten)).GroupBy(pSD => pSD.vid).Select(pSD => new ItemPhieu { IdVatTu = (int)pSD.Key, SoLuong = (int)pSD.Sum(pSDCT => pSDCT.cctsoluong) }) select pchuyenden).ToList();
            }
            List<ItemPhieu> ptongs = new List<ItemPhieu>();
            List<ItemPhieu> phieus = new List<ItemPhieu>();
            ptongs = TinhTongKho(pns, pcds);
            phieus = TinhTongKho(pcdis, psds);
            if (phieus == null)
                return ptongs;
            foreach (var item in phieus)
            {
                for (int i = 0; i < ptongs.Count; i++)
                {
                    if (item.IdVatTu == ptongs[i].IdVatTu)
                    {
                        ptongs[i].SoLuong = ptongs[i].SoLuong - item.SoLuong;
                        if (ptongs[i].SoLuong != 0)
                            tonkho.Add(ptongs[i]);
                        ptongs.RemoveAt(i);
                    }
                }
            }
            tonkho.AddRange(ptongs);
            return tonkho;
        }

        public static void sendMail(string subject, string body)
        {
            String from = "ktcd.hpc@gmail.com";

            

            DateTime dateNow = DateTime.Now.Date;
            
            var lEmail = (from objEmail in Main.db.dEmail select objEmail).ToList();

            NetworkCredential loginInfo = new NetworkCredential("ktcd.hpc@gmail.com", "1AnhTuan1*");

            MailMessage email = new MailMessage(from, lEmail[0].addEmail, subject, body);
            /*if (error.Length != 0)
            {
                ImageExportOptions image = baocao.ExportOptions.Image;

                baocao.ExportToImage(reportPath, image);
                Attachment data = new Attachment(reportPath);
                email.Attachments.Add(data);
            }*/

            for (int i = 0; i < lEmail.Count; i++)
            {
                if (i != 0)
                {
                    var objEmail = lEmail[i];
                    email.CC.Add(objEmail.addEmail);
                }
            }

            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.EnableSsl = true;
            client.Port = 25;
            client.UseDefaultCredentials = true;
            client.Credentials = loginInfo;
            client.Send(email);
        }
    }
}
