using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using DataLayer;
namespace BusinessLayer
{
    public class ChuyenBayBL
    {
        private ChuyenBayDL chuyenBayDL = new ChuyenBayDL();
        private TuyenBayDL tuyenBayDL = new TuyenBayDL();
        private TienTrinhDL tienTrinhDL = new TienTrinhDL();
        public List<ViewChuyenBayTO> GetChuyenBayList()
        {
            var chuyenBayList = chuyenBayDL.GetChuyenBayList();
            var tuyenBayList = tuyenBayDL.GetTuyenBayList();
            var tienTrinhList = tienTrinhDL.GetTienTrinhList();
            var result = from cb in chuyenBayList
                         join tb in tuyenBayList on cb.MaTB equals tb.MaTB
                         join tt in tienTrinhList on cb.TienTrinhID equals tt.Id
                         select new ViewChuyenBayTO
                         {
                             MaCB = cb.MaCB,
                             MaTB = cb.MaTB,
                             NgayGioDi = cb.NgayGioDi,
                             ThoiGianBay = cb.ThoiGianBay,
                             TienTrinhID = cb.TienTrinhID,
                             TenTB = tb.TenTB,
                             TenTienTrinh = tt.Ten
                         };
            return result.ToList();
        }
        public bool AddChuyenBay(int maTB, DateTime ngayGioDi, int thoiGianBay, byte tienTrinhID)
        {
            return chuyenBayDL.AddChuyenBay(maTB, ngayGioDi, thoiGianBay, tienTrinhID);
        }

        public bool DeleteChuyenBay(int maCB)
        {
            return chuyenBayDL.DeleteChuyenBay(maCB);
        }
        public bool UpdateChuyenBay(int maCB, int maTB, DateTime ngayGioDi, int thoiGianBay, byte tienTrinhID)
        {
            return chuyenBayDL.UpdateChuyenBay(maCB, maTB, ngayGioDi, thoiGianBay, tienTrinhID);
        }

        public List<ViewChuyenBayTO> GetViewChuyenBayByMaTB(int maTB)
        {
            var chuyenBayList = this.GetChuyenBayList();
            var result = chuyenBayList.Where(cb => cb.MaTB == maTB)
                                       .Select(cb => new ViewChuyenBayTO
                                       {
                                           MaCB = cb.MaCB,
                                           MaTB = cb.MaTB,
                                           NgayGioDi = cb.NgayGioDi,
                                           ThoiGianBay = cb.ThoiGianBay,
                                           TienTrinhID = cb.TienTrinhID,
                                           TenTB = cb.TenTB,
                                           TenTienTrinh = cb.TenTienTrinh
                                       });

            return result.ToList();
        }

        public int GetSoLuongChuyenBay(int thang, int nam)
        {
            return chuyenBayDL.GetSoLuongChuyenBay(thang, nam);
        }
        public bool CheckChuyenBayExists(int maTB, DateTime ngayGioDi)
        {
            return chuyenBayDL.CheckChuyenBayExists(maTB, ngayGioDi);
        }
    }
}