using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using BusinessLayer;
using TransferObject;

namespace PresentationLayer.Controllers
{
    public partial class TaiKhoanNDController : UserControl
    {
        NguoiDungBL nguoidungBL = new NguoiDungBL();
        ChucNangBL chucnangBL = new ChucNangBL();
        public TaiKhoanNDController()
        {
            InitializeComponent();
        }

        //Hàm băm mật khẩu
        public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(bytes);

                // Chuyển mảng byte thành chuỗi hex
                StringBuilder builder = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }
        public void NguoiDungDisplay()
        {
            //Load danh sách tài khoản khách hàng
            DataTable dt_user = new DataTable();
            dt_user = nguoidungBL.GetNguoiDungList(3);
            dgvTKKH.AutoGenerateColumns = false;
            dgvTKKH.DataSource = dt_user;

            //Load danh sách tài khoản nhân viên
            DataTable dt_empl = new DataTable();
            dt_empl = nguoidungBL.GetNguoiDungList(2);
            dgvTKNV.AutoGenerateColumns = false;
            dgvTKNV.DataSource = dt_empl;

            //Load danh sách tài khoản admin
            DataTable dt_admin = new DataTable();
            dt_admin = nguoidungBL.GetNguoiDungList(1);
            dgvTKQTV.AutoGenerateColumns = false;
            dgvTKQTV.DataSource = dt_admin;

            //Load combobox chức năng
            cbChucNang.DataSource = chucnangBL.GetChucNangList();
            cbChucNang.DisplayMember = "Ten";
            cbChucNang.ValueMember = "Id";
            cbChucNang.SelectedIndex = -1;
        }

        private void TaiKhoanNDController_Load(object sender, EventArgs e)
        {

            NguoiDungDisplay();
        }

        public void Reset()
        {
            cbChucNang.SelectedIndex =-1;
            txtHoTen.Clear();
            txtMatKhau.Clear();
            txtSoDT.Clear();
            txtTenDN.Clear();
            txtAnhDaiDien.Clear();
            txtMail.Clear();
        }
        private void btnThemTK_Click(object sender, EventArgs e)
        {
            int chucnang = Convert.ToInt32(cbChucNang.SelectedValue) ;
            string hoTen = txtHoTen.Text;
            string tenDangNhap = txtTenDN.Text;
            string soDT = txtSoDT.Text;
            string anhDaiDien = txtAnhDaiDien.Text;
            string matKhau = HashPassword(txtMatKhau.Text);
            string mail = txtMail.Text;


            if (chucnang == null || string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
            bool result = nguoidungBL.AddNguoiDung(hoTen,tenDangNhap,chucnang,soDT,matKhau, anhDaiDien, mail);
            if (result)
            {
                MessageBox.Show("Thêm tài khoản người dùng thành công.", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                NguoiDungDisplay();
                Reset();
            }
            else
            {
                MessageBox.Show("Thêm tài khoản người dùng thất bại!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnHuyThemTK_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnCapNhatTK_Click(object sender, EventArgs e)
        {
            int maND = 0;


            // Xác định tab đang được chọn và lấy maND tương ứng
            if (tabTKND.SelectedTab == tabKH)
            {
                if (dgvTKKH.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một dòng để cập nhật.", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                maND = Convert.ToInt32(dgvTKKH.CurrentRow.Cells["maND"].Value);
            }
            else if (tabTKND.SelectedTab == tabNV)
            {
                if (dgvTKNV.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một dòng để cập nhật.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                maND = Convert.ToInt32(dgvTKNV.CurrentRow.Cells["maND_NV"].Value);
            }
            else if (tabTKND.SelectedTab == tabQTV)
            {
                if (dgvTKQTV.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một dòng để cập nhật.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                maND = Convert.ToInt32(dgvTKQTV.CurrentRow.Cells["maND_Admin"].Value);
            }
            int chucnang = Convert.ToInt32(cbChucNang.SelectedValue);
            string hoTen = txtHoTen.Text;
            string tenDangNhap = txtTenDN.Text;
            string soDT = txtSoDT.Text;
            string anhDaiDien = txtAnhDaiDien.Text;
            string matKhau = HashPassword(txtMatKhau.Text);
            string mail = txtMail.Text;


            if (chucnang == null || string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool result = nguoidungBL.UpdateNuoiDung(maND,hoTen, tenDangNhap, chucnang, soDT, matKhau, anhDaiDien, mail);
            if (result)
            {
                MessageBox.Show("Cập nhật tài khoản người dùng thành công.", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                NguoiDungDisplay();
                Reset();
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản người dùng thất bại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvTKKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvTKKH.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                var maND = dgvTKKH.Rows[e.RowIndex].Cells["maND"].Value;
                if (maND != null)
                {
                    DialogResult dialogResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa tài khoản {maND} này không?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        
                        nguoidungBL.DeleteNguoiDung(Convert.ToInt32(maND));
                        NguoiDungDisplay();
                        Reset();
                    }
                }
            }
            else
            {
                // Đảm bảo không click vào header
                if (e.RowIndex < 0) return;
            }

        }

        private void dgvTKKH_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Lấy dòng được click
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTKKH.Rows[e.RowIndex];
                // Gán giá trị từ từng cột vào textbox tương ứng
                txtHoTen.Text = row.Cells["hoTenND"].Value.ToString();
                txtTenDN.Text = row.Cells["tenDangNhap"].Value.ToString();
                txtSoDT.Text = row.Cells["soDT"].Value.ToString();
                txtMatKhau.Text = row.Cells["matKhau"].Value.ToString();
                txtAnhDaiDien.Text = row.Cells["linkAnh"].Value.ToString(); 
                cbChucNang.SelectedValue = row.Cells["ChucNangId"].Value;
                txtMail.Text = row.Cells["mail"].Value.ToString();
            }
        }

        private void dgvTKNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvTKNV.Columns["Delete_NV"].Index && e.RowIndex >= 0)
            {
                var maND = dgvTKNV.Rows[e.RowIndex].Cells["maND_NV"].Value;
                if (maND != null)
                {
                    DialogResult dialogResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa tài khoản {maND} này không?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {

                        nguoidungBL.DeleteNguoiDung(Convert.ToInt32(maND));
                        NguoiDungDisplay();
                        Reset();
                    }
                }
            }
            else
            {
                // Đảm bảo không click vào header
                if (e.RowIndex < 0) return;
            }
        }

        private void dgvTKQTV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvTKQTV.Columns["Delete_Admin"].Index && e.RowIndex >= 0)
            {
                var maND = dgvTKQTV.Rows[e.RowIndex].Cells["maND_Admin"].Value;
                if (maND != null)
                {
                    DialogResult dialogResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa tài khoản {maND} này không?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {

                        nguoidungBL.DeleteNguoiDung(Convert.ToInt32(maND));
                        NguoiDungDisplay();
                        Reset();
                    }
                }
            }
            else
            {
                // Đảm bảo không click vào header
                if (e.RowIndex < 0) return;
            }
        }

        private void dgvTKNV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Lấy dòng được click
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTKNV.Rows[e.RowIndex];
                // Gán giá trị từ từng cột vào textbox tương ứng
                txtHoTen.Text = row.Cells["hoTenND_NV"].Value.ToString();
                txtTenDN.Text = row.Cells["tenDangNhap_NV"].Value.ToString();
                txtSoDT.Text = row.Cells["soDT_NV"].Value.ToString();
                txtMatKhau.Text = row.Cells["matKhau_NV"].Value.ToString();
                txtAnhDaiDien.Text = row.Cells["linkAnh_NV"].Value.ToString();
                cbChucNang.SelectedValue = row.Cells["ChucNangId_NV"].Value;
                txtMail.Text = row.Cells["mail_NV"].Value.ToString();
            }
        }

        private void dgvTKQTV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Lấy dòng được click
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTKQTV.Rows[e.RowIndex];
                // Gán giá trị từ từng cột vào textbox tương ứng
                txtHoTen.Text = row.Cells["hoTenND_Admin"].Value.ToString();
                txtTenDN.Text = row.Cells["tenDangNhap_Admin"].Value.ToString();
                txtSoDT.Text = row.Cells["soDT_Admin"].Value.ToString();
                txtMatKhau.Text = row.Cells["matKhau_Admin"].Value.ToString();
                txtAnhDaiDien.Text = row.Cells["linkAnh_Admin"].Value.ToString();
                cbChucNang.SelectedValue = row.Cells["ChucNangId_Admin"].Value;
                txtMail.Text = row.Cells["mail_Admin"].Value.ToString();
            }
        }
    }
}
