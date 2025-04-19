using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PresentationLayer.Controllers;
using BusinessLayer;
using TransferObject;
using System.IO;

namespace PresentationLayer
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void LoadController(UserControl us)
        {
            pnMain.Controls.Clear();
            us.Dock = DockStyle.Fill;
            pnMain.Controls.Add(us);

            if (us is HomeController hc)
            {
                hc.CapNhatThongTin += (s, e) =>
                {
                    LoadUser(CurrentUserTO.TaiKhoan); // Cập nhật lại thông tin avatar, tên
                };
            }
        }
        
        public void LoadUser (TaiKhoanNDTO User)
        {
            lbName.Text = User.hoTenND;
            // Ảnh đại diện
            if (!string.IsNullOrEmpty(User.linkAnh) && File.Exists(User.linkAnh))
            {
                picAvatar.Image = Image.FromFile(User.linkAnh);
            }
            else
            {
                // Ảnh mặc định nếu không có
                picAvatar.Image = Properties.Resources.anh_avatar_cute_58;
            }
        }

        
        //Tạo hàm xử lý hoạt động khi các nút được click
        private void ActivateButton(Button clickedButton)
        {
            // Reset tất cả nút trước
            foreach (Control ctrl in pnNavigation.Controls)
            {
                if (ctrl is Button btn && btn != clickedButton)
                {
                    btn.BackColor = Color.WhiteSmoke;      // màu mặc định
                    btn.ForeColor = Color.DarkBlue;      // màu chữ mặc định
                }
                // Thiết lập nút đang chọn
                clickedButton.BackColor = Color.LightBlue;  // màu nổi bật
                clickedButton.ForeColor = Color.DarkBlue;
                
            }
        }
        private void Home_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            
            DialogResult result = login.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Show();
                LoadUser(CurrentUserTO.TaiKhoan);
                
            }
            else
            {
                Application.Exit();
            }
            ActivateButton(btnHome);
            LoadController(new HomeController());
        }

       

        private void btnQLVeHoaDon_Click(object sender, EventArgs e)
        {
            ActivateButton(btnQLVeHoaDon);
            LoadController(new QuanLyVe_HoaDonController());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(btnHome);
            LoadController(new HomeController());
        }

        private void btnChuyenBay_Click(object sender, EventArgs e)
        {
            ActivateButton(btnChuyenBay);
            LoadController(new ChuyenBayController());
        }

        private void btnTuyenBay_Click(object sender, EventArgs e)
        {
            ActivateButton(btnTuyenBay);
            LoadController(new TuyenBayController());
        }

        private void btnMayBay_Click(object sender, EventArgs e)
        {
            ActivateButton(btnMayBay);
            LoadController(new MayBayController());
        }

        private void btnSanBay_Click(object sender, EventArgs e)
        {
            ActivateButton(btnSanBay);
            LoadController(new SanBayController());
        }

        private void btnQLTaiKhoan_Click(object sender, EventArgs e)
        {
            ActivateButton(btnQLTaiKhoan);
            LoadController(new TaiKhoanNDController());
        }

        private void btnQuyDinh_Click(object sender, EventArgs e)
        {
            ActivateButton(btnQuyDinh);
            LoadController(new QuyDinhController());
        }

        private void btnThongKeBaoCao_Click(object sender, EventArgs e)
        {
            ActivateButton(btnThongKeBaoCao);
            LoadController(new ThongKeBaoCaoController());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            ActivateButton(btnDangXuat);
            // Xác nhận trước khi đăng xuất
            DialogResult resultDangXuat = MessageBox.Show($"Bạn có chắc muốn đăng xuất không?", "Xác nhận đăng xuất",
                                                  MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultDangXuat != DialogResult.OK)
            {
                return; // Người dùng chọn Cancel
            }
            // Xóa người dùng hiện tại
            CurrentUserTO.TaiKhoan = null;

            Login login = new Login();
            this.Hide();
           
            DialogResult result = login.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Show();
                LoadUser(CurrentUserTO.TaiKhoan);
            }
            else
            {
                Application.Exit();
            }
            LoadController(new HomeController());



        }

        private void btnChatbot_Click(object sender, EventArgs e)
        {
            ActivateButton(btnChatbot);
            LoadController(new Chatbot());
        }
    }
}
