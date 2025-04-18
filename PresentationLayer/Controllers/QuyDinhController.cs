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
    public partial class QuyDinhController : UserControl
    {
        public QuyDinhController()
        {
            InitializeComponent();
        }

        private QuyDinhBL quyDinhBL = new QuyDinhBL();


        //Hàm load danh sách quy định từ DB
        private void LoadQuyDinh()
        {
            dgvQuyDinh.AllowUserToAddRows = false;

            dgvQuyDinh.DataSource = quyDinhBL.GetQuyDinhList();

            // Đổi tên cột hiển thị
            dgvQuyDinh.Columns["maQD"].HeaderText = "Mã quy định";
            dgvQuyDinh.Columns["tenQD"].HeaderText = "Tên quy định";
            dgvQuyDinh.Columns["noidungQD"].HeaderText = "Nội dung quy định";
            dgvQuyDinh.Columns["ngayCapNhat"].HeaderText = "Ngày cập nhật";
            //Cột DELETE
            InputHelper.AddDeleteColumn(dgvQuyDinh);
        }

        private void QuyDinhController_Load(object sender, EventArgs e)
        {
            LoadQuyDinh();
        }

        private void btnThemQD_Click(object sender, EventArgs e)
        {
            // Kiểm tra rỗng
            if (!InputHelper.IsAllNotEmpty(
                (txtTenQuyDinh, "Tên quy định"),
                (txtNoiDungQD, "Nội dung quy định")))
            {
                return;
            }
            string tenQuyDinh = txtTenQuyDinh.Text.Trim();

            // Kiểm tra nội dung có phải là số nguyên
            int noiDungQD;
            if (!InputHelper.TryGetIntFromTextBox(txtNoiDungQD, out noiDungQD, "Nội dung quy định"))
            {
                return;
            }

            // Gọi Business Layer để thêm
            if (quyDinhBL.AddQuyDinh(tenQuyDinh, noiDungQD))
            {
                MessageBox.Show("Thêm quy định thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvQuyDinh.DataSource = quyDinhBL.GetQuyDinhList(); // Hoặc LoadQuyDinh() nếu bạn có
                InputHelper.CancelInput(txtTenQuyDinh, txtNoiDungQD);
            }
            else
            {
                MessageBox.Show("Tên quy định đã tồn tại hoặc thông tin không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapNhatQD_Click(object sender, EventArgs e)
        {
            if (dgvQuyDinh.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra rỗng
            if (!InputHelper.IsAllNotEmpty(
                (txtTenQuyDinh, "Tên quy định"),
                (txtNoiDungQD, "Nội dung quy định")))
            {
                return;
            }

            // Kiểm tra nội dung là số nguyên
            if (!InputHelper.TryGetIntFromTextBox(txtNoiDungQD, out int noiDungQD, "Nội dung quy định"))
            {
                return;
            }

            try
            {
                int maQD = Convert.ToInt32(dgvQuyDinh.SelectedRows[0].Cells["maQD"].Value);
                bool kq = quyDinhBL.UpdateQuyDinh(maQD, txtTenQuyDinh.Text.Trim(), noiDungQD);

                if (kq)
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvQuyDinh.DataSource = quyDinhBL.GetQuyDinhList();
                    dgvQuyDinh.ClearSelection();
                    InputHelper.CancelInput(txtTenQuyDinh, txtNoiDungQD);
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

        private void btnHuyThemQD_Click(object sender, EventArgs e)
        {
            InputHelper.CancelInput(txtTenQuyDinh, txtNoiDungQD);
            dgvQuyDinh.ClearSelection();
        }

        private void dgvQuyDinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra người dùng có click vào cột Delete không
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvQuyDinh.Columns["btnDelete"].Index)
            {
                // Lấy mã sân bay từ dòng được chọn
                int maSB = Convert.ToInt32(dgvQuyDinh.Rows[e.RowIndex].Cells["maQD"].Value);

                DialogResult result = MessageBox.Show("Bạn có chắc muốn xoá quy định này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (quyDinhBL.XoaQuyDinh(maSB)) // gọi đến tầng Business
                    {
                        MessageBox.Show("Đã xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvQuyDinh.DataSource = quyDinhBL.GetQuyDinhList(); // Load lại danh sách
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa quy định!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Đảm bảo không click vào header
                if (e.RowIndex < 0) return;

                // Lấy dòng được click
                DataGridViewRow selectedRow = dgvQuyDinh.Rows[e.RowIndex];
                // Lấy giá trị từ cột theo tên cột
                txtTenQuyDinh.Text = selectedRow.Cells["tenQD"].Value?.ToString();
                txtNoiDungQD.Text = selectedRow.Cells["noidungQD"].Value?.ToString();
            }
        }
    }
}
