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
    public class HoaDonDL
    {
        DataProvider provider = new DataProvider();

        public HoaDonTO GetThongTinHoaDon(int maHD)
        {
            SqlParameter[] param = { new SqlParameter("@maHD", maHD) };
            DataTable dt = provider.MyExecuteReader("sp_LayThongTinHoaDon", CommandType.StoredProcedure, param);

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];
            return new HoaDonTO
            {
                maHD = Convert.ToInt32(row["maHD"]),
                ngayLapHD = Convert.ToDateTime(row["ngayLapHD"]),
                phuongThucTT = row["phuongThucTT"].ToString(),
                tongTien = Convert.ToDouble(row["tongTien"]),
                nguoiLapHD = row["nguoiLapHD"].ToString(),
                soLuongVe = Convert.ToInt32(row["soLuongVe"])
            };
        }

        public DataTable GetDSVeCuaHoaDon(int maHD)
        {
            DataProvider provider = new DataProvider();
            SqlParameter[] param = { new SqlParameter("@maHD", maHD) };
            string sql = "sp_LayDSVeCuaHD";
            DataTable dt = provider.MyExecuteReader(sql, CommandType.StoredProcedure, param);
            if (dt.Rows.Count == 0)
                return null;
            else return dt;
        }

        //Cập nhật thông tin
        public bool UpdateHoaDon(int maHD, int soLuongVe,double tongTien)
        {
            string sql = "UPDATE HoaDon SET soLuongVe =@soLuongVe, tongTien=@tongTien WHERE maHD =@maHD";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maHD", maHD),
                new SqlParameter("@soLuongVe", soLuongVe),
                new SqlParameter("@tongTien",tongTien)
            };
            return provider.MyExecuteNonQuery(sql, CommandType.Text, parameters) > 0;
        }

        //Xóa hóa đơn
        public bool DeleteHoaDon(int maHD)
        {
            string sql = "DELETE FROM HoaDon WHERE maHD = @maHD";
            SqlParameter[] param = { new SqlParameter("@maHD", maHD) };
            return provider.MyExecuteNonQuery(sql, CommandType.Text, param) > 0;
        }
    }

}

