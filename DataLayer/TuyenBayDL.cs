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
    public class TuyenBayDL
    {
        private DataProvider dataProvider = new DataProvider();

        public List<TuyenBayTO> GetTuyenBayList()
        {
            string sql = "SELECT * FROM TuyenBay";

            // lấy data table từ MyExecuteReader: viết bằng connected mode
            DataTable dt = dataProvider.MyExecuteReader(sql, CommandType.Text);
            List<TuyenBayTO> list = new List<TuyenBayTO>();

            foreach (DataRow row in dt.Rows)
            {
                TuyenBayTO tb = new TuyenBayTO
                {
                    MaTB = Convert.ToInt32(row["maTB"]),
                    TenTB = row["tenTB"].ToString(),
                    SanBayDi = Convert.ToInt32(row["sanBayDi"]),
                    SanBayDen = Convert.ToInt32(row["sanBayDen"]),
                    GiaTB =Convert.ToSingle(row["giaTB"]),
                };
                list.Add(tb);
            }
            return list;
            
        }

        public bool AddTuyenBay(string tenTB, int sanBayDi, int sanBayDen, float giaTB)
        {
            string sql = "INSERT INTO TuyenBay ( tenTB, sanBayDi, sanBayDen, giaTB) VALUES (@tenTB, @sanBayDi, @sanBayDen, @giaTB)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@tenTB", tenTB),
                new SqlParameter("@sanBayDi", sanBayDi),
                new SqlParameter("@sanBayDen", sanBayDen),
                new SqlParameter("@giaTB", giaTB)
            };
            return dataProvider.MyExecuteNonQuery(sql, CommandType.Text, parameters) > 0;
        }

        public bool DeleteTuyenBay(int maTB)
        {
            string sql = "DELETE FROM TuyenBay WHERE maTB = @maTB";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maTB", maTB)
            };
            return dataProvider.MyExecuteNonQuery(sql, CommandType.Text, parameters) > 0;
        }

        public bool UpdateTuyenBay(int maTB, string tenTB, int sanBayDi, int sanBayDen, float giaTB)
        {
            string sql = "UPDATE TuyenBay SET tenTB = @tenTB, sanBayDi = @sanBayDi, sanBayDen = @sanBayDen, giaTB = @giaTB WHERE maTB = @maTB";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maTB", maTB),
                new SqlParameter("@tenTB", tenTB),
                new SqlParameter("@sanBayDi", sanBayDi),
                new SqlParameter("@sanBayDen", sanBayDen),
                new SqlParameter("@giaTB", giaTB)
            };
            return dataProvider.MyExecuteNonQuery(sql, CommandType.Text, parameters) > 0;
        }
        public bool CheckTuyenBayExists(string tenTB)
        {
            string sql = "SELECT COUNT(*) FROM TuyenBay WHERE tenTB = @tenTB";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@tenTB", tenTB)
            };
            int count = (int)dataProvider.MyExecuteScalar(sql, CommandType.Text, parameters);
            return count > 0;
        }
    }
}
