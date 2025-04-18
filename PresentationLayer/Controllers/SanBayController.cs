using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Controllers
{
    public partial class SanBayController : UserControl
    {
        public SanBayController()
        {
            InitializeComponent();
        }

        private SanBayBL sanBayBL = new SanBayBL();

        private void SanBayController_Load(object sender, EventArgs e)
        {
            dgvSanBay.AllowUserToAddRows = false;

            dgvSanBay.DataSource = sanBayBL.GetSanBayList();

            //Đổi tên cột
            dgvSanBay.Columns["maSB"].HeaderText = "Mã sân bay";
            dgvSanBay.Columns["tenSB"].HeaderText = "Tên sân bay";
            dgvSanBay.Columns["tinhThanh"].HeaderText = "Tỉnh thành";
            dgvSanBay.Columns["quocGia"].HeaderText = "Quốc gia";

            //Cột DELETE
            InputHelper.AddDeleteColumn(dgvSanBay);

            dgvSanBay.ClearSelection();
        }

        private void btnThemSB_Click(object sender, EventArgs e)
        {
            string tenSanBay = txtTenSB.Text;
            string tenTinhThanh = txtTinhThanh.Text;
            string tenQuocGia = txtQuocGia.Text;

            if (!InputHelper.IsAllNotEmpty((txtTenSB, "Tên sân bay"),
                (txtTinhThanh, "Tỉnh thành"),
                (txtQuocGia, "Quốc gia")))
            {
                return;
            }


            if (sanBayBL.AddSanBay(tenSanBay, tenTinhThanh, tenQuocGia))
            {
                MessageBox.Show("Đã thêm sân bay thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvSanBay.DataSource = sanBayBL.GetSanBayList(); // Load lại danh sách
                InputHelper.CancelInput(txtTenSB, txtTinhThanh, txtQuocGia);
            }
            else
            {
                MessageBox.Show("Tên sân bay đã tồn tại hoặc thông tin không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuyThemSB_Click(object sender, EventArgs e)
        {
            InputHelper.CancelInput(txtTenSB, txtTinhThanh, txtQuocGia);
            dgvSanBay.ClearSelection();
        }

        private void btnCapNhatSB_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào đang được chọn không
            if (dgvSanBay.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!InputHelper.IsAllNotEmpty((txtTenSB, "Tên sân bay"),
               (txtTinhThanh, "Tỉnh thành"),
               (txtQuocGia, "Quốc gia")))
            {
                return;
            }

            try
            {
                // Gọi Business Layer để cập nhật
                int maSB = Convert.ToInt32(dgvSanBay.SelectedRows[0].Cells["maSB"].Value); // Chuyển đổi sau khi chắc chắn có dữ liệu
                bool kq = sanBayBL.UpdateSanBay(maSB, txtTenSB.Text, txtTinhThanh.Text, txtQuocGia.Text);

                if (kq)
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvSanBay.DataSource = sanBayBL.GetSanBayList(); // Refresh dữ liệu
                    dgvSanBay.ClearSelection();
                    InputHelper.CancelInput(txtTenSB, txtTinhThanh, txtQuocGia);
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

        private void dgvSanBay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra người dùng có click vào cột Delete không
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvSanBay.Columns["btnDelete"].Index)
            {
                // Lấy mã sân bay từ dòng được chọn
                int maSB = Convert.ToInt32(dgvSanBay.Rows[e.RowIndex].Cells["maSB"].Value);

                DialogResult result = MessageBox.Show("Bạn có chắc muốn xoá sân bay này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (sanBayBL.DeleteSanBay(maSB)) // gọi đến tầng Business
                    {
                        MessageBox.Show("Đã xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvSanBay.DataSource = sanBayBL.GetSanBayList(); // Load lại danh sách
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa sân bay!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Đảm bảo không click vào header
                if (e.RowIndex < 0) return;

                // Lấy dòng được click
                DataGridViewRow selectedRow = dgvSanBay.Rows[e.RowIndex];
                // Lấy giá trị từ cột theo tên cột
                txtTenSB.Text = selectedRow.Cells["tenSB"].Value?.ToString();
                txtTinhThanh.Text = selectedRow.Cells["tinhThanh"].Value?.ToString();
                txtQuocGia.Text = selectedRow.Cells["quocGia"].Value?.ToString();
            }
        }
    }
}
