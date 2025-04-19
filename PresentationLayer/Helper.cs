using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public static class Helper
    {
        //Hàm kiểm tra dữ liệu lấy từ form nhập liệu -> Trả về INT 
        public static bool TryGetIntFromTextBox(TextBox textBox, out int value, string fieldName)
        {
            value = 0;
            string text = textBox.Text.Trim();

            if (!int.TryParse(text, out value))
            {
                MessageBox.Show($"{fieldName} phải là số nguyên.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                return false;
            }

            return true;
        }

        //Hàm kiểm tra dữ liệu từ form có rỗng hay không
        public static bool IsNotEmpty(TextBox textBox, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show($"{fieldName} không được để trống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Focus();
                return false;
            }
            return true;
        }

        // Kiểm tra tất cả các TextBox đều không rỗng
        public static bool IsAllNotEmpty(params (TextBox textBox, string fieldName)[] pairs)
        {
            foreach (var (textBox, fieldName) in pairs)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show($"{fieldName} không được để trống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox.Focus();
                    return false;
                }
            }
            return true;
        }

        //Hàm thêm cột Delete cho DataGridView
        public static void AddDeleteColumn(DataGridView dgv, string columnName = "btnDelete")
        {
            // Tránh thêm trùng nếu đã có cột
            if (!dgv.Columns.Contains(columnName))
            {
                DataGridViewImageColumn colDelete = new DataGridViewImageColumn();
                colDelete.HeaderText = "Xóa";
                colDelete.Name = "btnDelete";
                colDelete.Image = Properties.Resources.trash; // Đặt icon từ tài nguyên
                colDelete.ImageLayout = DataGridViewImageCellLayout.Zoom; // Co ảnh vừa ô
                dgv.Columns.Add(colDelete);
            }
        }

        //Hàm hủy nhập liệu
        public static void CancelInput(TextBox textname, TextBox textcontent = null, TextBox textcontent2 = null)
        {
            if (textname != null)
            {
                textname.Clear();
                textname.Focus();
            }

            if (textcontent != null)
            {
                textcontent.Clear();
            }

            if (textcontent2 != null)
            {
                textcontent2.Clear();
            }
        }

        //

    }
}

