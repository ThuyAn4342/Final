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
    public class TuyenBayBL
    {
        private TuyenBayDL tuyenBayDL = new TuyenBayDL();
        private SanBayDL sanBayDL = new SanBayDL();

        public List<ViewTuyenBayTO> GetTuyenBayList()
        {
            var sanBayList = sanBayDL.GetSanBayTOs();
            var tuyenBayList = tuyenBayDL.GetTuyenBayList();

            var result = from tb in tuyenBayList
                         join sbDi in sanBayList on tb.SanBayDi equals sbDi.maSB
                         join sbDen in sanBayList on tb.SanBayDen equals sbDen.maSB
                         select new ViewTuyenBayTO
                         {
                             MaTB = tb.MaTB,
                             TenTB = tb.TenTB,
                             MaSanBayDi = tb.SanBayDi,
                             MaSanBayDen = tb.SanBayDen,
                             TenSanBayDi = sbDi.TenSanBay,
                             TenSanBayDen = sbDen.TenSanBay,
                             GiaTB = tb.GiaTB
                         };

            return result.ToList();
        }

        public bool AddTuyenBay(string tenTB, int sanBayDi, int sanBayDen, float giaTB)
        {
            return tuyenBayDL.AddTuyenBay(tenTB, sanBayDi, sanBayDen, giaTB);
        }

        public bool DeleteTuyenBay(int maTB)
        {
            return tuyenBayDL.DeleteTuyenBay(maTB);
        }

        public bool UpdateTuyenBay(int maTB, string tenTB, int sanBayDi, int sanBayDen, float giaTB)
        {
            return tuyenBayDL.UpdateTuyenBay(maTB, tenTB, sanBayDi, sanBayDen, giaTB);
        }

        public List<ViewTuyenBayTO> GetTuyenBayByTinh(int maSanBayDi, int maSanBayDen)
        {

            var sanBayList = sanBayDL.GetSanBayTOs();
            var tuyenBayList = tuyenBayDL.GetTuyenBayList();

            var result = from tb in tuyenBayList
                         join sbDi in sanBayList on tb.SanBayDi equals sbDi.maSB
                         join sbDen in sanBayList on tb.SanBayDen equals sbDen.maSB
                         where (maSanBayDi == 0 || sbDi.maSB == maSanBayDi) &&
                                 (maSanBayDen == 0 || sbDen.maSB == maSanBayDen)
                         select new ViewTuyenBayTO
                         {
                             MaTB = tb.MaTB,
                             TenTB = tb.TenTB,
                             MaSanBayDi = tb.SanBayDi,
                             MaSanBayDen = tb.SanBayDen,
                             TenSanBayDi = sbDi.TenSanBay,
                             TenSanBayDen = sbDen.TenSanBay,
                             GiaTB = tb.GiaTB
                         };

            return result.ToList();
        }

        public bool CheckTuyenBayExists(string tenTB)
        {
            if (tuyenBayDL.CheckTuyenBayExists(tenTB))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
