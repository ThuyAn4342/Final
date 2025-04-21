using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLayer
{
    public class MayBayBL
    {
        private MayBayDL maybayDL = new MayBayDL();

        // Lấy danh sách máy bay
        public DataTable GetMayBayList()
        {
            return maybayDL.GetMayBayList();
        }

        public DataTable GetTenLoaiMayBay()
        {
            return maybayDL.GetTenLoaiMayBay();
        }

        // Thêm máy bay
        public bool AddMayBay(string tenMB, int slGheH1, int slGhePT, int maLoaiMB)
        {
            // Kiểm tra dữ liệu đầu vào, tránh trường hợp nhập chuỗi trống hoặc chỉ toàn khoảng trắng
            if (string.IsNullOrWhiteSpace(tenMB))
            {
                return false; // Dữ liệu không hợp lệ, không thực hiện thêm vào database
            }

            if (!maybayDL.IsMayBayExist(tenMB))
                // Gọi đến lớp dữ liệu (MayBayDL) để thêm máy bay
                return maybayDL.AddMayBay(tenMB.Trim(), slGheH1, slGhePT, maLoaiMB); // Xóa khoảng trắng dư thừa
            else
                return false;
        }


        //Update máy bay
        public bool UpdateMayBay(int id, string tenMB, int slGheH1, int slGhePT, int maLoaiMB)
        {
            if (maybayDL.IsMayBayExistForUpdate(id, tenMB))
                return false; //Không thể cập nhật trùng tên cho máy bay

            if (!maybayDL.IsLoaiMayBayExist(maLoaiMB))
                return false; // Không tồn tại loại máy bay -> không cập nhật được

            return maybayDL.UpdateMayBay(id, tenMB, slGheH1, slGhePT, maLoaiMB);
        }


        // Xóa máy bay
        public bool DeleteMayBay(int id)
        {
            if (maybayDL.CheckForeignKey(id) == true)
                throw new Exception("Đã liên kết với ghế, không thể xóa!!!");
            return maybayDL.DeleteMayBay(id);
        }
    }
}
