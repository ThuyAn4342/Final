using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;
using BusinessLayer;
using System.IO;

namespace PresentationLayer.Controllers
{
    public partial class HomeController : UserControl
    {
        public HomeController()
        {
            InitializeComponent();
        }

        //Khai báo sự kiện
        public event EventHandler CapNhatThongTin;


        NguoiDungBL nguoidungBL = new NguoiDungBL();

        ChucNangBL chucnangBL = new ChucNangBL();
        private void LoadThongTinUser(TaiKhoanNDTO User)
        {
            //Load combobox chức năng
            cbChucNang.DataSource = chucnangBL.GetChucNangList();
            cbChucNang.DisplayMember = "Ten";
            cbChucNang.ValueMember = "Id";
            //Load thông tin
            lbTenTK.Text = User.hoTenND;
            txtHoTen.Text = User.hoTenND;
            txtTenDN.Text = User.tenDangNhap;
            cbChucNang.SelectedIndex = User.ChucNangId -1;
            txtMatKhau.Text = User.matKhau;
            txtSoDT.Text = User.soDT;
            txtLinkAnh.Text = User.linkAnh;

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
        private void HomeController_Load(object sender, EventArgs e)
        {
            

            if (CurrentUserTO.TaiKhoan != null)
            {
                LoadThongTinUser(CurrentUserTO.TaiKhoan);
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string Path = openFileDialog.FileName;

                // Gán vào textbox đường dẫn
                txtLinkAnh.Text = Path;

                // Hiển thị ảnh
                picAvatar.Image = Image.FromFile(Path);
            }
        }

        private void btnCapNhatTT_Click(object sender, EventArgs e)
        {
            int chucnang = Convert.ToInt32(cbChucNang.SelectedValue);
            string hoTen = txtHoTen.Text;
            string tenDangNhap = txtTenDN.Text;
            string soDT = txtSoDT.Text;
            string linkAnh = txtLinkAnh.Text;
            string matKhau = txtMatKhau.Text;


            try
            {
                if (chucnang == null || string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
                {
                    MessageBox.Show("Thông tin về Chức Năng, Tên Đăng Nhập và Mật Khẩu KHÔNG ĐƯỢC để trống!!! .");
                    return;
                }

                bool result = nguoidungBL.UpdateNuoiDung(CurrentUserTO.TaiKhoan.maND, hoTen, tenDangNhap,
                    chucnang, soDT, matKhau, linkAnh);
                if (result)
                {
                    try
                    {
                        TaiKhoanNDTO acc = nguoidungBL.GetNguoiDungByID(CurrentUserTO.TaiKhoan.maND);
                        CurrentUserTO.TaiKhoan = acc;
                        MessageBox.Show("Cập nhật tài khoản người dùng thành công.");
                        LoadThongTinUser(CurrentUserTO.TaiKhoan);
                        CapNhatThongTin?.Invoke(this, EventArgs.Empty); //Gọi sự kiện nếu có sự lắng nghe đến nó

                    }
                    catch (SqlException ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Cập nhật tài khoản người dùng thất bại!");
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Cập nhật thất bại. LỖI: " + ex.Message);
            }
        }

        private void btnHuyThaoTac_Click(object sender, EventArgs e)
        {
            LoadThongTinUser(CurrentUserTO.TaiKhoan);
        }
    }
}
