using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class VeChuyenBayTO
    {
        public int maVe { get; set; }
        public string tenHK { get; set; }
        public int maHD { get; set; }
        public DateTime ngayLapHD { get; set; }
        public int maCB { get; set; }
        public DateTime ngayGioDi { get; set; }
        public string tuyenBay { get; set; }
        public int maGhe { get; set; }
        public string tenGhe { get; set; }
        public string hangGhe { get; set; }
        public double gia { get; set; }
        public string trangThai { get; set; }
        public string sanBayDi { get; set; }
        public string sanBayDen { get; set; }
    }
}
