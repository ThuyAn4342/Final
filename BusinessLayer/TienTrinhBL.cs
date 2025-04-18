using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using DataLayer;
namespace BusinessLayer
{
    public class TienTrinhBL
    {
        private TienTrinhDL tienTrinhDL = new TienTrinhDL();
        public List<TienTrinhTO> GetTienTrinhList()
        {
            return tienTrinhDL.GetTienTrinhList();
        }
    }
}
