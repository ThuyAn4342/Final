using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace DataLayer
{
    public class ThongKeDL
    {
        DataProvider provider = new DataProvider();

        public double TongDoanhThu (DataTable dt)
        {
            try
            {
                // Tính tổng doanh thu
                double Tong = 0;
                foreach (DataRow row in dt.Rows)
                {
                    if (row["doanhThu"] != DBNull.Value)
                        Tong += Convert.ToDouble(row["doanhThu"]);

                }
                return Tong;
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public DataTable GetThongKeTheoThangNam (int thang, int nam)
        {
            try
            {
                string sql = "sp_ThongKeTheoThangNam";
                SqlParameter[] param = { new SqlParameter("@thang", thang == 0 ? (object)DBNull.Value : thang),
                                     new SqlParameter("@nam",nam)};
                DataTable dt = provider.MyExecuteReader(sql, CommandType.StoredProcedure, param);
                if (dt.Rows.Count == 0)
                    return null;

                return dt;
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

       
    }
}
