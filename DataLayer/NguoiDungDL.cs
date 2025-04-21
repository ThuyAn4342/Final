using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using System.Security.Cryptography;

namespace DataLayer
{
    public class NguoiDungDL
    {
        private DataProvider provider = new DataProvider();

        //Login
        public TaiKhoanNDTO Login( string tenDangNhap, string matKhau)
        {
            string sql = "sp_Login";
            SqlParameter[] param = { new SqlParameter("@tenDangNhap", tenDangNhap),
                                     new SqlParameter("@matKhau", matKhau)};

           
            try
            {
                DataTable dt = provider.MyExecuteReader(sql, CommandType.StoredProcedure, param);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    return new TaiKhoanNDTO
                    {
                        maND = Convert.ToInt32(row["maND"]),
                        hoTenND = row["hoTenND"].ToString(),
                        tenDangNhap = row["tenDangNhap"].ToString(),
                        ChucNangId = Convert.ToInt32(row["ChucNangId"]),
                        soDT = row["soDT"].ToString(),
                        matKhau = row["matKhau"].ToString(),
                        linkAnh = row["linkAnh"].ToString(),
                        mail = row["mail"].ToString()
                    };
                }
                else
                    return null;
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        //Lấy mail khi có tên đăng nhập
        public string GetEmailByUsername(string tenDangNhap)
        {
            string sql = "sp_GetEmailByUsername";
            SqlParameter[] parameters = {
                new SqlParameter("@tenDangNhap", tenDangNhap)
            };

            DataTable dt = provider.MyExecuteReader(sql, CommandType.StoredProcedure, parameters);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["mail"].ToString();
            }

            return null;
        }


        //Lấy danh sách người dùng
        public DataTable GetNguoiDungList(int ChucNangId)
        {
            try
            {
               
                string sql = "sp_LayDSNguoiDungTheoChucNang";
                SqlParameter[] param = { new SqlParameter("@ChucNangId", ChucNangId) };
                return provider.MyExecuteReader(sql, CommandType.StoredProcedure, param);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        //Lấy người dùng qua id
        public TaiKhoanNDTO GetNguoiDungByID(int id)
        {
            string sql = "sp_LayNguoiDungQuaId" ;
            SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@id",id)
                };
            try
            {
                DataTable dt = provider.MyExecuteReader(sql, CommandType.StoredProcedure, parameters);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    return new TaiKhoanNDTO
                    {
                        maND = Convert.ToInt32(row["maND"]),
                        hoTenND = row["hoTenND"].ToString(),
                        tenDangNhap = row["tenDangNhap"].ToString(),
                        ChucNangId = Convert.ToInt32(row["ChucNangId"]),
                        soDT = row["soDT"].ToString(),
                        matKhau = row["matKhau"].ToString(),
                        linkAnh = row["linkAnh"].ToString(),
                        mail = row["mail"].ToString()
                    };
                }
                else
                    return null;
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        //Kiểm tra tên đăng nhập đã tồn tại hay chưa
        public bool KiemTraTenDangNhapTonTai(string tenDangNhap)
        {
            string sql = "sp_KiemTraTenDNTonTai";
            SqlParameter[] parameters = { new SqlParameter("@TenDangNhap", tenDangNhap) };

            int count = Convert.ToInt32(provider.MyExecuteScalar(sql, CommandType.StoredProcedure, parameters));
            return count > 0;
        }

        //Thêm người dùng mới
        public bool AddNguoiDung(string hoTenND, string tenDangNhap, int ChucNangId,
            string soDT, string matKhau, string linkAnh, string mail)
        {
            try
            {
                string sql = "sp_AddNguoiDung";
                SqlParameter[] param = { new SqlParameter("@hoTenND", hoTenND),
                                     new SqlParameter("@tenDangNhap",tenDangNhap),
                                     new SqlParameter("@ChucNangId",ChucNangId),
                                     new SqlParameter("@soDT", soDT),
                                     new SqlParameter("@matKhau", matKhau),
                                     new SqlParameter("@linkAnh", linkAnh),
                                     new SqlParameter("@mail", mail)
            };

                return provider.MyExecuteNonQuery(sql, CommandType.StoredProcedure, param) > 0;
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        //Xóa người dùng
        public bool DeleteNguoiDung (int maND)
        {
            try
            {
                string sql = "sp_XoaNguoiDung";
                SqlParameter[] param = { new SqlParameter("@maND", maND) };
                return provider.MyExecuteNonQuery(sql, CommandType.StoredProcedure, param) > 0;

            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        //Cập nhật thông tin
        public bool UpdateNuoiDung(int maND, string hoTenND, string tenDangNhap, int ChucNangId,
            string soDT, string matKhau, string linkAnh, string mail)
        {
            try
            {
                string sql = "sp_CapNhatNguoiDung";

                SqlParameter[] parameters = new SqlParameter[]
                {
                new SqlParameter("@maND", maND),
                new SqlParameter("@hoTenND", hoTenND),
                new SqlParameter("@tenDangNhap",tenDangNhap),
                new SqlParameter("@ChucNangId",ChucNangId),
                new SqlParameter("@soDT", soDT),
                new SqlParameter("@matKhau", matKhau),
                new SqlParameter("@linkAnh", linkAnh),
                new SqlParameter("@mail", mail)
                };
                return provider.MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters) > 0;
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

       
        //Lấy user qua tên đăng nhập
        public TaiKhoanNDTO GetNguoiDungByTenDN(string tenDangNhap)
        {
            string sql = "sp_LayNDQuaTenDN";
            SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@tenDangNhap",tenDangNhap) 
                };
            try
            {
                DataTable dt = provider.MyExecuteReader(sql, CommandType.StoredProcedure,parameters);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    return new TaiKhoanNDTO
                    {
                        maND = Convert.ToInt32(row["maND"]),
                        hoTenND = row["hoTenND"].ToString(),
                        tenDangNhap = row["tenDangNhap"].ToString(),
                        ChucNangId = Convert.ToInt32(row["ChucNangId"]),
                        soDT = row["soDT"].ToString(),
                        matKhau = row["matKhau"].ToString(),
                        linkAnh = row["linkAnh"].ToString(),
                        mail = row["mail"].ToString()
                    };
                }
                else
                    return null;
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        //Đổi mật khẩu
        public bool DoiMatKhau (string tenDangNhap, string matKhauMoi)
        {
            try
            {
                string sql = "sp_DoiMatKhau";
                SqlParameter[] param = { new SqlParameter("@tenDangNhap", tenDangNhap),
                                         new SqlParameter("@matKhau", matKhauMoi)};

                return provider.MyExecuteNonQuery(sql, CommandType.StoredProcedure, param) > 0;
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }

}
