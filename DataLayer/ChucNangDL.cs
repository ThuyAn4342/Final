using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace DataLayer
{
    public class ChucNangDL
    {
        private DataProvider provider = new DataProvider();

        public List<ChucNangTO> GetChucNangList()
        {
            string sql = "SELECT * FROM ChucNang";
            DataTable dt = provider.MyExecuteReader(sql, CommandType.Text);
            List<ChucNangTO> list = new List<ChucNangTO>();
            foreach (DataRow dr in dt.Rows)
            {
                ChucNangTO c = new ChucNangTO();
                c.Id = Convert.ToByte(dr["id"]);
                c.Ten = dr["ten"].ToString();
                list.Add(c);
            }
            return list;
        }
    }
}
