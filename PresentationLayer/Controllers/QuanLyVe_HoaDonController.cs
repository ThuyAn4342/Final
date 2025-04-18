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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;

namespace PresentationLayer.Controllers
{
    public partial class QuanLyVe_HoaDonController : UserControl
    {
        VeChuyenBayBL veBL = new VeChuyenBayBL();
        HoaDonBL hoadonBL = new HoaDonBL();

        public QuanLyVe_HoaDonController()
        {
            InitializeComponent();
        }

        private void btnTimKiemVe_Click(object sender, EventArgs e)
        {
            int maVe;
            if (int.TryParse(txtMaVe.Text.Trim(), out maVe))
            {
                var v = veBL.GetThongTinVeChuyenBayBL(maVe);

                if (v != null)
                {
                    lbMaHD.Text = v.maHD.ToString();
                    lbChuyenBay.Text = v.maCB.ToString();
                    lbTenHanhKhach.Text = v.tenHK;
                    lbTenGhe.Text = v.tenGhe;
                    lbNgayGioDi.Text = v.ngayGioDi.ToString("dd/MM/yyyy hh:mm");
                    lbTrangThai.Text = v.trangThai;
                    lbTuyenBay.Text = v.tuyenBay;
                    lbGiaVe.Text = v.gia.ToString("N0") + " VNĐ";
                    lbSanBayDi.Text =  v.sanBayDi;
                    lbSanBayDen.Text =  v.sanBayDen;
                    lbHang.Text =  v.hangGhe;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy vé với mã này!!");
                }
            }
            else if (txtMaVe.Text is null)
            {
                MessageBox.Show("Mời nhập mã vé để tìm kiếm!");
                txtMaVe.Focus();
            }
            else
            {
                MessageBox.Show("Mã vé không hợp lệ! Mời nhập lại.");
                txtMaVe.Focus();

            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            int maHD;
            if (int.TryParse(txtMaHD.Text.Trim(), out maHD))
            {
                var h = hoadonBL.GetThongTinHoaDon(maHD);

                if (h != null)
                {
                    lbNgayLapHD.Text = h.ngayLapHD.ToString("dd//MM/yyyy hh:mm");
                    lbNguoiLapHD.Text = h.nguoiLapHD;
                    lbPhuongThucTT.Text = h.phuongThucTT;
                    lbTongTien.Text = h.tongTien.ToString("N0") + " VNĐ";
                    dgvDSVeCuaHD.DataSource = hoadonBL.GetDSVeCuaHoaDon(maHD);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã hóa đơn này!!!");
                    txtMaHD.Focus();
                }    
            }
            else if(txtMaHD.Text is null)
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn!");
                txtMaHD.Focus();

            }   
            else
            {
                MessageBox.Show("Mã hóa đơn không hợp lệ! Vui lòng nhập lại.");
                txtMaHD.Clear();
                txtMaHD.Focus();
            }    
    }

        //hàm tạo cột trong file pdf
        private PdfPCell CreateCell(string text, iTextSharp.text.Font font)
        {
            return new PdfPCell(new Phrase(text, font))
            {
                Border = iTextSharp.text.Rectangle.NO_BORDER,
                Padding = 5
            };
        }

        //Hàm in vé theo mã vé
        public void InVe(int maVe, Document doc)
        {
            VeChuyenBayBL veBL = new VeChuyenBayBL();
            var v = veBL.GetThongTinVeChuyenBayBL(maVe);

            if (v == null)
            {
                MessageBox.Show($"Không tìm thấy thông tin vé với mã {maVe}");
                return;
            }

           

            BaseFont bf = BaseFont.CreateFont(@"C:\Windows\Fonts\arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            iTextSharp.text.Font titleFont = new iTextSharp.text.Font(bf, 14, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font labelFont = new iTextSharp.text.Font(bf, 11, iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Font boldFont = new iTextSharp.text.Font(bf, 11, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font noteFont = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);

            Paragraph title = new Paragraph("Thông tin vé máy bay", titleFont);
            title.Alignment = Element.ALIGN_CENTER;
            title.SpacingAfter = 15;
            doc.Add(title);

            PdfPTable table = new PdfPTable(2);
            table.WidthPercentage = 100;
            table.SetWidths(new float[] { 1f, 1f });

            table.AddCell(CreateCell("Mã hóa đơn: " + v.maHD, labelFont));
            table.AddCell(CreateCell("Tuyến bay: " + v.tuyenBay, boldFont));

            table.AddCell(CreateCell("Mã vé: " + v.maVe, labelFont));
            table.AddCell(CreateCell("Chuyến bay: " + v.maCB, labelFont));

            table.AddCell(CreateCell("Ngày giờ đi: " + v.ngayGioDi.ToString("dd/MM/yyyy HH:mm"), boldFont));

            table.AddCell(CreateCell("Sân bay đi: " + v.sanBayDi, boldFont));
            table.AddCell(CreateCell("Sân bay đến: " + v.sanBayDen, boldFont));

            table.AddCell(CreateCell("Hành khách: " + v.tenHK, labelFont));
            table.AddCell(CreateCell("Hạng vé: " + v.hangGhe, labelFont));

            table.AddCell(CreateCell("Ghế: " + v.tenGhe, boldFont));
            table.AddCell(CreateCell("Trạng thái: " + v.trangThai, labelFont));

            table.AddCell(CreateCell("Giá vé: " + v.gia.ToString("N0") + " VND", labelFont));
            table.AddCell(CreateCell("", labelFont));

            doc.Add(table);
            doc.Add(new Paragraph("\n"));

            Paragraph noteTitle = new Paragraph("Lưu ý:", boldFont);
            noteTitle.SpacingAfter = 5;
            doc.Add(noteTitle);

            List list = new List(List.UNORDERED);
            list.SetListSymbol("-");
            list.Add(new ListItem("Vui lòng kiểm tra kỹ thông tin cá nhân, ngày bay, hành lý và giấy tờ cần thiết trước khi khởi hành.", noteFont));
            list.Add(new ListItem("Nếu có sai sót hoặc cần thay đổi thông tin, xin liên hệ với bộ phận hỗ trợ sớm nhất để được xử lý.", noteFont));
            doc.Add(list);

            
        }

        //Hàm in hóa đơn
        public void InHoaDon(int maHD, Document doc)
        {
            HoaDonBL hdBL = new HoaDonBL();
            var hd = hdBL.GetThongTinHoaDon(maHD); // Lấy thông tin hóa đơn

            // === Font Unicode (giống InVe) ===
            BaseFont bf = BaseFont.CreateFont(@"C:\Windows\Fonts\arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            iTextSharp.text.Font titleFont = new iTextSharp.text.Font(bf, 14, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font labelFont = new iTextSharp.text.Font(bf, 11, iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Font boldFont = new iTextSharp.text.Font(bf, 11, iTextSharp.text.Font.BOLD);

            // === Tiêu đề ===
            Paragraph title = new Paragraph("THÔNG TIN HÓA ĐƠN", titleFont);
            title.Alignment = Element.ALIGN_CENTER;
            title.SpacingAfter = 20;
            doc.Add(title);

            // === Nội dung hóa đơn dạng 1 cột dọc ===
            Paragraph content = new Paragraph();
            content.SetLeading(0, 1.5f); // dòng cách 1.5

            content.Add(new Chunk("Mã hóa đơn: ", boldFont));
            content.Add(new Chunk(hd.maHD.ToString(), labelFont));
            content.Add(Chunk.NEWLINE);

            content.Add(new Chunk("Ngày lập: ", boldFont));
            content.Add(new Chunk(hd.ngayLapHD.ToString("dd/MM/yyyy HH:mm"), labelFont));
            content.Add(Chunk.NEWLINE);

            content.Add(new Chunk("Người lập: ", boldFont));
            content.Add(new Chunk(hd.nguoiLapHD, labelFont));
            content.Add(Chunk.NEWLINE);

            content.Add(new Chunk("Số lượng vé: ", boldFont));
            content.Add(new Chunk(hd.soLuongVe.ToString(), labelFont));
            content.Add(Chunk.NEWLINE);

            content.Add(new Chunk("Phương thức thanh toán: ", boldFont));
            content.Add(new Chunk(hd.phuongThucTT, labelFont));
            content.Add(Chunk.NEWLINE);

            content.Add(new Chunk("Tổng tiền: ", boldFont));
            content.Add(new Chunk(hd.tongTien.ToString("N0") + " VNĐ", labelFont));
            content.Add(Chunk.NEWLINE);

            doc.Add(content);

            // Khoảng cách sau hóa đơn
            doc.Add(new Paragraph("\n"));
        }

        //Hàm reset
        public void ResetThongTinVe()
        {
            lbMaHD.Text = "";
            lbChuyenBay.Text = "";
            lbTenHanhKhach.Text = "";
            lbTenGhe.Text = "";
            lbNgayGioDi.Text = "";
            lbTrangThai.Text = "";
            lbTuyenBay.Text = "";
            lbGiaVe.Text = "";
            lbSanBayDi.Text = "";
            lbSanBayDen.Text = "";
            lbHang.Text = "";
            txtMaVe.Clear();
            txtMaVe.Focus();
        }

        private void btnInVe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaVe.Text))
            {
                MessageBox.Show("Vui lòng nhập mã vé!");
                txtMaVe.Focus();
                return;
            }

            int maVe = Convert.ToInt32(txtMaVe.Text);

            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.Filter = "PDF files (*.pdf)|*.pdf";
                save.Title = "Chọn nơi lưu vé PDF";
                save.FileName = $"Ve_{maVe}.pdf";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Document doc = new Document(PageSize.A4, 30, 30, 30, 30);
                        PdfWriter.GetInstance(doc, new FileStream(save.FileName, FileMode.Create));
                        doc.Open();
                        InVe(maVe, doc);
                        doc.Close();
                        MessageBox.Show("Xuất vé thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi tạo file PDF: " + ex.Message);
                    }

                }
            }
        }

        private void btnInTatCaVe_Click(object sender, EventArgs e)
        {
            if (dgvDSVeCuaHD.Rows.Count == 0)
            {
                MessageBox.Show("Không có vé để in.");
                return;
            }

            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.Filter = "PDF files (*.pdf)|*.pdf";
                save.FileName = "TatCaVe.pdf";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Document doc = new Document(PageSize.A4, 30, 30, 30, 30);
                        PdfWriter.GetInstance(doc, new FileStream(save.FileName, FileMode.Create));
                        doc.Open();

                        // In hóa đơn đầu tiên (lấy từ dòng đầu)
                        int maHD = Convert.ToInt32(dgvDSVeCuaHD.Rows[0].Cells["MaHD"].Value);
                        InHoaDon(maHD, doc);  // -> bạn sẽ định nghĩa thêm hàm này
                        LineSeparator line = new LineSeparator(1f, 100f, BaseColor.GRAY, Element.ALIGN_CENTER, -2);
                        doc.Add(new Chunk(line));
                        doc.Add(new Paragraph("\n"));

                        // In từng vé
                        foreach (DataGridViewRow row in dgvDSVeCuaHD.Rows)
                        {
                            if (row.IsNewRow) continue;
                            int maVe = Convert.ToInt32(row.Cells["maVeHD"].Value);
                            InVe(maVe, doc);
                            doc.Add(new Chunk(line));
                            doc.Add(new Paragraph("\n"));


                        }

                        doc.Close();
                        MessageBox.Show("Đã in tất cả vé và hóa đơn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi tạo file PDF: " + ex.Message);
                    }
                }
            }
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHD.Text))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn.");
                return;
            }

            int maHD = Convert.ToInt32(txtMaHD.Text);
            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.Filter = "PDF files (*.pdf)|*.pdf";
                save.FileName = "HoaDon.pdf";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Document doc = new Document(PageSize.A4, 30, 30, 30, 30);
                        PdfWriter.GetInstance(doc, new FileStream(save.FileName, FileMode.Create));
                        doc.Open();
                        InHoaDon(maHD, doc);
                        doc.Close();
                        MessageBox.Show("Đã in hóa đơn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi tạo file PDF: " + ex.Message);
                    }
                }
            }
        }

        private void dgvDSVeCuaHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDSVeCuaHD.Columns[e.ColumnIndex].Name == "inVeHD" && e.RowIndex >= 0)
            {
                int maVe = Convert.ToInt32(dgvDSVeCuaHD.Rows[e.RowIndex].Cells["maVeHD"].Value);

                using (SaveFileDialog save = new SaveFileDialog())
                {
                    save.Filter = "PDF files (*.pdf)|*.pdf";
                    save.FileName = "Ve_" + maVe + ".pdf";

                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            Document doc = new Document(PageSize.A4, 30, 30, 30, 30);
                            PdfWriter.GetInstance(doc, new FileStream(save.FileName, FileMode.Create));
                            doc.Open();
                            InVe(maVe, doc);
                            doc.Close();
                            MessageBox.Show("Đã in vé thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi tạo file PDF: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void btnHuyVe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaVe.Text))
            {
                MessageBox.Show("Vui lòng nhập mã vé cần hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maVe = Convert.ToInt32(txtMaVe.Text);

            // Lấy thông tin vé
            var ve = veBL.GetThongTinVeChuyenBayBL(maVe);

            if (ve == null)
            {
                MessageBox.Show("Không tìm thấy vé với mã đã nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Xác nhận trước khi hủy
            DialogResult result = MessageBox.Show($"Bạn có chắc muốn hủy vé {maVe} không?", "Xác nhận hủy vé",
                                                  MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result != DialogResult.OK)
            {
                return; // Người dùng chọn Cancel
            }

            // Tính toán thông tin mới cho hóa đơn
            int maHD = ve.maHD;
            double giaVe = ve.gia;
            var hoadon = hoadonBL.GetThongTinHoaDon(maHD);

            // Giảm số lượng vé (giả sử bạn có phương thức lấy số lượng vé hiện tại trong hóa đơn)
            int soLuongVeHienTai = hoadon.soLuongVe;
            int soLuongMoi = soLuongVeHienTai - 1;
            double tongTienMoi = hoadon.tongTien - giaVe; 

            if(soLuongMoi < 1)
            {
                bool xoave = veBL.DeleteVeCB(maVe);
                bool xoaHD = hoadonBL.DeleteHoaDon(maHD);
                if (xoaHD && xoave)
                {
                    ResetThongTinVe();
                    MessageBox.Show("Hủy vé thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Hủy vé thất bại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }   
            else
            {

                // Cập nhật hóa đơn
                bool capNhatHD = hoadonBL.UpdateHoaDon(maHD, soLuongMoi, tongTienMoi);

                if (!capNhatHD)
                {
                    MessageBox.Show("Cập nhật hóa đơn thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Xóa vé
                bool xoaVe = veBL.DeleteVeCB(maVe);

                if (xoaVe)
                {
                    ResetThongTinVe();
                    MessageBox.Show("Hủy vé thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Làm mới lại giao diện nếu cần, ví dụ: load lại danh sách vé, xóa thông tin vé đang chọn, v.v.
                }
                else
                {
                    MessageBox.Show("Hủy vé thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }    

            
        }
    }
}
