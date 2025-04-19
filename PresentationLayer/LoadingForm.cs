using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i <= 100)
            {
                if (progressBar1.InvokeRequired)
                {
                    progressBar1.Invoke(new Action(() =>
                    {
                        progressBar1.Value = i;
                    }));
                }
                else
                {
                    progressBar1.Value = i;
                }
            }
        }
    }
}
