using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using ClosedXML.Excel;

namespace BusinessLayer
{
    public class ThongKeBL
    {
        ThongKeDL thongkeDL = new ThongKeDL();

        public double TongDoanhThu(DataTable dt)
        {

            try
            {
                return thongkeDL.TongDoanhThu(dt);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public DataTable GetThongKeTheoThangNam(int thang, int nam)
        {
            try
            {
                DataTable dt = new DataTable();

                dt = thongkeDL.GetThongKeTheoThangNam(thang, nam);
               if(dt != null)
                {
                    // Tính tổng doanh thu
                    double Tong = TongDoanhThu(dt);
                    //Thêm cột tỉ lệ
                    dt.Columns.Add("tiLe", typeof(string));

                    // Gán tỉ lệ cho mỗi dòng trong dt
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row["doanhThu"] != DBNull.Value && Tong > 0)
                        {
                            double tiLe = Convert.ToDouble(row["doanhThu"]) * 100.0 / Tong;
                            row["tiLe"] = Math.Round(tiLe, 2).ToString("0.##") + "%";
                        }
                        else
                        {
                            row["tiLe"] = "0%";
                        }
                    }
                }    
                return dt;
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            
        }

        //
        public string ExportReportToExcelFile(DataTable dataTable)
        {
            string filePath = Path.Combine(Path.GetTempPath(), "BaoCaoThongKe_" + DateTime.Now.ToString("ddMMyyyy") + ".xlsx");

            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("BaoCao");

            // Header
            for (int col = 0; col < dataTable.Columns.Count; col++)
            {
                worksheet.Cell(1, col + 1).Value = dataTable.Columns[col].ColumnName;
            }

            // Data
            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    worksheet.Cell(row + 2, col + 1).Value = dataTable.Rows[row][col]?.ToString();
                }
            }

            worksheet.Columns().AdjustToContents();

            workbook.SaveAs(filePath);
           

            return filePath;
        }
    }
}
