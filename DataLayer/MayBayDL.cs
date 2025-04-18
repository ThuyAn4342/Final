using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class MayBayDL
    {
        private DataProvider provider = new DataProvider();
        //Lấy danh sách máy bay
        public DataTable GetMayBayList()
        {
            string sql = "SELECT m.*, l.tenLoaiMB FROM MayBay m, LoaiMayBay l WHERE m.maLoaiMB = l.maLoaiMB";
            return provider.MyExecuteReader(sql, CommandType.Text);
        }

        public DataTable GetTenLoaiMayBay()
        {
            string sql = "SELECT maLoaiMB, tenLoaiMB FROM LoaiMayBay";
            return provider.MyExecuteReader(sql, CommandType.Text);
        }

        //Kiểm tra máy bay có tồn tại
        public bool IsMayBayExist(string tenMayBay)
        {
            string sql = "SELECT COUNT(*) FROM MayBay WHERE tenMB = @TenMayBay";
            SqlParameter[] param = {
                new SqlParameter("@TenMayBay", tenMayBay)
            };

            object result = provider.MyExecuteScalar(sql, CommandType.Text, param);
            return Convert.ToInt32(result) > 0;
        }

        // Kiểm tra xem tên máy bay đã tồn tại ở máy bay khác (dùng cho cập nhật)
        public bool IsMayBayExistForUpdate(int maMB, string tenMayBay)
        {
            string sql = "SELECT COUNT(*) FROM MayBay WHERE tenMB = @TenMayBay AND maMB != @maMB";
            SqlParameter[] param = {
        new SqlParameter("@TenMayBay", tenMayBay),
        new SqlParameter("@maMB", maMB)
    };

            object result = provider.MyExecuteScalar(sql, CommandType.Text, param);
            return Convert.ToInt32(result) > 0;
        }


        // Thêm máy bay mới
        public bool AddMayBay(string tenMB, int slGheH1, int slGhePT, int maLoaiMB)
        {
            string sql = "INSERT INTO MayBay (tenMB, slGheH1, slGhePT, maLoaiMB) VALUES (@TenMB, @slGheH1, @slGhePT, @maLoaiMB)";
            SqlParameter[] param = {
                new SqlParameter("@TenMB", tenMB),
                new SqlParameter("@slGheH1", slGheH1),
                new SqlParameter("@slGhePT", slGhePT),
                new SqlParameter("@maLoaiMB", maLoaiMB)
            };

            return provider.MyExecuteNonQuery(sql, CommandType.Text, param) > 0;
        }

        public bool IsLoaiMayBayExist(int maLoaiMB)
        {
            string sql = "SELECT COUNT(*) FROM LoaiMayBay WHERE maLoaiMB = @maLoaiMB";
            SqlParameter[] param = {
            new SqlParameter("@maLoaiMB", maLoaiMB)
        };

            object result = provider.MyExecuteScalar(sql, CommandType.Text, param);
            return Convert.ToInt32(result) > 0;
        }


        //Cập nhật máy bay
        public bool UpdateMayBay(int maMB, string tenMB, int slGheH1, int slGhePT, int maLoaiMB)
        {
            string sql = "UPDATE MayBay SET tenMB = @tenMB, slGheH1 = @slGheH1, slGhePT = @slGhePT, maLoaiMB = @maLoaiMB WHERE maMB = @maMB";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@tenMB", tenMB),
                new SqlParameter("@slGheH1", slGheH1),
                new SqlParameter("@slGhePT", slGhePT),
                new SqlParameter("@maLoaiMB", maLoaiMB),
                new SqlParameter("@maMB", maMB)
            };

            return provider.MyExecuteNonQuery(sql, CommandType.Text, parameters) > 0;
        }



        // Xóa máy bay
        public bool DeleteMayBay(int maMB)
        {
            string sql = "DELETE FROM MayBay WHERE maMB = @ID";
            SqlParameter[] param = { new SqlParameter("@ID", maMB) };

            return provider.MyExecuteNonQuery(sql, CommandType.Text, param) > 0;
        }
    }
}
