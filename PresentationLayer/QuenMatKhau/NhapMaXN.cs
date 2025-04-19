using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PresentationLayer.QuenMatKhau
{
    public partial class NhapMaXN : UserControl
    {
        public NhapMaXN()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                var parentForm = this.FindForm() as ForgotPassword;
                if (txtMaXacNhan.Text == parentForm.MaXacNhanDaGui)
                {
                    // Lấy form cha

                    if (parentForm != null)
                    {

                        // Gọi hàm load controller có sẵn trong form
                        parentForm.LoadController(new ThayDoiMatKhau());
                    }

                }
                else
                {
                    MessageBox.Show("Mã xác nhận không đúng!", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaXacNhan.Clear();
                    txtMaXacNhan.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            var parentForm = this.FindForm() as ForgotPassword;
            parentForm.Close();
        }

        private void NhapMaXN_Load(object sender, EventArgs e)
        {
            var parentForm = this.FindForm() as ForgotPassword;

            lbMail.Text = parentForm.mail;
        }
    }
}
