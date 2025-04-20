using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using DataLayer;
using DocumentFormat.OpenXml.Wordprocessing;
namespace BusinessLayer
{
    public class SanBayTrungGianBL
    {
        private SanBayTrungGianDL sbtgDL = new SanBayTrungGianDL();
        private QuyDinhDL quyDinhDL = new QuyDinhDL();

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
            // B1: Kiểm tra trùng
            if (sbtgDL.CheckExistSanBayTrungGian(maSB, maTB))
                throw new Exception("Sân bay trung gian này đã tồn tại trong tuyến bay.");

            // B2: Lấy danh sách sân bay trung gian hiện tại của tuyến bay này
            var existingList = sbtgDL.GetSanBayTrungGianList().Where(x => x.MaTB == maTB).ToList();

            // B3: Lấy quy định
            int maxSBTG = quyDinhDL.GetNoiDungQDByTen("Số sân bay trung gian tối đa");
            int minStop = quyDinhDL.GetNoiDungQDByTen("Thời gian dừng tối thiểu");
            int maxStop = quyDinhDL.GetNoiDungQDByTen("Thời gian dừng tối đa");

            // B4: Kiểm tra số lượng sân bay trung gian
            if (existingList.Count >= maxSBTG)
                throw new Exception($"Không thể thêm sân bay trung gian: đã đạt số lượng tối đa ({maxSBTG}).");

            // B5: Kiểm tra thời gian dừng
            if (thoiGianDung < minStop || thoiGianDung > maxStop)
                throw new Exception($"Thời gian dừng phải nằm trong khoảng từ {minStop} đến {maxStop} phút.");

            // B6: Gọi DataLayer thêm mới
            return sbtgDL.AddSanBayTrungGian(maSB, maTB, thoiGianDung);
        }


        public bool DeleteSanBayTrungGian(int maSB, int maTB)
        {
            return sbtgDL.DeleteSanBayTrungGian(maSB, maTB);
        }

    }
}
