using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using System.Data;
using System.Data.SqlClient;
namespace DataLayer
{
    public class ChuyenBayDL
    {
        private DataProvider dataProvider = new DataProvider();
        public List<ChuyenBayTO> GetChuyenBayList()
        {
            string sql = "SELECT * FROM ChuyenBay";
            DataTable dt = dataProvider.MyExecuteReader(sql, CommandType.Text);
            List<ChuyenBayTO> list = new List<ChuyenBayTO>();
            foreach (DataRow row in dt.Rows)
            {
                ChuyenBayTO cb = new ChuyenBayTO
                {
                    MaCB = Convert.ToInt32(row["maCB"]),
                    MaTB = Convert.ToInt32(row["maTB"]),
                    NgayGioDi = Convert.ToDateTime(row["ngayGioDi"]),
                    ThoiGianBay = Convert.ToInt32(row["thoiGianBay"]),
                    TienTrinhID = Convert.ToByte(row["tienTrinhID"])
                    

                };
                list.Add(cb);
            }
            return list;
        }

        public bool AddChuyenBay(int maTB, DateTime ngayGioDi, int thoiGianBay, byte tienTrinhID)
        {
            string sql = "INSERT INTO ChuyenBay (maTB, ngayGioDi, thoiGianBay, tienTrinhID) VALUES (@maTB, @ngayGioDi, @thoiGianBay, @tienTrinhID)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maTB", maTB),
                new SqlParameter("@ngayGioDi", ngayGioDi),
                new SqlParameter("@thoiGianBay", thoiGianBay),
                new SqlParameter("@tienTrinhID", tienTrinhID)
            };
            return dataProvider.MyExecuteNonQuery(sql, CommandType.Text, parameters) > 0;
        }

        public bool DeleteChuyenBay(int maCB)
        {
            string sql = "DELETE FROM ChuyenBay WHERE maCB = @maCB";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maCB", maCB)
            };
            return dataProvider.MyExecuteNonQuery(sql, CommandType.Text, parameters) > 0;
        }

        public bool UpdateChuyenBay(int maCB, int maTB, DateTime ngayGioDi, int thoiGianBay, byte tienTrinhID)
        {
            string sql = "UPDATE ChuyenBay SET maTB = @maTB, ngayGioDi = @ngayGioDi, thoiGianBay = @thoiGianBay, tienTrinhID = @tienTrinhID WHERE maCB = @maCB";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maCB", maCB),
                new SqlParameter("@maTB", maTB),
                new SqlParameter("@ngayGioDi", ngayGioDi),
                new SqlParameter("@thoiGianBay", thoiGianBay),
                new SqlParameter("@tienTrinhID", tienTrinhID)
            };
            return dataProvider.MyExecuteNonQuery(sql, CommandType.Text, parameters) > 0;
        }

        public int GetSoLuongChuyenBay(int thang, int nam)
        {
            string sql_Nam = "SELECT * FROM ChuyenBay WHERE YEAR(ngayGioDi) = " + @nam;
            string sql_ThangNam = "SELECT * FROM ChuyenBay WHERE MONTH(ngayGioDi) = " + @thang+ " AND YEAR(ngayGioDi) = " + @nam;
            
            if (thang == 0 )
            {
                DataTable dt_Nam = dataProvider.MyExecuteReader(sql_Nam, CommandType.Text);
                List<ChuyenBayTO> list_Nam = new List<ChuyenBayTO>();
                foreach (DataRow row in dt_Nam.Rows)
                {
                    ChuyenBayTO cb = new ChuyenBayTO
                    {
                        MaCB = Convert.ToInt32(row["maCB"]),
                        MaTB = Convert.ToInt32(row["maTB"]),
                        NgayGioDi = Convert.ToDateTime(row["ngayGioDi"]),
                        ThoiGianBay = Convert.ToInt32(row["thoiGianBay"]),
                        TienTrinhID = Convert.ToByte(row["tienTrinhID"])
                    };
                    list_Nam.Add(cb);
                }  
                return list_Nam.Count;
            }   
            DataTable dt_ThangNam = dataProvider.MyExecuteReader(sql_ThangNam, CommandType.Text);
            List<ChuyenBayTO> list_ThangNam = new List<ChuyenBayTO>();
            foreach (DataRow row in dt_ThangNam.Rows)
            {
                 ChuyenBayTO cb = new ChuyenBayTO
                    {
                        MaCB = Convert.ToInt32(row["maCB"]),
                        MaTB = Convert.ToInt32(row["maTB"]),
                        NgayGioDi = Convert.ToDateTime(row["ngayGioDi"]),
                        ThoiGianBay = Convert.ToInt32(row["thoiGianBay"]),
                        TienTrinhID = Convert.ToByte(row["tienTrinhID"])
                    };
                list_ThangNam.Add(cb);
            }  
            return list_ThangNam.Count;
            
        }

        public bool CheckChuyenBayExists(int maTB, DateTime ngayGioDi)
        {
            string sql = "SELECT COUNT(*) FROM ChuyenBay WHERE maTB = @maTB AND ngayGioDi = @ngayGioDi";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maTB", maTB),
                new SqlParameter("@ngayGioDi", ngayGioDi)
            };
            int count = Convert.ToInt32(dataProvider.MyExecuteScalar(sql, CommandType.Text, parameters));
            return count > 0;
        }
    }
}
