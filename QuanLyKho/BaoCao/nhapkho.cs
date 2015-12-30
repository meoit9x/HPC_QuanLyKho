using OfficeOpenXml;
using OfficeOpenXml.Style;
using QuanLyKho.Design;
using QuanLyKho.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho.BaoCao
{
    class nhapkho
    {
        public static MemoryStream xuatbaocaonhap(int id)
        {
            int i = 1;
            int rowStart = 8;
            int rowCurrent = rowStart;
            double? money = 0;
            ExcelPackage excelPackage = Util.Utils.LoadExcelTemplate("Templates/phieunhap.xlsx");
            ExcelWorksheet dataSheet = null;

            if (excelPackage == null)
            {
                MessageBox.Show("Chưa có template");
                return null;
            }

            OfficeOpenXml.ExcelWorkbook book = excelPackage.Workbook;
            dataSheet = book.Worksheets.FirstOrDefault();

            var item = SBaoCao.GetPhieuNhap(id);

            var dK = Main.db.dK.FirstOrDefault(x => x.kid == item.kid);
            var ngaynhap = item.ndate.Value;

            dataSheet.Cells[1, 1].Value = dK.kten;
            dataSheet.Cells[2, 2].Value = dK.diachi;
            dataSheet.Cells[5, 3].Value = "Ngày " + ngaynhap.Day + " tháng " + ngaynhap.Month + " năm " + ngaynhap.Year;
            dataSheet.Cells[5, 6].Value = item.nmaso;

            dataSheet.InsertRow(rowStart, item.pNCTs.Count, rowStart);

            foreach (var ct in item.pNCTs.ToList())
            {
                dataSheet.Cells[rowCurrent, 1].Value = i;
                dataSheet.Cells[rowCurrent, 2].Value = ct.dVT1.vTen;
                dataSheet.Cells[rowCurrent, 3].Value = ct.dVT1.dvt1;
                dataSheet.Cells[rowCurrent, 4].Value = ct.nctsoluong;
                dataSheet.Cells[rowCurrent, 4].Style.Numberformat.Format = "#,###.00";
                dataSheet.Cells[rowCurrent, 5].Value = ct.giathanh / ct.nctsoluong;
                dataSheet.Cells[rowCurrent, 5].Style.Numberformat.Format = "#,###.00";
                dataSheet.Cells[rowCurrent, 6].Value = ct.giathanh;
                dataSheet.Cells[rowCurrent, 6].Style.Numberformat.Format = "#,###";

                money = money + ct.giathanh;
                i++;
                rowCurrent++;
            }

            dataSheet.Cells[rowCurrent, 2].Value = "Tổng cộng:";
            dataSheet.Cells[rowCurrent, 2].Style.Font.Bold = true;
            dataSheet.Cells[rowCurrent, 4].Formula = "=SUM(D" + rowStart + ":D" + (rowCurrent - 1) + ")";
            dataSheet.Cells[rowCurrent, 4].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
            dataSheet.Cells[rowCurrent, 4].Style.Font.Bold = true;
            dataSheet.Cells[rowCurrent, 5].Formula = "=SUM(E" + rowStart + ":E" + (rowCurrent - 1) + ")";
            dataSheet.Cells[rowCurrent, 5].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
            dataSheet.Cells[rowCurrent, 5].Style.Font.Bold = true;
            dataSheet.Cells[rowCurrent, 6].Formula = "=SUM(F" + rowStart + ":F" + (rowCurrent - 1) + ")";
            dataSheet.Cells[rowCurrent, 6].Style.Numberformat.Format = "#,###";
            dataSheet.Cells[rowCurrent, 6].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
            dataSheet.Cells[rowCurrent, 6].Style.Font.Bold = true;


            dataSheet.Cells[rowCurrent + 2, 2].Value = Util.Utils.DocTienBangChu((long)money, " đồng");

            MemoryStream excelStream = new MemoryStream();
            excelPackage.SaveAs(excelStream);
            excelStream.Seek(0, SeekOrigin.Begin);

            return excelStream;
        }

        public static void xuatbaocaosudung(List<pSDCT> lpsdct)
        {
            int i = 1;
            int rowStart = 9;
            int rowCurrent = rowStart;
            double? money = 0;
            ExcelPackage excelPackage = Util.Utils.LoadExcelTemplate("Templates/phieusudung.xlsx");
            ExcelWorksheet dataSheet = null;

            if (excelPackage == null)
            {
                MessageBox.Show("Chưa có template");
                return;
            }

            OfficeOpenXml.ExcelWorkbook book = excelPackage.Workbook;
            dataSheet = book.Worksheets.FirstOrDefault();

            var items = lpsdct;
            var psd = lpsdct.FirstOrDefault().pSD;

            var dK = Main.db.dK.FirstOrDefault(x => x.kid == Main.OBJ_KHO.kid);

            dataSheet.Cells[1, 1].Value = dK.kten;
            dataSheet.Cells[2, 2].Value = dK.diachi;

            var now = DateTime.Now;
            if (psd.sdate != null)
            {
                dataSheet.Cells[5, 3].Value = "Ngày " + psd.sdate.Value.Day + " tháng " + psd.sdate.Value.Month + " năm " + psd.sdate.Value.Year;
            }

            dataSheet.Cells[5, 7].Value = items.FirstOrDefault().pSD.smaso;

            dataSheet.InsertRow(rowStart, items.Count, rowStart);

            foreach (var item in items)
            {
                double? thanhtien = item.sdctsoluong * item.dongia;
                dataSheet.Cells[rowCurrent, 1].Value = i;
                dataSheet.Cells[rowCurrent, 2].Value = item.dVT.vTen;
                dataSheet.Cells[rowCurrent, 3].Value = item.dVT.dvt1;
                dataSheet.Cells[rowCurrent, 3].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                dataSheet.Cells[rowCurrent, 4].Value = item.sdctsoluong;
                dataSheet.Cells[rowCurrent, 4].Style.Numberformat.Format = "#,###.00";
                dataSheet.Cells[rowCurrent, 5].Value = item.dongia;
                dataSheet.Cells[rowCurrent, 5].Style.Numberformat.Format = "#,###.00";
                dataSheet.Cells[rowCurrent, 6].Value = thanhtien;
                dataSheet.Cells[rowCurrent, 6].Style.Numberformat.Format = "#,###";
                dataSheet.Cells[rowCurrent, 7].Value = item.dMay.tenmay;
                dataSheet.Cells[rowCurrent, 7].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                money = money + thanhtien;
                i++;
                rowCurrent++;
            }

            dataSheet.Cells[rowCurrent, 2].Value = "Tổng cộng:";
            dataSheet.Cells[rowCurrent, 2].Style.Font.Bold = true;
            dataSheet.Cells[rowCurrent, 4].Formula = "=SUM(D" + rowStart + ":D" + (rowCurrent - 1) + ")";
            dataSheet.Cells[rowCurrent, 4].Style.Numberformat.Format = "#,###.00";
            dataSheet.Cells[rowCurrent, 4].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
            dataSheet.Cells[rowCurrent, 5].Formula = "=SUM(E" + rowStart + ":E" + (rowCurrent - 1) + ")";
            dataSheet.Cells[rowCurrent, 5].Style.Numberformat.Format = "#,###.00";
            dataSheet.Cells[rowCurrent, 5].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
            dataSheet.Cells[rowCurrent, 6].Formula = "=SUM(F" + rowStart + ":F" + (rowCurrent - 1) + ")";
            dataSheet.Cells[rowCurrent, 6].Style.Numberformat.Format = "#,###";
            dataSheet.Cells[rowCurrent, 6].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;

            dataSheet.Cells[rowCurrent + 2, 2].Value = Util.Utils.DocTienBangChu((long)money, " đồng");

            MemoryStream excelStream = new MemoryStream();
            excelPackage.SaveAs(excelStream);
            excelStream.Seek(0, SeekOrigin.Begin);

            Util.Utils.DialogSave(excelStream);
        }

        public static void xuatbaocaochuyen(int id)
        {
            int i = 1;
            int rowStart = 10;
            int rowCurrent = rowStart;
            double? money = 0;
            ExcelPackage excelPackage = Util.Utils.LoadExcelTemplate("Templates/phieuchuyen.xlsx");
            ExcelWorksheet dataSheet = null;

            if (excelPackage == null)
            {
                MessageBox.Show("Chưa có template");
                return;
            }

            OfficeOpenXml.ExcelWorkbook book = excelPackage.Workbook;
            dataSheet = book.Worksheets.FirstOrDefault();

            var item = SBaoCao.GetChuyen(id);

            if (item.dK == null)
            {
                item.dK = SKho.SelectKhoID(Convert.ToInt32(item.pfrom));
            }
            dataSheet.Cells[1, 1].Value = item.dK.kten;
            dataSheet.Cells[2, 2].Value = item.dK.diachi;
            dataSheet.Cells[5, 3].Value = "Ngày " + item.pdate.Day + " tháng " + item.pdate.Month + " năm " + item.pdate.Year;

            dataSheet.Cells[5, 6].Value = item.cmaso;
            dataSheet.Cells[7, 3].Value = item.dK1.kten;

            dataSheet.InsertRow(rowCurrent, item.pCCTs.Count, rowStart);

            foreach (var pc in item.pCCTs.ToList())
            {
                double? thanhtien = pc.dongia * pc.cctsoluong;

                dataSheet.Cells[rowCurrent, 1].Value = i;
                dataSheet.Cells[rowCurrent, 2].Value = pc.dVT.vTen;
                if (pc.dVT.dDVT != null)
                {
                    dataSheet.Cells[rowCurrent, 3].Value = pc.dVT.dDVT.dvt;
                }
                dataSheet.Cells[rowCurrent, 4].Value = pc.cctsoluong;
                dataSheet.Cells[rowCurrent, 4].Style.Numberformat.Format = "#,###.00";
                dataSheet.Cells[rowCurrent, 5].Value = pc.dongia;
                dataSheet.Cells[rowCurrent, 5].Style.Numberformat.Format = "#,###.00";
                dataSheet.Cells[rowCurrent, 6].Value = pc.dongia * pc.cctsoluong;
                dataSheet.Cells[rowCurrent, 6].Style.Numberformat.Format = "#,###";

                money = money + thanhtien;

                i++;
                rowCurrent++;
            }

            dataSheet.Cells[rowCurrent, 2].Value = "Tổng cộng:";
            dataSheet.Cells[rowCurrent, 2].Style.Font.Bold = true;
            dataSheet.Cells[rowCurrent, 4].Formula = "=SUM(D" + rowStart + ":D" + (rowCurrent - 1) + ")";
            dataSheet.Cells[rowCurrent, 4].Style.Numberformat.Format = "#,###.00";
            dataSheet.Cells[rowCurrent, 4].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
            dataSheet.Cells[rowCurrent, 4].Style.Font.Bold = true;
            dataSheet.Cells[rowCurrent, 5].Formula = "=SUM(E" + rowStart + ":E" + (rowCurrent - 1) + ")";
            dataSheet.Cells[rowCurrent, 5].Style.Numberformat.Format = "#,###.00";
            dataSheet.Cells[rowCurrent, 5].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
            dataSheet.Cells[rowCurrent, 5].Style.Font.Bold = true;
            dataSheet.Cells[rowCurrent, 6].Formula = "=SUM(F" + rowStart + ":F" + (rowCurrent - 1) + ")";
            dataSheet.Cells[rowCurrent, 6].Style.Numberformat.Format = "#,###";
            dataSheet.Cells[rowCurrent, 6].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
            dataSheet.Cells[rowCurrent, 6].Style.Font.Bold = true;

            dataSheet.Cells[rowCurrent + 2, 2].Value = Util.Utils.DocTienBangChu((long)money, " đồng");

            MemoryStream excelStream = new MemoryStream();
            excelPackage.SaveAs(excelStream);
            excelStream.Seek(0, SeekOrigin.Begin);

            Util.Utils.DialogSave(excelStream);
        }

        public static MemoryStream xuatbaocaonhucau(pNC objNC, List<pNCCT> lpncct)
        {
            int i = 1;
            int rowStart = 11;
            int rowCurrent = rowStart;
            DateTime now = DateTime.Now;
            ExcelPackage excelPackage = Util.Utils.LoadExcelTemplate("Templates/nhucau.xlsx");
            ExcelWorksheet dataSheet = null;

            if (excelPackage == null)
            {
                MessageBox.Show("Chưa có template");
                return null;
            }

            OfficeOpenXml.ExcelWorkbook book = excelPackage.Workbook;
            dataSheet = book.Worksheets.FirstOrDefault();

            dataSheet.Cells[4, 11].Value = "Ngày: " + now.Day + "/" + now.Month + "/" + now.Year;

            dataSheet.Cells[5, 5].Value = Main.db.dK.FirstOrDefault(x => x.kid == objNC.kid).kten;
            if (objNC.dK != null)
                dataSheet.Cells[6, 6].Value = objNC.dK.kten;

            if (objNC.tgcan.HasValue)
                dataSheet.Cells[7, 4].Value = "Ngày " + objNC.tgcan.Value.Day + " tháng " + objNC.tgcan.Value.Month + " năm " + objNC.tgcan.Value.Year;
            dataSheet.Cells[8, 4].Value = objNC.mucdich;

            dataSheet.InsertRow(rowCurrent, lpncct.Count, rowStart);

            foreach (var item in lpncct)
            {
                using (ExcelRange rng = dataSheet.Cells["A" + rowCurrent + ":" + "N" + rowCurrent])
                {
                    rng.Style.Border.Top.Style = rng.Style.Border.Left.Style = rng.Style.Border.Right.Style = rng.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                }

                using (ExcelRange rng = dataSheet.Cells["L" + rowCurrent + ":" + "N" + rowCurrent])
                {
                    rng.Merge = true;
                }

                dataSheet.Cells[rowCurrent, 1].Value = i;

                if (item.dVT != null)
                {
                    using (ExcelRange rng = dataSheet.Cells["B" + rowCurrent + ":" + "D" + rowCurrent])
                    {
                        rng.Merge = true;
                        rng.Value = item.dVT.vTen;
                    }
                }

                if (item.dVT != null)
                    dataSheet.Cells[rowCurrent, 5].Value = item.dVT.dvt1;

                dataSheet.Cells[rowCurrent, 6].Value = item.ncsoluong;
                dataSheet.Cells[rowCurrent, 7].Value = item.diengiai;
                dataSheet.Cells[rowCurrent, 8].Value = item.tonsoluong;

                i++;
                rowCurrent++;
            }

            using (ExcelRange rng = dataSheet.Cells["A" + rowCurrent + ":" + "N" + rowCurrent])
            {
                rng.Style.Border.Top.Style = rng.Style.Border.Left.Style = rng.Style.Border.Right.Style = rng.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            }

            using (ExcelRange rng = dataSheet.Cells["B" + rowCurrent + ":" + "D" + rowCurrent])
            {
                rng.Merge = true;
                rng.Value = "Tổng cộng:";
                rng.Style.Font.Bold = true;
            }

            dataSheet.Cells[rowCurrent, 6].Formula = "=SUM(F" + rowStart + ":F" + (rowCurrent - 1) + ")";
            dataSheet.Cells[rowCurrent, 6].Style.Numberformat.Format = "#,###";

            dataSheet.Cells[rowCurrent, 11].Formula = "=SUM(K" + rowStart + ":K" + (rowCurrent - 1) + ")";
            dataSheet.Cells[rowCurrent, 11].Style.Numberformat.Format = "#,###";

            MemoryStream excelStream = new MemoryStream();
            excelPackage.SaveAs(excelStream);
            excelStream.Seek(0, SeekOrigin.Begin);

            return excelStream;
        }
    }
}
