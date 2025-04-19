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
            tenDangNhap = txtTenDN.Text;
            if (nguoidungBL.KiemTraTenDangNhapTonTai(tenDangNhap) )
            {
                try
                {
                    
                    TaiKhoanNDTO user = nguoidungBL.GetNguoiDungByTenDN(tenDangNhap);
                    mail = user.mail;

                    //Gửi mã xác nhận qua email
                    string ma = TaoMaNgauNhien();
                    MaXacNhanDaGui = "1";

                    //hiển thị controller nhập mã xác nhận                          
                    LoadController(new NhapMaXN());

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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
