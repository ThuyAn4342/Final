using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;
using BusinessLayer;
namespace PresentationLayer.Controllers
{
    public partial class ChuyenBayController : UserControl
    {
        private ChuyenBayBL chuyenBayBL = new ChuyenBayBL();
        private TuyenBayBL tuyenBayBL = new TuyenBayBL();
        private TienTrinhBL tienTrinhBL = new TienTrinhBL();
        public ChuyenBayController()
        {
            InitializeComponent();
        }

        public void ChuyenBayDisplay()
        {
            dgvChuyenBay.DataSource = chuyenBayBL.GetChuyenBayList();
            dgvChuyenBay.Columns["MaTB"].Visible = false;
            dgvChuyenBay.Columns["TienTrinhID"].Visible = false;
            dgvChuyenBay.Columns["Delete"].DisplayIndex = dgvChuyenBay.Columns.Count - 1;

            // Load Tuyến bay
            cbMaTuyenBay.DataSource = tuyenBayBL.GetTuyenBayList();
            cbMaTuyenBay.DisplayMember = "TenTB";
            cbMaTuyenBay.ValueMember = "MaTB";
            cbMaTuyenBay.SelectedIndex = -1;

            // Load Tiến trình
            cbTienTrinh.DataSource = tienTrinhBL.GetTienTrinhList();
            cbTienTrinh.DisplayMember = "Ten";
            cbTienTrinh.ValueMember = "Id";
            cbTienTrinh.SelectedIndex = -1;

            // Load TuyenBay
            cbTuyenBaySearch.DataSource = tuyenBayBL.GetTuyenBayList();
            cbTuyenBaySearch.DisplayMember = "TenTB";
            cbTuyenBaySearch.ValueMember = "MaTB";
            cbTuyenBaySearch.SelectedIndex = -1;


        }

        private void ChuyenBayController_Load(object sender, EventArgs e)
        {
            ChuyenBayDisplay();
        }

        private void btnThemCB_Click(object sender, EventArgs e)
        {
            var maTB = cbMaTuyenBay.SelectedValue;
            var tienTrinh = cbTienTrinh.SelectedValue;
            var thoiGianBay = txtThoiGianBay.Text;

            if (maTB == null || tienTrinh == null || string.IsNullOrEmpty(thoiGianBay))
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin.");
                return;
            }
            DateTime ngayGioDi = datetimeThemTB.Value;
            if (chuyenBayBL.CheckChuyenBayExists(Convert.ToInt32(maTB), ngayGioDi))
            {
                MessageBox.Show("Đã tồn tại chuyến bay");
                return;
            }
            bool result = chuyenBayBL.AddChuyenBay((int)maTB, ngayGioDi, Convert.ToInt32(thoiGianBay), Convert.ToByte(tienTrinh));
            if (result)
            {
                MessageBox.Show("Thêm chuyến bay thành công.");
                ChuyenBayDisplay();
                this.Clear();
            }
            else
            {
                MessageBox.Show("Thêm chuyến bay thất bại.");
            }




        }

       

        private void Clear()
        {

            cbMaTuyenBay.SelectedIndex = -1;
            cbTienTrinh.SelectedIndex = -1;
            txtThoiGianBay.Clear();
            datetimeThemTB.Value = DateTime.Now;
            dgvChuyenBay.ClearSelection();
        }
        private void btnHuyThemCB_Click(object sender, EventArgs e)
        {
            this.Clear();

        }

        private void btnCapNhatCB_Click(object sender, EventArgs e)
        {
            if(dgvChuyenBay.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var maCB = dgvChuyenBay.CurrentRow.Cells["MaCB"].Value;
            var maTB = cbMaTuyenBay.SelectedValue;
            var tienTrinh = cbTienTrinh.SelectedValue;
            var thoiGianBay = txtThoiGianBay.Text;
            var datetime = datetimeThemTB.Value;

            chuyenBayBL.UpdateChuyenBay(Convert.ToInt32(maCB), Convert.ToInt32(maTB), datetime,
                Convert.ToInt32(thoiGianBay), Convert.ToByte(tienTrinh));
            MessageBox.Show("Cập nhật chuyến bay thành công.");
            // Update
            dgvChuyenBay.DataSource = chuyenBayBL.GetChuyenBayList();
            this.Clear();

        }

        private void btnTimKiemTB_Click(object sender, EventArgs e)
        {
            dgvChuyenBay.DataSource = chuyenBayBL.GetViewChuyenBayByMaTB(Convert.ToInt32(cbTuyenBaySearch.SelectedValue));

        }

        private void dgvChuyenBay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvChuyenBay.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                var maCB = dgvChuyenBay.Rows[e.RowIndex].Cells["MaCB"].Value;
                if (maCB != null)
                {
                    DialogResult dialogResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa chuyến {maCB} này không?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        chuyenBayBL.DeleteChuyenBay(Convert.ToInt32(maCB));
                        ChuyenBayDisplay();
                    }
                }
            }
            else
            {
                if (e.RowIndex < 0) return;
            }

            if(dgvChuyenBay.SelectedRows.Count !=0)
            {
                // Hiển thị thông tin chuyến bay được chọn
                cbMaTuyenBay.SelectedValue = dgvChuyenBay.Rows[e.RowIndex].Cells["MaTB"].Value;
                cbTienTrinh.SelectedValue = dgvChuyenBay.Rows[e.RowIndex].Cells["TienTrinhID"].Value;
                datetimeThemTB.Value = Convert.ToDateTime(dgvChuyenBay.Rows[e.RowIndex].Cells["NgayGioDi"].Value);
                txtThoiGianBay.Text = dgvChuyenBay.Rows[e.RowIndex].Cells["ThoiGianBay"].Value.ToString();
            }

        }
    }
}
