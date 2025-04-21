using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using TransferObject;
namespace PresentationLayer.Controllers
{
    public partial class TuyenBayController : UserControl
    {
        private TuyenBayBL tuyenBayBL = new TuyenBayBL();
        private SanBayBL sanBayBL = new SanBayBL();
        private SanBayTrungGianBL sanBayTrungGianBL = new SanBayTrungGianBL();
        public TuyenBayController()
        {
            InitializeComponent();
        }
        public void TuyenBayDisplay()
        {
            dgvTuyenBay.DataSource = tuyenBayBL.GetTuyenBayList();
            // Ẩn các cột maSB
            dgvTuyenBay.Columns["MaSanBayDi"].Visible = false;
            dgvTuyenBay.Columns["MaSanBayDen"].Visible = false;

            // Set ComboBox for Sân bay đi
            cbSanBayDi.DataSource = sanBayBL.GetSanBayList();
            cbSanBayDi.DisplayMember = "tenSB";
            cbSanBayDi.ValueMember = "maSB";
            cbSanBayDi.SelectedIndex = -1;

            // Set ComboBox for Sân bay đến
            cbSanBayDen.DataSource = sanBayBL.GetSanBayList();
            cbSanBayDen.DisplayMember = "tenSB";
            cbSanBayDen.ValueMember = "maSB";
            cbSanBayDen.SelectedIndex = -1;

            // Set ComboBox for DiemDi
            var diemDiList = sanBayBL.GetSanBayTOs();
            diemDiList.Insert(0, new SanBayTO { maSB = 0, TenSanBay = "None" });

            cbDiemDi.DataSource = diemDiList;
            cbDiemDi.DisplayMember = "TenSanBay";
            cbDiemDi.ValueMember = "maSB";
            cbDiemDi.SelectedIndex = 0;

            // Set ComboBox for DiemDen
            var diemDenList = sanBayBL.GetSanBayTOs();
            diemDenList.Insert(0, new SanBayTO { maSB = 0, TenSanBay = "None" });

            cbDiemDen.DataSource = diemDenList;
            cbDiemDen.DisplayMember = "TenSanBay";
            cbDiemDen.ValueMember = "maSB";
            cbDiemDen.SelectedIndex = 0;
        }

        public void TuyenBayTrungGianDisplay()
        {
            dgvSBTrungGian.DataSource = sanBayTrungGianBL.GetSanBayTrungGianList();
            dgvSBTrungGian.Columns["maTB"].Visible = false;
            dgvSBTrungGian.Columns["maSB"].Visible = false;
            dgvSBTrungGian.Columns["Delete_TrungGian"].DisplayIndex = dgvSBTrungGian.Columns.Count - 1;

            // Set ComboBox for MaTB
            cbMaTB.DataSource = tuyenBayBL.GetTuyenBayList();
            cbMaTB.DisplayMember = "tenTB";
            cbMaTB.ValueMember = "maTB";
            cbMaTB.SelectedIndex = -1;

            // Set ComboBox for MaSB
            cbMaSB.DataSource = sanBayBL.GetSanBayList();
            cbMaSB.DisplayMember = "tenSB";
            cbMaSB.ValueMember = "maSB";
            cbMaSB.SelectedIndex = -1;


        }
        private void TuyenBayController_Load(object sender, EventArgs e)
        {
            TuyenBayDisplay();

            TuyenBayTrungGianDisplay();
        }

        // Sân bay trung gian
        private void btnThemSBTG_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbMaSB.SelectedValue == null || cbMaTB.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn sân bay và tuyến bay.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtThoiGianDung.Text))
                {
                    MessageBox.Show("Vui lòng nhập thời gian dừng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int maSB = Convert.ToInt32(cbMaSB.SelectedValue);
                int maTB = Convert.ToInt32(cbMaTB.SelectedValue);

                if (!int.TryParse(txtThoiGianDung.Text, out int thoiGianDung))
                {
                    MessageBox.Show("Thời gian dừng phải là số nguyên.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool ketQua = sanBayTrungGianBL.AddSanBayTrungGian(maSB, maTB, thoiGianDung);

                if (ketQua)
                {
                    MessageBox.Show("Thêm sân bay trung gian thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sân bay đã tồn tại trong tuyến bay này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SqlException sqlEx)
            {
                // Thông báo lỗi chi tiết từ trigger
                MessageBox.Show($"Lỗi từ hệ thống: {sqlEx.Message}", "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dgvSBTrungGian.DataSource = sanBayTrungGianBL.GetSanBayTrungGianList();
            }
        }

        // Danh sách tuyến bay
        private void btnTimKiemTB_Click(object sender, EventArgs e)
        {
            var sbDi = cbDiemDi.SelectedValue;
            var sbDen = cbDiemDen.SelectedValue;
            if (sbDi == null || sbDen == null)
            {
                MessageBox.Show("Vui lòng chọn sân bay đi ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var tuyenBayList = tuyenBayBL.GetTuyenBayByTinh(Convert.ToInt32(sbDi), Convert.ToInt32(sbDen));

            dgvTuyenBay.DataSource = tuyenBayList;



        }

        private void btnThemTB_Click(object sender, EventArgs e)
        {
            var sbDi = cbSanBayDi.SelectedValue;
            var sbDen = cbSanBayDen.SelectedValue;
            var tenTB = txtTenTB.Text;
            var giaTB = txtGiaTB.Text;
            if (sbDi == null || sbDen == null)
            {
                MessageBox.Show("Vui lòng chọn sân bay đi và đến");
                return;
            }

            if (string.IsNullOrWhiteSpace(tenTB) || string.IsNullOrWhiteSpace(giaTB))
            {
                MessageBox.Show("Vui lòng nhập tên tuyến bay và giá");
                return;
            }

            if (sbDi.ToString() == sbDen.ToString())
            {
                MessageBox.Show("Sân bay đi và đến không được trùng nhau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tuyenBayBL.CheckTuyenBayExists(tenTB))
            {
                MessageBox.Show("Tuyến bay đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            tuyenBayBL.AddTuyenBay(tenTB, (int)sbDi, (int)sbDen, float.Parse(giaTB));
            dgvTuyenBay.DataSource = tuyenBayBL.GetTuyenBayList();
            this.Clear();
        }


        private void btnCapNhatTB_Click(object sender, EventArgs e)
        {
            if(dgvTuyenBay.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var maTB = dgvTuyenBay.CurrentRow.Cells["MaTB"].Value;
            var sbDi = cbSanBayDi.SelectedValue;
            var sbDen = cbSanBayDen.SelectedValue;
            var tenTB = txtTenTB.Text;
            var giaTB = txtGiaTB.Text;
            try
            {
                tuyenBayBL.UpdateTuyenBay(Convert.ToInt32(maTB), tenTB, (int)sbDi, (int)sbDen, float.Parse(giaTB));
                MessageBox.Show("Cập nhật thành công");
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            

            dgvTuyenBay.DataSource = tuyenBayBL.GetTuyenBayList();
            this.Clear();
        }

        private void Clear()
        {
            cbSanBayDen.SelectedIndex = -1;
            cbSanBayDi.SelectedIndex = -1;
            txtTenTB.Text = string.Empty;
            txtGiaTB.Text = string.Empty;
            dgvTuyenBay.ClearSelection();
        }
        private void btnHuyThemTB_Click(object sender, EventArgs e)
        {
            this.Clear();
        }
        private void dgvTuyenBay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTuyenBay.SelectedRows.Count != 0)
            {
                txtGiaTB.Text = dgvTuyenBay.Rows[e.RowIndex].Cells["GiaTB"].Value.ToString();
                txtTenTB.Text = dgvTuyenBay.Rows[e.RowIndex].Cells["TenTB"].Value.ToString();
                cbSanBayDi.SelectedValue = dgvTuyenBay.Rows[e.RowIndex].Cells["MaSanBayDi"].Value;
                cbSanBayDen.SelectedValue = dgvTuyenBay.Rows[e.RowIndex].Cells["MaSanBayDen"].Value;
            }

        }

        private void dgvSBTrungGian_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvSBTrungGian.Columns["Delete_TrungGian"].Index && e.RowIndex >= 0)
            {
                var maTB = dgvSBTrungGian.Rows[e.RowIndex].Cells["maTB"].Value;
                var maSB = dgvSBTrungGian.Rows[e.RowIndex].Cells["maSB"].Value;
                if (maTB != null && maSB != null)
                {
                    var confirm = MessageBox.Show($"Bạn có chắc muốn xóa sân bay trung gian", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        sanBayTrungGianBL.DeleteSanBayTrungGian(Convert.ToInt32(maSB), Convert.ToInt32(maTB));
                        dgvSBTrungGian.DataSource = sanBayTrungGianBL.GetSanBayTrungGianList();
                    }
                }
            }
            else
            {
                if (e.RowIndex < 0) return;
            }
        }
    }
}
