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


        //Thêm quy định mới
        //Thêm quy định mới (ngày cập nhật lấy DateTime.Now)
        public bool AddQuyDinh(string tenQD, int noidungQD)
        {
            string sql = "INSERT INTO QUYDINH (tenQD, noidungQD, ngayCapNhat) VALUES (@tenQD, @noidungQD, @ngayCapNhat)";
            SqlParameter[] param =
            {
                new SqlParameter("@tenQD", tenQD),
                new SqlParameter("@noidungQD", noidungQD),
                new SqlParameter("@ngayCapNhat", DateTime.Now)
            };
            return provider.MyExecuteNonQuery(sql, CommandType.Text, param) > 0;
        }

        // Cập nhật quy định
        public bool UpdateQuyDinh(int maQD, string tenQD, int noiDungQD)
        {
            string sql = "UPDATE QUYDINH SET tenQD = @tenQD, noidungQD = @noiDungQD, ngayCapNhat = @ngayCapNhat WHERE maQD = @maQD";
            SqlParameter[] parameters =
            {
                new SqlParameter("@tenQD", tenQD),
                new SqlParameter("@noiDungQD", noiDungQD),
                new SqlParameter("@ngayCapNhat", DateTime.Now),
                new SqlParameter("@maQD", maQD)
            };

            return provider.MyExecuteNonQuery(sql, CommandType.Text, parameters) > 0;
        }


        //Xóa quy định
        public bool DeleteQuyDinh(int quyDinhID)
        {
            string sql = "DELETE FROM QuyDinh WHERE maQD = @ID";
            SqlParameter[] param = { new SqlParameter("@ID", quyDinhID) };

            return provider.MyExecuteNonQuery(sql, CommandType.Text, param) > 0;
        }
    }
}
