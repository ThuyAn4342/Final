namespace PresentationLayer.Controllers
{
    partial class QuyDinhController
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHuyThemQD = new System.Windows.Forms.Button();
            this.txtNoiDungQD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenQuyDinh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCapNhatQD = new System.Windows.Forms.Button();
            this.dgvQuyDinh = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuyDinh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuyThemQD
            // 
            this.btnHuyThemQD.BackColor = System.Drawing.Color.Red;
            this.btnHuyThemQD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyThemQD.ForeColor = System.Drawing.Color.White;
            this.btnHuyThemQD.Location = new System.Drawing.Point(559, 558);
            this.btnHuyThemQD.Name = "btnHuyThemQD";
            this.btnHuyThemQD.Size = new System.Drawing.Size(135, 54);
            this.btnHuyThemQD.TabIndex = 123;
            this.btnHuyThemQD.Text = "Hủy";
            this.btnHuyThemQD.UseVisualStyleBackColor = false;
            this.btnHuyThemQD.Click += new System.EventHandler(this.btnHuyThemQD_Click);
            // 
            // txtNoiDungQD
            // 
            this.txtNoiDungQD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoiDungQD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDungQD.ForeColor = System.Drawing.Color.Navy;
            this.txtNoiDungQD.Location = new System.Drawing.Point(794, 476);
            this.txtNoiDungQD.Name = "txtNoiDungQD";
            this.txtNoiDungQD.Size = new System.Drawing.Size(245, 30);
            this.txtNoiDungQD.TabIndex = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(470, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 29);
            this.label1.TabIndex = 119;
            this.label1.Text = "Quản lý quy định";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(170, 479);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 25);
            this.label5.TabIndex = 117;
            this.label5.Text = "Tên quy định:";
            // 
            // txtTenQuyDinh
            // 
            this.txtTenQuyDinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenQuyDinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenQuyDinh.ForeColor = System.Drawing.Color.Navy;
            this.txtTenQuyDinh.Location = new System.Drawing.Point(319, 479);
            this.txtTenQuyDinh.Name = "txtTenQuyDinh";
            this.txtTenQuyDinh.Size = new System.Drawing.Size(236, 30);
            this.txtTenQuyDinh.TabIndex = 116;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(679, 476);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 115;
            this.label6.Text = "Nội dung:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(470, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 29);
            this.label7.TabIndex = 114;
            this.label7.Text = "Thêm quy định";
            // 
            // btnCapNhatQD
            // 
            this.btnCapNhatQD.BackColor = System.Drawing.Color.Blue;
            this.btnCapNhatQD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatQD.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatQD.Location = new System.Drawing.Point(385, 558);
            this.btnCapNhatQD.Name = "btnCapNhatQD";
            this.btnCapNhatQD.Size = new System.Drawing.Size(152, 54);
            this.btnCapNhatQD.TabIndex = 126;
            this.btnCapNhatQD.Text = "Cập nhật";
            this.btnCapNhatQD.UseVisualStyleBackColor = false;
            this.btnCapNhatQD.Click += new System.EventHandler(this.btnCapNhatQD_Click);
            // 
            // dgvQuyDinh
            // 
            this.dgvQuyDinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQuyDinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuyDinh.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvQuyDinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuyDinh.Location = new System.Drawing.Point(99, 57);
            this.dgvQuyDinh.Name = "dgvQuyDinh";
            this.dgvQuyDinh.RowHeadersWidth = 51;
            this.dgvQuyDinh.RowTemplate.Height = 24;
            this.dgvQuyDinh.Size = new System.Drawing.Size(923, 307);
            this.dgvQuyDinh.TabIndex = 113;
            this.dgvQuyDinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuyDinh_CellClick);
            // 
            // QuyDinhController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCapNhatQD);
            this.Controls.Add(this.btnHuyThemQD);
            this.Controls.Add(this.txtNoiDungQD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTenQuyDinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvQuyDinh);
            this.Name = "QuyDinhController";
            this.Size = new System.Drawing.Size(1137, 663);
            this.Load += new System.EventHandler(this.QuyDinhController_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuyDinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuyThemQD;
        private System.Windows.Forms.TextBox txtNoiDungQD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenQuyDinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCapNhatQD;
        private System.Windows.Forms.DataGridView dgvQuyDinh;
    }
}
