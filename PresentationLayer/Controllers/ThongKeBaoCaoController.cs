using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BusinessLayer;
using System.Windows.Forms.DataVisualization.Charting;
using System.Globalization;
using ClosedXML.Excel;
using System.Data.SqlClient;

namespace PresentationLayer.Controllers
{
    public partial class ThongKeBaoCaoController : UserControl
    {
        ThongKeBL thongkeBL = new ThongKeBL();
        VeChuyenBayBL veCBBL = new VeChuyenBayBL();
        ChuyenBayBL chuyenbayBL = new ChuyenBayBL();
        public ThongKeBaoCaoController()
        {
            InitializeComponent();
        }

        public void ResetThongKe()
        {
            int namHienTai = DateTime.Now.Year;
            lbSoVeDaBan.Text = veCBBL.GetTongSoVe(0, namHienTai).ToString();
            lbTongCB.Text = chuyenbayBL.GetSoLuongChuyenBay(0, namHienTai).ToString();
            txtNamThongKe.Text = namHienTai.ToString(); // năm hiện tại DateTime.Now.Year
            txtThangThongKe.Clear();
            DataTable dt = thongkeBL.GetThongKeTheoThangNam(0, namHienTai);
            dgvThongKe.DataSource = dt;
            double s = thongkeBL.TongDoanhThu(dt);
            lbTongDoanhThu.Text = "   " + s.ToString("N0") + " VNĐ";
        }
        private void ThongKeBaoCaoController_Load(object sender, EventArgs e)
        {
            ResetThongKe();
            DrawChart((DataTable)dgvThongKe.DataSource);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            int nam;
            int thang;
         

            if (int.TryParse(txtNamThongKe.Text,out nam) )
            {
               if(nam == 0)
                {
                    MessageBox.Show("Vui lòng nhập giá trị Năm hợp lệ để thống kê!","Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ResetThongKe();
                    txtThangThongKe.Focus();
               }
               else
                {
                    if (string.IsNullOrEmpty(txtThangThongKe.Text))
                    {
                        thang = 0;
                    }
                    else
                    {
                        if (!int.TryParse(txtThangThongKe.Text, out thang))
                        {
                            MessageBox.Show("Vui lòng nhập giá trị Tháng hợp lệ để thống kê!", "Thông báo", 
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            ResetThongKe();
                            txtThangThongKe.Focus();
                        }
                    }
                    lbSoVeDaBan.Text = veCBBL.GetTongSoVe(thang, nam).ToString();
                    lbTongCB.Text = chuyenbayBL.GetSoLuongChuyenBay(thang, nam).ToString();
                    txtNamThongKe.Text = nam.ToString();
                    txtThangThongKe.Text = thang.ToString();
                    try
                    {
                        DataTable dt = thongkeBL.GetThongKeTheoThangNam(thang, nam);
                        dgvThongKe.DataSource = dt;
                        if (dt != null)
                        {
                            double s = thongkeBL.TongDoanhThu(dt);
                            lbTongDoanhThu.Text = "    " + s.ToString("N0") + " VNĐ";
                        }
                        else
                        {
                            MessageBox.Show("Không có dữ liệu cho tháng " + thang.ToString() + " năm " + nam.ToString(), "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ResetThongKe();
                        }
                    }
                    catch (SqlException ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                }

            }
            else
            {
                MessageBox.Show("Vui lòng nhập giá trị hợp lệ để thống kê!!!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetThongKe();
                txtThangThongKe.Focus();
            }
            DrawChart((DataTable)dgvThongKe.DataSource);


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        /// IN BÁO CÁO //

        private void btnInBC_Click(object sender, EventArgs e)
        {
            DataTable dataTable = (DataTable)dgvThongKe.DataSource;
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                // Gọi hàm in báo cáo từ lớp BusinessLayer
                this.InBaoCao(dataTable);
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để in báo cáo.");
            }
        }

        public void InBaoCao(DataTable dataTable)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
            saveFileDialog.FileName = "BaoCaoThongKe.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("BaoCao");

                    // Ghi header
                    for (int col = 0; col < dataTable.Columns.Count; col++)
                    {
                        worksheet.Cell(1, col + 1).Value = dataTable.Columns[col].ColumnName;
                    }

                    // Ghi dữ liệu
                    for (int row = 0; row < dataTable.Rows.Count; row++)
                    {
                        for (int col = 0; col < dataTable.Columns.Count; col++)
                        {
                            worksheet.Cell(row + 2, col + 1).Value = dataTable.Rows[row][col].ToString();
                        }
                    }

                    // Tự động điều chỉnh độ rộng cột
                    worksheet.Columns().AdjustToContents();

                    // Lưu file
                    workbook.SaveAs(saveFileDialog.FileName);
                }

                MessageBox.Show("In báo cáo Excel thành công!");
            }

        }

        //// BIỂU ĐỒ THONG KÊ ////
        public void DrawChart(DataTable dataTable)
        {
            // Xóa dữ liệu cũ
            chart_ThongKe.Series.Clear();
            chart_ThongKe.Titles.Clear();
            chart_ThongKe.Legends.Clear();

            // Tạo biểu đồ dạng Pie
            Series series = new Series("ThongKe");
            series.ChartType = SeriesChartType.Pie;
            series["PieLabelStyle"] = "Outside"; // Hiển thị label bên ngoài
            series.BorderColor = System.Drawing.Color.Black; // Viền để phân biệt

            foreach (DataRow row in dataTable.Rows)
            {
                string tenTB = row["tenTB"].ToString();
                string tiLeStr = row["tiLe"].ToString().Replace("%", "").Trim();

                // Dùng CultureInfo để đảm bảo parse đúng định dạng
                if (double.TryParse(tiLeStr, NumberStyles.Any, CultureInfo.InvariantCulture, out double tiLe))
                {
                    // Thêm điểm dữ liệu vào series
                    DataPoint point = new DataPoint();
                    point.SetValueY(tiLe);
                    point.Label = $"{tenTB}: {tiLe}%";
                    point.LegendText = tenTB;

                    series.Points.Add(point);
                }
            }

            // Thêm series vào biểu đồ
            chart_ThongKe.Series.Add(series);

            // Cấu hình tiêu đề
            chart_ThongKe.Titles.Add("Thống kê");

            // Cấu hình biểu đồ 3D
            if (chart_ThongKe.ChartAreas.Count == 0)
            {
                chart_ThongKe.ChartAreas.Add(new ChartArea("MainArea"));
            }
            chart_ThongKe.ChartAreas[0].Area3DStyle.Enable3D = true;

            // Thêm chú thích (legend)
            Legend legend = new Legend("Legend");
            legend.Docking = Docking.Right;
            chart_ThongKe.Legends.Add(legend);
        }
    }
}
