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
    public class QuyDinhDL
    {
        private DataProvider provider = new DataProvider();

        //Trả về bảng quy định
        public DataTable GetQuyDinhList()
        {
            string sql = "SELECT * FROM QUYDINH";
            return provider.MyExecuteReader(sql, CommandType.Text);
        }

        //Kiểm tra quy định có tồn tại
        public bool IsQuyDinhExist(string tenQuyDinh)
        {
            string sql = "SELECT COUNT(*) FROM QuyDinh WHERE tenQD = @TenQuyDinh";
            SqlParameter[] param = {
                new SqlParameter("@TenQuyDinh", tenQuyDinh)
            };

            object result = provider.MyExecuteScalar(sql, CommandType.Text, param);
            return Convert.ToInt32(result) > 0;
        }

        //Kiểm tra quy định có tồn tại (dành cho update)
        public bool IsQuyDinhExistForUpdate(int maQD, string tenQuyDinh)
        {
            string sql = "SELECT COUNT(*) FROM QuyDinh WHERE tenQD = @TenQuyDinh AND maQD != @MaQD";
            SqlParameter[] param = {
                new SqlParameter("@TenQuyDinh", tenQuyDinh),
                new SqlParameter("@MaQD", maQD)
            };

            object result = provider.MyExecuteScalar(sql, CommandType.Text, param);
            return Convert.ToInt32(result) > 0;
        }

        // Cập nhật quy định
        public bool UpdateQuyDinh(int maQD, string tenQD, int noiDungQD)
        {
            string sql = "sp_CapNhatQuyDinh";
            SqlParameter[] parameters =
            {
                new SqlParameter("@tenQD", tenQD),
                new SqlParameter("@noiDungQD", noiDungQD),
                new SqlParameter("@ngayCapNhat", DateTime.Now),
                new SqlParameter("@maQD", maQD)
            };

            return provider.MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters) > 0;
        }

        public int GetNoiDungQDByTen(string tenQD)
        {
            string sql = "SELECT noidungQD FROM QuyDinh WHERE tenQD = @tenQD";
            SqlParameter[] parameters = {
                new SqlParameter("@tenQD", tenQD)
            };

            object result = provider.MyExecuteScalar(sql, CommandType.Text, parameters);
            return result != null ? Convert.ToInt32(result) : 0;
        }

    }
}
