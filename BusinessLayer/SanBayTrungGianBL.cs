using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using DataLayer;
namespace BusinessLayer
{
    public class SanBayTrungGianBL
    {
        private SanBayTrungGianDL sbtgDL = new SanBayTrungGianDL();

        private TuyenBayDL tuyenBayDL = new TuyenBayDL();
        private SanBayDL sanBayDL = new SanBayDL();
        public List<View_SanBayTrungGiaTO> GetSanBayTrungGianList()
        {
            var sanBayTrungGianList = sbtgDL.GetSanBayTrungGianList();
            var tuyenBayList = tuyenBayDL.GetTuyenBayList();
            var sanBayList = sanBayDL.GetSanBayTOs();


            var result = from sbtg in sanBayTrungGianList
                         join tb in tuyenBayList on sbtg.MaTB equals tb.MaTB
                         join sb in sanBayList on sbtg.MaSB equals sb.maSB
                         select new View_SanBayTrungGiaTO
                         {
                             MaSB = sbtg.MaSB,
                             MaTB = sbtg.MaTB,
                             TenTB = tb.TenTB,
                             TenSB = sb.TenSanBay,
                             ThoiGianDung = sbtg.ThoiGianDung,
                         };

            return result.ToList();
        }

        public bool AddSanBayTrungGian(int maSB, int maTB, int thoiGianDung)
        {
            // Kiểm tra xem mã sân bay và mã tuyến bay có tồn tại không

            if (sbtgDL.CheckExistSanBayTrungGian(maSB, maTB))
            {
                return false;
            }

            return sbtgDL.AddSanBayTrungGian(maSB, maTB, thoiGianDung);
        }

        public bool DeleteSanBayTrungGian(int maSB, int maTB)
        {
            return sbtgDL.DeleteSanBayTrungGian(maSB, maTB);
        }

    }
}
