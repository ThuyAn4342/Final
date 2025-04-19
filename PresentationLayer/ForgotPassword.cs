using PresentationLayer.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PresentationLayer.QuenMatKhau;
using BusinessLayer;
using TransferObject;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

namespace PresentationLayer
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        public void LoadController(UserControl us)
        {
            pnMain.Controls.Clear();
            us.Dock = DockStyle.Fill;
            pnMain.Controls.Add(us);         
        }

        private string TaoMaNgauNhien()
        {
            // Tạo mã ngẫu nhiên:
            return new Random().Next(1000, 9999).ToString();
        }

        public string MaXacNhanDaGui { get; set; }
        NguoiDungBL nguoidungBL = new NguoiDungBL();
        public string mail;
        public string tenDangNhap;
        private void btnGuiMaXN_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTenDN.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDN.Focus();
            }
            else
            {
                tenDangNhap = txtTenDN.Text;
                if (nguoidungBL.KiemTraTenDangNhapTonTai(tenDangNhap))
                {
                    try
                    {

                        TaiKhoanNDTO user = nguoidungBL.GetNguoiDungByTenDN(tenDangNhap);
                        mail = user.mail;

                        //Gửi mã xác nhận qua email
                        string ma = TaoMaNgauNhien();

                        // Gửi mã xác nhận
                        if (GuiMaXacNhan(ma))
                        {
                            MaXacNhanDaGui = ma; // Lưu mã để kiểm tra sau
                            LoadController(new NhapMaXN()); // Hiển thị giao diện nhập mã
                        }
                        else
                        {
                            MessageBox.Show("Không gửi được mã xác nhận.");
                        }

                    }
                    catch (SqlException ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập không tồn tại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenDN.Focus();

                }
            }      
        }

        private bool GuiMaXacNhan(string maXacNhan)
        {
            try
            {
                string fromAdd = "haonhutthach10@gmail.com"; // Email người gửi
                string fromPassword = "wwnm rtct wnit igql";  // Mật khẩu ứng dụng (App password từ Google)

                string toAdd = nguoidungBL.GetEmailByUsername(txtTenDN.Text); // Lấy email người dùng
                string subject = "Mã xác nhận đặt lại mật khẩu";
                string body = $"Xin chào,\n\nMã xác nhận để đặt lại mật khẩu của bạn là: {maXacNhan}\n\nVui lòng không chia sẻ mã này với bất kỳ ai.\n\nTrân trọng.";

                using (MailMessage message = new MailMessage(fromAdd, toAdd))
                {
                    message.Subject = subject;
                    message.Body = body;
                    message.IsBodyHtml = false; // Nếu dùng HTML thì đặt là true

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new NetworkCredential(fromAdd, fromPassword);
                        smtp.EnableSsl = true;

                        smtp.Send(message);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gửi email: " + ex.Message);
                return false;
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
