using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using TransferObject;

namespace BusinessLayer
{
    public class ChucNangBL
    {
        private ChucNangDL chucnangDL = new ChucNangDL();

        public List<ChucNangTO> GetChucNangList()
        {
            return chucnangDL.GetChucNangList();
        }
    }
}
