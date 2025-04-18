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
    public class SanBayDL
    {
        private DataProvider provider = new DataProvider();

        // Lấy danh sách sân bay
        public DataTable GetSanBayList()
        {
            string sql = "SELECT * FROM SanBay";
            return provider.MyExecuteReader(sql, CommandType.Text);
        }

        // Lấy tên sân bay theo ID
        public string GetSanBayName(int sanBayID)
        {
            string sql = "SELECT TenSanBay FROM SanBay WHERE ID = @ID";
            SqlParameter[] param = { new SqlParameter("@ID", sanBayID) };

            object result = provider.MyExecuteScalar(sql, CommandType.Text, param);
            return result?.ToString(); // Trả về tên sân bay hoặc null
        }

        //Kiểm tra sân bay có tồn tại
        public bool IsSanBayExist(string tenSanBay)
        {
            string sql = "SELECT COUNT(*) FROM SanBay WHERE tenSB = @TenSanBay";
            SqlParameter[] param = {
                new SqlParameter("@TenSanBay", tenSanBay)
            };

            object result = provider.MyExecuteScalar(sql, CommandType.Text, param);
            return Convert.ToInt32(result) > 0;
        }

        // Thêm sân bay mới
        public bool AddSanBay(string tenSanBay, string tinh, string quocGia)
        {
            string sql = "INSERT INTO SanBay (tenSB, tinhThanh, quocGia) VALUES (@TenSanBay, @Tinh, @QuocGia)";
            SqlParameter[] param = {
                new SqlParameter("@TenSanBay", tenSanBay),
                new SqlParameter("@Tinh", tinh),
                new SqlParameter("@QuocGia", quocGia)
            };

            return provider.MyExecuteNonQuery(sql, CommandType.Text, param) > 0;
        }

        public bool UpdateSanBay(int maSB, string tenSB, string tinhThanh, string quocGia)
        {
            string sql = "UPDATE SanBay SET tenSB = @tenSB, tinhThanh = @tinhThanh, quocGia = @quocGia WHERE maSB = @maSB";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@tenSB", tenSB),
            new SqlParameter("@tinhThanh", tinhThanh),
            new SqlParameter("@quocGia", quocGia),
            new SqlParameter("@maSB", maSB)
            };

            return provider.MyExecuteNonQuery(sql, CommandType.Text, parameters) > 0;
        }

        //Kiểm tra có tồn tại khóa ngoại hay không
        public bool CheckForeignKey(int maSB)
        {
            string sql = "SELECT " +
                "(SELECT COUNT(*) FROM TuyenBay WHERE sanBayDi = @maSB OR sanBayDen = @maSB) + " +
                "(SELECT COUNT(*) FROM SanBayTrungGian WHERE maSB = @maSB)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maSB", maSB)
            };

            object result = provider.MyExecuteScalar(sql, CommandType.Text, parameters);
            int count = Convert.ToInt32(result);
            return count > 0;
        }

        // Xóa sân bay
        public bool DeleteSanBay(int sanBayID)
        {
            string sql = "DELETE FROM SanBay WHERE maSB = @ID";
            SqlParameter[] param = { new SqlParameter("@ID", sanBayID) };

            return provider.MyExecuteNonQuery(sql, CommandType.Text, param) > 0;
        }

        public List<SanBayTO> GetSanBayTOs()
        {
            List<SanBayTO> sanBayList = new List<SanBayTO>();
            DataTable dt = GetSanBayList();
            foreach (DataRow row in dt.Rows)
            {
                SanBayTO sanBay = new SanBayTO
                {
                    maSB = Convert.ToInt32(row["maSB"]),
                    TenSanBay = row["tenSB"].ToString(),
                    TinhThanh = row["tinhThanh"].ToString(),
                    QuocGia = row["quocGia"].ToString()
                };
                sanBayList.Add(sanBay);
            }
            return sanBayList;
        }
    }
}

