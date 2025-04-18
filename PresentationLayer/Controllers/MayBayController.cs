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
            InputHelper.AddDeleteColumn(dgvDSMayBay);
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

        }

        private void dgvDSMayBay_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnCapNhatMB_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Cancel();
        }


    }
}
