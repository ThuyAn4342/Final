using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
namespace DataLayer
{
    public class TienTrinhDL
    {
        private DataProvider provider = new DataProvider();

        public List<TienTrinhTO> GetTienTrinhList()
        {
            string sql = "SELECT * FROM TienTrinh";
            DataTable dt = provider.MyExecuteReader(sql, CommandType.Text);
            List<TienTrinhTO> list = new List<TienTrinhTO>();
            foreach (DataRow dr in dt.Rows) {
                TienTrinhTO tt = new TienTrinhTO();
                tt.Id = Convert.ToByte(dr["id"]);
                tt.Ten = dr["ten"].ToString();
                list.Add(tt);
            }
            return list;
        }

    }
}
