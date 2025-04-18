using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BusinessLayer;
using TransferObject;

namespace PresentationLayer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        NguoiDungBL nguoidungBL = new NguoiDungBL();

        private void Login_Load(object sender, EventArgs e)
        {

        }
        public void ResetLogin()
        {
            txtTenDN.Clear();
            txtMatKhau.Clear();
            txtTenDN.Focus();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDN.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                TaiKhoanNDTO account = new TaiKhoanNDTO();
                account = nguoidungBL.Login(tenDangNhap, matKhau);

                if (account != null)
                {
                    int chucNangId = account.ChucNangId;

                    if (chucNangId == 1) // chỉ cho phép người dùng có chức năng = 1 đăng nhập
                    {
                        // Gán vào CurrentUser 
                        CurrentUserTO.TaiKhoan = account;

                        this.DialogResult = DialogResult.OK;
                        this.Close(); // login thành công
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản của bạn không có quyền truy cập hệ thống.", "Phân quyền", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ResetLogin();
                    }

                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ResetLogin();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Đăng nhập thất bại. Chi tiết: " + ex.Message);
            }

            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
