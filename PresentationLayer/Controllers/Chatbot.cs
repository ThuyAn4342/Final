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
    public partial class Chatbot : UserControl
    {
        public Chatbot()
        {
            InitializeComponent();
        }

        private ChatKnowledgeBL bot = new ChatKnowledgeBL();

        private void AddMessage(string message, bool isUser)
        {
            Label lbl = new Label();
            lbl.Text = message;
            lbl.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lbl.AutoSize = true;
            lbl.MaximumSize = new Size(flpChatbot.Width - 60, 0); // Giới hạn chiều rộng để xuống dòng
            lbl.Padding = new Padding(5, 5, 5, 5);
            lbl.BackColor = isUser ? Color.LightGreen : Color.LightGray;
            lbl.ForeColor = Color.Black;


            // Panel chứa label
            Panel messagePanel = new Panel();
            messagePanel.AutoSize = true;
            messagePanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            messagePanel.Controls.Add(lbl);
            messagePanel.Padding = new Padding(5);
            messagePanel.BackColor = Color.Transparent;

            // Wrapper panel để căn lề trái/phải
            Panel wrapper = new Panel();
            wrapper.Size = new Size(flpChatbot.Width - 10, lbl.Height + 15);
            wrapper.Padding = new Padding(5);

            wrapper.Controls.Add(messagePanel);

            // Chèn vào wrapper và canh lề
            if (isUser)
            {
                messagePanel.Dock = DockStyle.Right;
            }
            else
            {
                messagePanel.Dock = DockStyle.Left;
            }



            // Thêm vào FlowLayoutPanel
            flpChatbot.Controls.Add(wrapper);
            flpChatbot.ScrollControlIntoView(wrapper);
        }

        private string pendingInput = null;
        private void btnSend_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.Trim();
            if (string.IsNullOrEmpty(input)) return;

            AddMessage(input, true);

            if (pendingInput != null)
            {
                // Đang chờ xác nhận từ người dùng
                if (input.ToLower() == "có")
                {
                    string response = bot.LearnNewResponse(pendingInput, true);
                    AddMessage("🤖: " + response, false);
                }
                else
                {
                    AddMessage("🤖: Đã hủy cập nhật.", false);
                }

                // Xóa trạng thái chờ
                pendingInput = null;
            }
            else if (input.StartsWith("dạy:"))
            {
                string response = bot.LearnNewResponse(input);

                AddMessage("🤖: " + response, false);

                if (response.Contains("Câu hỏi đã tồn tại"))
                {
                    // Lưu lại để chờ xác nhận
                    pendingInput = input;

                    AddMessage("🤖: Bạn có muốn cập nhật không? Gõ 'có' để xác nhận hoặc bất kỳ để hủy.", false);
                }
            }
            else
            {
                string response = bot.GetResponse(input);
                AddMessage("🤖: " + response, false);
            }

            txtInput.Clear();
            txtInput.Focus();

        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Ngăn TextBox xuống dòng
                btnSend.PerformClick();    // Gọi sự kiện click nút gửi
            }
        }
    }
}
