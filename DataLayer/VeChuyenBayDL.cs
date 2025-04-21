using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace DataLayer
{
    public class VeChuyenBayDL
    {
        private DataProvider provider = new DataProvider();

        public List<VeChuyenBayTO> GetVeChuyenBayList()
        {
            string sql = "sp_LayDSVeChuyenBay";
            DataTable dt = provider.MyExecuteReader(sql, CommandType.StoredProcedure);
            List<VeChuyenBayTO> list = new List<VeChuyenBayTO>();
            foreach (DataRow row in dt.Rows)
            {
                VeChuyenBayTO ve = new VeChuyenBayTO
                {
                    maVe = Convert.ToInt32(row["maVe"]),
                    tenHK = row["tenHK"].ToString(),
                    maHD = Convert.ToInt32(row["maHD"]),
                    maCB = Convert.ToInt32(row["maCB"]),
                    maGhe = Convert.ToInt32(row["maGhe"]),
                    gia = Convert.ToDouble(row["giaVe"]),
                    
                };
                list.Add(ve);
            }
            return list;
        }

        public string sanBayDiCuaVe(int maCB)
        {
            string sql_sb = "sp_LaySanBayDi";
            SqlParameter[] param_sb = { new SqlParameter("@maCB", maCB) };
            var sb = provider.MyExecuteScalar(sql_sb, CommandType.StoredProcedure, param_sb);
            return sb.ToString();
        }
        public string sanBayDenCuaVe(int maCB)
        {
            string sql_sb = "sp_LaySanBayDen";
            SqlParameter[] param_sb = { new SqlParameter("@maCB", maCB) };
            var sb = provider.MyExecuteScalar(sql_sb, CommandType.StoredProcedure, param_sb);
            return sb.ToString();
        }
        public VeChuyenBayTO GetThongTinVeChuyenBayDL(int maVe)
        {
            string sql = "sp_TraCuuThongTinVe";
            SqlParameter[] param = {
                new SqlParameter("@maVe", maVe)
            };
            DataTable dt = provider.MyExecuteReader(sql, CommandType.StoredProcedure, param);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                string sb_di = sanBayDiCuaVe(Convert.ToInt32(row["maCB"]));
                string sb_den = sanBayDenCuaVe(Convert.ToInt32(row["maCB"]));
                return new VeChuyenBayTO
                {
                    maVe = Convert.ToInt32(row["maVe"]),
                    tenHK = row["tenHK"].ToString(),
                    maHD = Convert.ToInt32(row["maHD"]),
                    ngayLapHD = Convert.ToDateTime(row["ngayLapHD"]),
                    maCB = Convert.ToInt32(row["maCB"]),
                    ngayGioDi = Convert.ToDateTime(row["ngayGioDi"]),
                    tuyenBay = row["tuyenBay"].ToString(),
                    tenGhe = row["tenGhe"].ToString(),
                    hangGhe = row["hangGhe"].ToString(),
                    gia = Convert.ToDouble(row["giaVe"]),
                    trangThai = row["trangThai"].ToString(),
                    sanBayDi = sb_di,
                    sanBayDen = sb_den
                    

                };
            }

            return null;
        }
        public int GetTongSoVe (int thang,int nam)
        {
            string sql = "sp_LaySoLuongVeTheoNamThang";
            SqlParameter[] param =
            {
                new SqlParameter("@thang",thang == 0 ? (object)DBNull.Value : thang),
                new SqlParameter("@nam", nam)
            };
            var sl = provider.MyExecuteScalar(sql, CommandType.StoredProcedure, param);
            return Convert.ToInt32(sl);
        }

        //Xóa vé
        public bool DeleteVeCB(int maVe)
        {
            string sql = "sp_XoaVeTheoMaVe";
            SqlParameter[] param = { new SqlParameter("@maVe", maVe) };
            return provider.MyExecuteNonQuery(sql, CommandType.StoredProcedure, param) > 0;
        }

        //Xóa vé theo mã chuyến bay
        public bool DeleteVeByMaCB(int maCB)
        {
            try
            {
                string sql = "sp_XoaVeCuaChuyenBay";
                SqlParameter[] param = { new SqlParameter("@maCB", maCB) };
                return provider.MyExecuteNonQuery(sql, CommandType.StoredProcedure, param) > 0;
            }
            catch (SqlException ex)
            {

                throw ex;
            }

        }

    }
}
