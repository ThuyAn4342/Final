using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using BusinessLayer;
using TransferObject;

namespace PresentationLayer.Controllers
{
    public partial class MayBayController : UserControl
    {
        public MayBayController()
        {
            InitializeComponent();
        }

        private MayBayBL mayBayBL = new MayBayBL();

        //Hàm Load danh sách máy bay
        private void LoadMayBay()
        {
            dgvDSMayBay.AllowUserToAddRows = false;

            dgvDSMayBay.DataSource = mayBayBL.GetMayBayList();

            // Đổi tên cột hiển thị
            dgvDSMayBay.Columns["maMB"].HeaderText = "Mã máy bay";
            dgvDSMayBay.Columns["tenMB"].HeaderText = "Tên máy bay";
            dgvDSMayBay.Columns["slGheH1"].HeaderText = "Số lượng ghế hạng nhất";
            dgvDSMayBay.Columns["slGhePT"].HeaderText = "Số lượng ghế phổ thông";
            dgvDSMayBay.Columns["tenLoaiMB"].HeaderText = "Loại máy bay";

            //Ẩn cột maLoaiMB
            dgvDSMayBay.Columns["maLoaiMB"].Visible = false;

            //Cột DELETE
            Helper.AddDeleteColumn(dgvDSMayBay);
        }

        //Hàm khởi tạo giá trị cho NumericUpDown
        private void NUDLoad()
        {
            nudslGheH1.Minimum = 10;
            nudslGhePT.Minimum = 10;
            nudslGheH1.Maximum = 200;
            nudslGhePT.Maximum = 200;
            nudslGheH1.Increment = 1;
            nudslGhePT.Increment = 1;
        }

        //Hàm load tên loại máy bay hiển thị trên combobox
        private void CBLoaiMayBayLoad()
        {
            cbLoaiMB.DataSource = mayBayBL.GetTenLoaiMayBay();
            cbLoaiMB.DisplayMember = "tenLoaiMB";
            cbLoaiMB.ValueMember = "maLoaiMB";
            cbLoaiMB.SelectedIndex = -1;
        }

        private void Cancel()
        {
            txtTenMB.Clear();
            cbLoaiMB.SelectedIndex = -1;
            nudslGheH1.Value = nudslGheH1.Minimum;
            nudslGhePT.Value = nudslGhePT.Minimum;
            txtTenMB.Focus();
        }

        //Load trang
        private void MayBayController_Load(object sender, EventArgs e)
        {
            LoadMayBay();
            NUDLoad();
            CBLoaiMayBayLoad();
        }

        private void btnThemMB_Click(object sender, EventArgs e)
        {
            string tenMB = txtTenMB.Text;
            int soLuongGheH1 = (int)nudslGheH1.Value;
            int soLuongGhePT = (int)nudslGhePT.Value;

            // Kiểm tra đã chọn loại máy bay chưa
            if (cbLoaiMB.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại máy bay!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maLoaiMB = Convert.ToInt32(cbLoaiMB.SelectedValue);

            // Kiểm tra rỗng bằng InputHelper
            if (!Helper.IsAllNotEmpty((txtTenMB, "Tên máy bay")))
            {
                return;
            }

            // Gọi hàm thêm từ BLL
            if (mayBayBL.AddMayBay(tenMB, soLuongGheH1, soLuongGhePT, maLoaiMB))
            {
                MessageBox.Show("Thêm máy bay thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Load lại danh sách máy bay
                LoadMayBay();

                // Reset input
                Cancel();
            }
            else
            {
                MessageBox.Show("Tên máy bay đã tồn tại hoặc thông tin không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapNhatMB_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào đang được chọn không
            if (dgvDSMayBay.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra các ô nhập có rỗng không
            if (!Helper.IsAllNotEmpty((txtTenMB, "Tên máy bay")))
            {
                return;
            }

            try
            {
                // Lấy mã máy bay từ dòng được chọn
                int maMB = Convert.ToInt32(dgvDSMayBay.SelectedRows[0].Cells["maMB"].Value);

                // Lấy mã loại máy bay từ combobox
                int maLoaiMB = Convert.ToInt32(cbLoaiMB.SelectedValue); // phải đảm bảo cbLoaiMayBay.DataSource, DisplayMember và ValueMember đã được gán đúng


                // Lấy số lượng ghế hạng 1 và 2
                int slGheH1 = Convert.ToInt32(nudslGheH1.Value);
                int slGheH2 = Convert.ToInt32(nudslGhePT.Value);

                // Gọi hàm cập nhật từ Business Layer
                bool kq = mayBayBL.UpdateMayBay(maMB, txtTenMB.Text.Trim(), slGheH1, slGheH2, maLoaiMB);

                if (kq)
                {
                    MessageBox.Show("Cập nhật máy bay thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvDSMayBay.DataSource = mayBayBL.GetMayBayList(); // Refresh lại danh sách
                    dgvDSMayBay.ClearSelection();
                    Helper.CancelInput(txtTenMB);
                }
                else
                {
                    MessageBox.Show("Tên máy bay đã tồn tại hoặc thông tin không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void dgvDSMayBay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Nếu click vào cột Delete
            if (e.ColumnIndex == dgvDSMayBay.Columns["btnDelete"].Index)
            {
                int maMB = Convert.ToInt32(dgvDSMayBay.Rows[e.RowIndex].Cells["maMB"].Value);

                DialogResult result = MessageBox.Show("Bạn có chắc muốn xoá máy bay này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (mayBayBL.DeleteMayBay(maMB))
                    {
                        MessageBox.Show("Đã xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvDSMayBay.DataSource = mayBayBL.GetMayBayList();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa máy bay!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Đảm bảo không click vào header
                if (e.RowIndex < 0) return;
            }
            if (dgvDSMayBay.SelectedRows.Count > 0)
            {
                // Load dữ liệu lên các control để chỉnh sửa
                DataGridViewRow selectedRow = dgvDSMayBay.Rows[e.RowIndex];

                txtTenMB.Text = selectedRow.Cells["tenMB"].Value?.ToString();

                // Gán giá trị loại máy bay cho ComboBox
                if (selectedRow.Cells["maLoaiMB"].Value != null)
                {
                    cbLoaiMB.SelectedValue = selectedRow.Cells["maLoaiMB"].Value;
                }

                // Gán giá trị ghế hạng nhất và phổ thông
                if (selectedRow.Cells["slGheH1"].Value != null)
                    nudslGheH1.Value = Convert.ToInt32(selectedRow.Cells["slGheH1"].Value);

                if (selectedRow.Cells["slGhePT"].Value != null)
                    nudslGhePT.Value = Convert.ToInt32(selectedRow.Cells["slGhePT"].Value);
            }
        }
    }
}
