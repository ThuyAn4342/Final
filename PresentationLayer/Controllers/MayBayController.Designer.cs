namespace PresentationLayer.Controllers
{
    partial class MayBayController
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.nudslGhePT = new System.Windows.Forms.NumericUpDown();
            this.nudslGheH1 = new System.Windows.Forms.NumericUpDown();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnCapNhatMB = new System.Windows.Forms.Button();
            this.btnThemMB = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbLoaiMB = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenMB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDSMayBay = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudslGhePT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudslGheH1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMayBay)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::PresentationLayer.Properties.Resources.trash;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 35;
            // 
            // nudslGhePT
            // 
            this.nudslGhePT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudslGhePT.Location = new System.Drawing.Point(398, 589);
            this.nudslGhePT.Name = "nudslGhePT";
            this.nudslGhePT.Size = new System.Drawing.Size(120, 27);
            this.nudslGhePT.TabIndex = 141;
            // 
            // nudslGheH1
            // 
            this.nudslGheH1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudslGheH1.Location = new System.Drawing.Point(105, 589);
            this.nudslGheH1.Name = "nudslGheH1";
            this.nudslGheH1.Size = new System.Drawing.Size(120, 27);
            this.nudslGheH1.TabIndex = 140;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Red;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(921, 528);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(106, 34);
            this.btnHuy.TabIndex = 138;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnCapNhatMB
            // 
            this.btnCapNhatMB.BackColor = System.Drawing.Color.Blue;
            this.btnCapNhatMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatMB.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatMB.Location = new System.Drawing.Point(799, 528);
            this.btnCapNhatMB.Name = "btnCapNhatMB";
            this.btnCapNhatMB.Size = new System.Drawing.Size(106, 34);
            this.btnCapNhatMB.TabIndex = 139;
            this.btnCapNhatMB.Text = "Cập nhật";
            this.btnCapNhatMB.UseVisualStyleBackColor = false;
            this.btnCapNhatMB.Click += new System.EventHandler(this.btnCapNhatMB_Click);
            // 
            // btnThemMB
            // 
            this.btnThemMB.BackColor = System.Drawing.Color.DarkCyan;
            this.btnThemMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMB.ForeColor = System.Drawing.Color.White;
            this.btnThemMB.Location = new System.Drawing.Point(680, 528);
            this.btnThemMB.Name = "btnThemMB";
            this.btnThemMB.Size = new System.Drawing.Size(103, 34);
            this.btnThemMB.TabIndex = 137;
            this.btnThemMB.Text = "Thêm";
            this.btnThemMB.UseVisualStyleBackColor = false;
            this.btnThemMB.Click += new System.EventHandler(this.btnThemMB_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(395, 563);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 20);
            this.label10.TabIndex = 136;
            this.label10.Text = "Số lượng ghế phổ thông";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(108, 563);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 20);
            this.label9.TabIndex = 135;
            this.label9.Text = "Số lượng ghế hạng 1";
            // 
            // cbLoaiMB
            // 
            this.cbLoaiMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiMB.ForeColor = System.Drawing.Color.Navy;
            this.cbLoaiMB.FormattingEnabled = true;
            this.cbLoaiMB.Location = new System.Drawing.Point(398, 520);
            this.cbLoaiMB.Name = "cbLoaiMB";
            this.cbLoaiMB.Size = new System.Drawing.Size(214, 28);
            this.cbLoaiMB.TabIndex = 129;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(395, 494);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 134;
            this.label8.Text = "Loại máy bay";
            // 
            // txtTenMB
            // 
            this.txtTenMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMB.ForeColor = System.Drawing.Color.Navy;
            this.txtTenMB.Location = new System.Drawing.Point(105, 520);
            this.txtTenMB.Name = "txtTenMB";
            this.txtTenMB.Size = new System.Drawing.Size(214, 27);
            this.txtTenMB.TabIndex = 133;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(108, 494);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 132;
            this.label2.Text = "Tên máy bay";
            // 
            // dgvDSMayBay
            // 
            this.dgvDSMayBay.AllowUserToAddRows = false;
            this.dgvDSMayBay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSMayBay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSMayBay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSMayBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSMayBay.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSMayBay.Location = new System.Drawing.Point(106, 72);
            this.dgvDSMayBay.Name = "dgvDSMayBay";
            this.dgvDSMayBay.RowHeadersWidth = 51;
            this.dgvDSMayBay.RowTemplate.Height = 24;
            this.dgvDSMayBay.Size = new System.Drawing.Size(931, 355);
            this.dgvDSMayBay.TabIndex = 131;
            this.dgvDSMayBay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSMayBay_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(430, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 29);
            this.label1.TabIndex = 130;
            this.label1.Text = "Danh sách các máy bay";
            // 
            // MayBayController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nudslGhePT);
            this.Controls.Add(this.nudslGheH1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnCapNhatMB);
            this.Controls.Add(this.btnThemMB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbLoaiMB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTenMB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDSMayBay);
            this.Controls.Add(this.label1);
            this.Name = "MayBayController";
            this.Size = new System.Drawing.Size(1137, 663);
            this.Load += new System.EventHandler(this.MayBayController_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudslGhePT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudslGheH1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMayBay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.NumericUpDown nudslGhePT;
        private System.Windows.Forms.NumericUpDown nudslGheH1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnCapNhatMB;
        private System.Windows.Forms.Button btnThemMB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbLoaiMB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTenMB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDSMayBay;
        private System.Windows.Forms.Label label1;
    }
}
