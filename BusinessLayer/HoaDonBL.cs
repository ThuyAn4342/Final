using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using TransferObject;

namespace BusinessLayer
{
    public class HoaDonBL
    {
        private HoaDonDL hoadonDL = new HoaDonDL();

        //Lấy hóa đơn từ mã hóa đơn
        public HoaDonTO GetThongTinHoaDon(int maHD)
        {
            return hoadonDL.GetThongTinHoaDon(maHD);
        }

        //Lấy các vé của hóa đơn
        public DataTable GetDSVeCuaHoaDon(int maHD)
        {
            return hoadonDL.GetDSVeCuaHoaDon(maHD);
        }

        public bool UpdateHoaDon(int maHD, int soLuongVe, double tongTien)
        {
            return hoadonDL.UpdateHoaDon(maHD, soLuongVe, tongTien);
        }
        //Xóa hóa đơn
        public bool DeleteHoaDon(int maHD)
        {
            return hoadonDL.DeleteHoaDon(maHD) ;
        }
    }
}
