using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class ThongKeBL
    {
        ThongKeDL thongkeDL = new ThongKeDL();

        public double TongDoanhThu(DataTable dt)
        {
            return thongkeDL.TongDoanhThu(dt);
        }
        public DataTable GetThongKeTheoThangNam(int thang, int nam)
        {
            DataTable dt = new DataTable();

            dt = thongkeDL.GetThongKeTheoThangNam(thang, nam);
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
            return dt;
        }
    }
}
