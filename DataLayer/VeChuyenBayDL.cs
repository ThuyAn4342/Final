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

        public string sanBayDiCuaVe(int maCB)
        {
            string sql_sb = "SELECT sb.tenSB AS sanBayDi  FROM ChuyenBay cb, TuyenBay tb, SanBay sb  WHERE cb.maTB=tb.maTB AND tb.sanBayDi =sb.maSB AND cb.maCB = @maCB";
            SqlParameter[] param_sb = { new SqlParameter("@maCB", maCB) };
            var sb = provider.MyExecuteScalar(sql_sb, CommandType.Text, param_sb);
            return sb.ToString();
        }
        public string sanBayDenCuaVe(int maCB)
        {
            string sql_sb = "SELECT sb.tenSB AS sanBayDi  FROM ChuyenBay cb, TuyenBay tb, SanBay sb  WHERE cb.maTB=tb.maTB AND tb.sanBayDen =sb.maSB AND cb.maCB = @maCB";
            SqlParameter[] param_sb = { new SqlParameter("@maCB", maCB) };
            var sb = provider.MyExecuteScalar(sql_sb, CommandType.Text, param_sb);
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
            string sql = "DELETE FROM VeChuyenBay WHERE maVe = @maVe";
            SqlParameter[] param = { new SqlParameter("@maVe", maVe) };
            return provider.MyExecuteNonQuery(sql, CommandType.Text, param) > 0;
        }

        //Xóa vé theo mã chuyến bay
        public bool DeleteVeByMaCB(int maCB)
        {
            try
            {
                string sql = "DELETE FROM VeChuyenBay WHERE maVe IN (SELECT v.maVe  FROM VeChuyenBay v, Ghe_ChuyenBay gcb " +
                " WHERE v.maGhe = gcb.maGhe AND v.maCB = gcb.maCB AND gcb.maCB =@maCB)";
                SqlParameter[] param = { new SqlParameter("@maCB", maCB) };
                return provider.MyExecuteNonQuery(sql, CommandType.Text, param) > 0;
            }
            catch (SqlException ex)
            {

                throw ex;
            }

        }

    }
}
