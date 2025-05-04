using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BusinessLayer;
using System.Windows.Forms.DataVisualization.Charting;
using System.Globalization;
using ClosedXML.Excel;
using System.Data.SqlClient;
using TransferObject;


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

        // IN BÁO CÁO //

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
            if (chart_ThongKe.ChartAreas.IndexOf("ThongKeArea") >= 0)
            {
                chart_ThongKe.ChartAreas.Remove(chart_ThongKe.ChartAreas["ThongKeArea"]);
            }
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
                    point.Label = $"{tiLeStr}%";
                    point.LegendText = tenTB;

                    series.Points.Add(point);
                }
            }

            // Thêm series vào biểu đồ
            chart_ThongKe.Series.Add(series);

            // Cấu hình tiêu đề
            chart_ThongKe.Titles.Add("Thống kê");

            ChartArea chartArea = new ChartArea("ThongKeArea");
            chartArea.Position.Auto = false;
            chartArea.Position.X = 50;
            chartArea.Position.Y = 40;
            chart_ThongKe.ChartAreas.Add(chartArea);

            // Thêm chú thích (legend)
            Legend legend = new Legend("Legend");
            legend.Docking = Docking.Right;
            chart_ThongKe.Legends.Add(legend);
        }

        private bool SendMail(DataTable dataTable)
        {
            try
            {
                string filePath = thongkeBL.ExportReportToExcelFile(dataTable);

                string fromAdd = "haonhutthach10@gmail.com";
                string toAdd = CurrentUserTO.Email;
                string subject = "Báo cáo hệ thống chuyến bay (Excel)";
                string body = "File Excel báo cáo hệ thống chuyến bay được đính kèm.";

                using (MailMessage mail = new MailMessage(fromAdd, toAdd, subject, body))
                {
                    using (Attachment attachment = new Attachment(filePath))
                    {
                        mail.Attachments.Add(attachment);

                        using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                        {
                            smtp.Credentials = new NetworkCredential(fromAdd, "wwnm rtct wnit igql");
                            smtp.EnableSsl = true;

                            smtp.Send(mail);
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gửi email: " + ex.Message);
                return false;
            }
        }

        private async void btnGuiMail_Click(object sender, EventArgs e)
        {

            DataTable dataTable = (DataTable)dgvThongKe.DataSource;

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                // Hiển thị loading form từ UI thread
                LoadingForm loadingForm = new LoadingForm();
                loadingForm.StartPosition = FormStartPosition.CenterScreen;

                loadingForm.Show();

                bool result = false;

                try
                {
                    result = await Task.Run(() => SendMail(dataTable));
                }
                finally
                {
                    // Đóng form loading an toàn từ UI thread
                    if (loadingForm.InvokeRequired)
                    {
                        loadingForm.Invoke(new Action(() => loadingForm.Close()));
                    }
                    else
                    {
                        loadingForm.Close();
                    }
                }

                if (result)
                {
                    MessageBox.Show("Gửi email kèm file Excel thành công!");
                }
                else
                {
                    MessageBox.Show("Gửi email thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để gửi mail.");
            }
        }
    }
}
