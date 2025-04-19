using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Data;
using System.Data.SqlClient;
using TransferObject;

namespace BusinessLayer
{
    public class NguoiDungBL
    {
        private NguoiDungDL nguoidungDL = new NguoiDungDL();

        public TaiKhoanNDTO Login(string tenDangNhap, string matKhau)
        {
            try
            {
                return nguoidungDL.Login(tenDangNhap, matKhau);
            }
            catch (SqlException ex) 
            {

                throw ex;
            }
        }

        public string GetEmailByUsername(string username)
        {
            return nguoidungDL.GetEmailByUsername(username);
        }


        //Lấy danh sách người dùng
        public DataTable GetNguoiDungList(int ChucNangId)
        {
            try
            {
                return nguoidungDL.GetNguoiDungList(ChucNangId);

            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        //Lấy người dùng qua id
        public TaiKhoanNDTO GetNguoiDungByID(int id)
        {
            try
            {
                return nguoidungDL.GetNguoiDungByID(id);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        //Kiểm tra tên đăng nhập đã tồn tại chưa
        public bool KiemTraTenDangNhapTonTai(string tenDangNhap)
        {
            try
            {
                return nguoidungDL.KiemTraTenDangNhapTonTai(tenDangNhap);

            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        //Thêm người dùng
        public bool AddNguoiDung(string hoTenND, string tenDangNhap, int ChucNangId,
            string soDT, string matKhau, string linkAnh, string mail)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào, tránh trường hợp nhập chuỗi trống hoặc chỉ toàn khoảng trắng
                if (string.IsNullOrWhiteSpace(tenDangNhap) || string.IsNullOrWhiteSpace(ChucNangId.ToString())
                    || string.IsNullOrWhiteSpace(matKhau))
                {
                    return false; // Dữ liệu không hợp lệ, không thực hiện thêm vào database
                }
                if (nguoidungDL.KiemTraTenDangNhapTonTai(tenDangNhap))
                {
                    return false; //Dữ liệu không hợp lệ, không thực hiện thêm vào database
                }
                // Gọi đến lớp dữ liệu để thêm người dùng
                return nguoidungDL.AddNguoiDung(hoTenND.Trim(), tenDangNhap.Trim(), ChucNangId, soDT, matKhau.Trim(), linkAnh, mail);

            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        //Xóa người dùng
        public bool DeleteNguoiDung(int maND)
        {
            try
            {
                return nguoidungDL.DeleteNguoiDung(maND);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        
        //Cập nhật
        public bool UpdateNuoiDung(int maND, string hoTenND, string tenDangNhap, int ChucNangId,
            string soDT, string matKhau, string linkAnh, string mail)
        {
            try
            {
                return nguoidungDL.UpdateNuoiDung(maND, hoTenND, tenDangNhap, ChucNangId, soDT, matKhau, linkAnh, mail);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        

        //Lấy người dùng qua tên đăng nhập
        public TaiKhoanNDTO GetNguoiDungByTenDN(string tenDN)
        {
            try
            {
                return nguoidungDL.GetNguoiDungByTenDN(tenDN);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        //Đổi mật khẩu
        public bool DoiMatKhau(string tenDangNhap, string matKhauMoi)
        {
            try
            {
                return nguoidungDL.DoiMatKhau(tenDangNhap, matKhauMoi);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
