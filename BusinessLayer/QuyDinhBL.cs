using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using DataLayer;
using System.Data;

namespace BusinessLayer
{
    public class QuyDinhBL
    {
        private QuyDinhDL quyDinhDL = new QuyDinhDL();

        public DataTable GetQuyDinhList()
        {
            return quyDinhDL.GetQuyDinhList();
        }

        // Thêm quy định mới
        public bool AddQuyDinh(string tenQD, int noiDungQD)
        {
            if (!quyDinhDL.IsQuyDinhExist(tenQD))
            {
                DateTime ngayCapNhat = DateTime.Now;
                return quyDinhDL.AddQuyDinh(tenQD, noiDungQD);
            }
            return false;
        }

        // Xóa quy định theo mã
        public bool XoaQuyDinh(int maQD)
        {
            return quyDinhDL.DeleteQuyDinh(maQD);
        }

        // Gọi hàm cập nhật từ DL
        public bool UpdateQuyDinh(int maQD, string tenQD, int noiDungQD)
        {
            if (quyDinhDL.IsQuyDinhExistForUpdate(maQD, tenQD))
                return false;
            return quyDinhDL.UpdateQuyDinh(maQD, tenQD, noiDungQD);
        }
    }
}
