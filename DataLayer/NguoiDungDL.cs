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
            string sql = "SELECT * FROM NguoiDung " +
                "WHERE tenDangNhap = @tenDangNhap  AND matKhau = @matKhau";
            SqlParameter[] param = { new SqlParameter("@tenDangNhap", tenDangNhap),
                                     new SqlParameter("@matKhau", matKhau)};

           
            try
            {
                DataTable dt = provider.MyExecuteReader(sql, CommandType.Text, param);
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
                        linkAnh = row["linkAnh"].ToString()
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

        //Lấy danh sách người dùng
        public DataTable GetNguoiDungList(int ChucNangId)
        {
            try
            {
                if (ChucNangId == 0)
                {
                    string sql_all = "SELECT * FROM NguoiDung";
                    return provider.MyExecuteReader(sql_all, CommandType.Text);
                }
                string sql = "SELECT * FROM NguoiDung WHERE ChucNangId = @ChucNangId";
                SqlParameter[] param = { new SqlParameter("@ChucNangId", ChucNangId) };
                return provider.MyExecuteReader(sql, CommandType.Text, param);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        //Lấy người dùng qua id
        public TaiKhoanNDTO GetNguoiDungByID(int id)
        {
            string sql = "SELECT * FROM NguoiDung WHERE maND = " + id;
            try
            {
                DataTable dt = provider.MyExecuteReader(sql, CommandType.Text);
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
            string sql = "SELECT COUNT(*) FROM NguoiDung WHERE TenDangNhap = @TenDangNhap";
            SqlParameter[] parameters = { new SqlParameter("@TenDangNhap", tenDangNhap) };

            int count = Convert.ToInt32(provider.MyExecuteScalar(sql, CommandType.Text, parameters));
            return count > 0;
        }

        //Thêm người dùng mới
        public bool AddNguoiDung(string hoTenND, string tenDangNhap, int ChucNangId,
            string soDT, string matKhau, string linkAnh, string mail)
        {
            try
            {
                string sql = "INSERT INTO NguoiDung (hoTenND, tenDangNhap, ChucNangId, soDT, matKhau, linkAnh, mail) " +
               "VALUES(@hoTenND, @tenDangNhap, @ChucNangId, @soDT, @matKhau, @linkAnh, @mail)";
                SqlParameter[] param = { new SqlParameter("@hoTenND", hoTenND),
                                     new SqlParameter("@tenDangNhap",tenDangNhap),
                                     new SqlParameter("@ChucNangId",ChucNangId),
                                     new SqlParameter("@soDT", soDT),
                                     new SqlParameter("@matKhau", matKhau),
                                     new SqlParameter("@linkAnh", linkAnh),
                                     new SqlParameter("@mail", mail)
            };

                return provider.MyExecuteNonQuery(sql, CommandType.Text, param) > 0;
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
                string sql = "DELETE FROM NguoiDung WHERE maND = @maND";
                SqlParameter[] param = { new SqlParameter("@maND", maND) };
                return provider.MyExecuteNonQuery(sql, CommandType.Text, param) > 0;

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
                string sql = "UPDATE NguoiDung SET hoTenND =@hoTenND, tenDangNhap=@tenDangNhap, ChucNangId=@ChucNangId," +
               " soDT = @soDT, matKhau=@matKhau, linkAnh=@linkAnh, mail=@mail WHERE maND =@maND";

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
                return provider.MyExecuteNonQuery(sql, CommandType.Text, parameters) > 0;
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

       
        //Lấy mail qua tên đăng nhập
        public TaiKhoanNDTO GetNguoiDungByTenDN(string tenDN)
        {
            string sql = "SELECT * FROM NguoiDung WHERE tenDangNhap = '" + tenDN + "'";
            try
            {
                DataTable dt = provider.MyExecuteReader(sql, CommandType.Text);
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
                string sql = "UPDATE NguoiDung SET  matKhau=@matKhau WHERE tenDangNhap=@tenDangNhap" ;
                SqlParameter[] param = { new SqlParameter("@tenDangNhap", tenDangNhap),
                                         new SqlParameter("@matKhau", matKhauMoi)};

                return provider.MyExecuteNonQuery(sql, CommandType.Text, param) > 0;
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }

}
