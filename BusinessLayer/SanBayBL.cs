
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
    public class SanBayBL
    {
        private SanBayDL sanBayDL = new SanBayDL();

        // Lấy danh sách sân bay
        public DataTable GetSanBayList()
        {
            return sanBayDL.GetSanBayList();
        }

        // Lấy tên sân bay
        public string GetSanBayName(int id)
        {
            return sanBayDL.GetSanBayName(id);
        }

        // Thêm sân bay
        public bool AddSanBay(string tenSanBay, string tinh, string quocGia)
        {
            // Kiểm tra dữ liệu đầu vào, tránh trường hợp nhập chuỗi trống hoặc chỉ toàn khoảng trắng
            if (string.IsNullOrWhiteSpace(tenSanBay) || string.IsNullOrWhiteSpace(tinh) || string.IsNullOrWhiteSpace(quocGia))
            {
                return false; // Dữ liệu không hợp lệ, không thực hiện thêm vào database
            }

            if (!sanBayDL.IsSanBayExist(tenSanBay))
                // Gọi đến lớp dữ liệu (SanBayDL) để thêm sân bay
                return sanBayDL.AddSanBay(tenSanBay.Trim(), tinh.Trim(), quocGia.Trim()); // Xóa khoảng trắng dư thừa
            return false;
        }

        public bool UpdateSanBay(int maSB, string tenSB, string tinhThanh, string quocGia)
        {
            return sanBayDL.UpdateSanBay(maSB, tenSB, tinhThanh, quocGia);
        }


        // Xóa sân bay
        public bool DeleteSanBay(int id)
        {
            if (sanBayDL.CheckForeignKey(id))
            {
                return false;
            }
            return sanBayDL.DeleteSanBay(id);
        }

        public List<SanBayTO> GetSanBayTOs()
        {
            List<SanBayTO> sanBayList = new List<SanBayTO>();
            DataTable dt = GetSanBayList();
            foreach (DataRow row in dt.Rows)
            {
                SanBayTO sanBay = new SanBayTO
                {
                    maSB = Convert.ToInt32(row["maSB"]),
                    TenSanBay = row["tenSB"].ToString(),
                    TinhThanh = row["tinhThanh"].ToString(),
                    QuocGia = row["quocGia"].ToString()
                };
                sanBayList.Add(sanBay);
            }
            return sanBayList;
        }
    }
}
