namespace PresentationLayer.Controllers
{
    partial class HomeController
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLichBay = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnTimKiemLB = new System.Windows.Forms.Button();
            this.dgvLichBay = new System.Windows.Forms.DataGridView();
            this.datetimeNgayBay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tabThongTinTK = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.btnHuyThaoTac = new System.Windows.Forms.Button();
            this.btnCapNhatTT = new System.Windows.Forms.Button();
            this.txtLinkAnh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbChucNang = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTenTK = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.pnBieuDo = new System.Windows.Forms.Panel();
            this.chart_Home = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabLichBay.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichBay)).BeginInit();
            this.tabThongTinTK.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.pnBieuDo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Home)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLichBay);
            this.tabControl1.Controls.Add(this.tabThongTinTK);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1279, 829);
            this.tabControl1.TabIndex = 6;
            // 
            // tabLichBay
            // 
            this.tabLichBay.Controls.Add(this.pnBieuDo);
            this.tabLichBay.Controls.Add(this.panel5);
            this.tabLichBay.ForeColor = System.Drawing.Color.DarkBlue;
            this.tabLichBay.Location = new System.Drawing.Point(4, 34);
            this.tabLichBay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabLichBay.Name = "tabLichBay";
            this.tabLichBay.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabLichBay.Size = new System.Drawing.Size(1271, 791);
            this.tabLichBay.TabIndex = 0;
            this.tabLichBay.Text = "Lịch bay";
            this.tabLichBay.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnTimKiemLB);
            this.panel5.Controls.Add(this.dgvLichBay);
            this.panel5.Controls.Add(this.datetimeNgayBay);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(3, 4);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(682, 783);
            this.panel5.TabIndex = 1;
            // 
            // btnTimKiemLB
            // 
            this.btnTimKiemLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiemLB.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnTimKiemLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemLB.ForeColor = System.Drawing.Color.White;
            this.btnTimKiemLB.Location = new System.Drawing.Point(416, 45);
            this.btnTimKiemLB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimKiemLB.Name = "btnTimKiemLB";
            this.btnTimKiemLB.Size = new System.Drawing.Size(163, 42);
            this.btnTimKiemLB.TabIndex = 77;
            this.btnTimKiemLB.Text = "Tìm kiếm";
            this.btnTimKiemLB.UseVisualStyleBackColor = false;
            this.btnTimKiemLB.Click += new System.EventHandler(this.btnTimKiemLB_Click);
            // 
            // dgvLichBay
            // 
            this.dgvLichBay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLichBay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichBay.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLichBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichBay.Location = new System.Drawing.Point(8, 190);
            this.dgvLichBay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvLichBay.Name = "dgvLichBay";
            this.dgvLichBay.RowHeadersWidth = 51;
            this.dgvLichBay.RowTemplate.Height = 24;
            this.dgvLichBay.Size = new System.Drawing.Size(662, 454);
            this.dgvLichBay.TabIndex = 4;
            // 
            // datetimeNgayBay
            // 
            this.datetimeNgayBay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datetimeNgayBay.CalendarForeColor = System.Drawing.Color.DarkBlue;
            this.datetimeNgayBay.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.datetimeNgayBay.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.datetimeNgayBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeNgayBay.Location = new System.Drawing.Point(17, 56);
            this.datetimeNgayBay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.datetimeNgayBay.Name = "datetimeNgayBay";
            this.datetimeNgayBay.Size = new System.Drawing.Size(292, 31);
            this.datetimeNgayBay.TabIndex = 1;
            this.datetimeNgayBay.Value = new System.DateTime(2025, 4, 15, 23, 29, 54, 0);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày:";
            // 
            // tabThongTinTK
            // 
            this.tabThongTinTK.Controls.Add(this.panel2);
            this.tabThongTinTK.Controls.Add(this.panel1);
            this.tabThongTinTK.ForeColor = System.Drawing.Color.DarkBlue;
            this.tabThongTinTK.Location = new System.Drawing.Point(4, 34);
            this.tabThongTinTK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabThongTinTK.Name = "tabThongTinTK";
            this.tabThongTinTK.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabThongTinTK.Size = new System.Drawing.Size(1271, 791);
            this.tabThongTinTK.TabIndex = 1;
            this.tabThongTinTK.Text = "Thông tin tài khoản";
            this.tabThongTinTK.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtMail);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnChonAnh);
            this.panel2.Controls.Add(this.btnHuyThaoTac);
            this.panel2.Controls.Add(this.btnCapNhatTT);
            this.panel2.Controls.Add(this.txtLinkAnh);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cbChucNang);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtSoDT);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtMatKhau);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtTenDN);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtHoTen);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(506, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(762, 783);
            this.panel2.TabIndex = 93;
            // 
            // txtMail
            // 
            this.txtMail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.ForeColor = System.Drawing.Color.Navy;
            this.txtMail.Location = new System.Drawing.Point(214, 474);
            this.txtMail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(454, 35);
            this.txtMail.TabIndex = 109;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(39, 478);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 29);
            this.label6.TabIndex = 108;
            this.label6.Text = "Địa chỉ mail:";
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnChonAnh.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnChonAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonAnh.ForeColor = System.Drawing.Color.White;
            this.btnChonAnh.Location = new System.Drawing.Point(672, 532);
            this.btnChonAnh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(81, 42);
            this.btnChonAnh.TabIndex = 107;
            this.btnChonAnh.Text = "Chọn";
            this.btnChonAnh.UseVisualStyleBackColor = false;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // btnHuyThaoTac
            // 
            this.btnHuyThaoTac.BackColor = System.Drawing.Color.OrangeRed;
            this.btnHuyThaoTac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyThaoTac.ForeColor = System.Drawing.Color.White;
            this.btnHuyThaoTac.Location = new System.Drawing.Point(16, 634);
            this.btnHuyThaoTac.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuyThaoTac.Name = "btnHuyThaoTac";
            this.btnHuyThaoTac.Size = new System.Drawing.Size(132, 42);
            this.btnHuyThaoTac.TabIndex = 106;
            this.btnHuyThaoTac.Text = "Hủy thao tác";
            this.btnHuyThaoTac.UseVisualStyleBackColor = false;
            this.btnHuyThaoTac.Click += new System.EventHandler(this.btnHuyThaoTac_Click);
            // 
            // btnCapNhatTT
            // 
            this.btnCapNhatTT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCapNhatTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatTT.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatTT.Location = new System.Drawing.Point(601, 645);
            this.btnCapNhatTT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCapNhatTT.Name = "btnCapNhatTT";
            this.btnCapNhatTT.Size = new System.Drawing.Size(132, 42);
            this.btnCapNhatTT.TabIndex = 105;
            this.btnCapNhatTT.Text = "Cập nhật";
            this.btnCapNhatTT.UseVisualStyleBackColor = false;
            this.btnCapNhatTT.Click += new System.EventHandler(this.btnCapNhatTT_Click);
            // 
            // txtLinkAnh
            // 
            this.txtLinkAnh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLinkAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinkAnh.ForeColor = System.Drawing.Color.Navy;
            this.txtLinkAnh.Location = new System.Drawing.Point(214, 538);
            this.txtLinkAnh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLinkAnh.Name = "txtLinkAnh";
            this.txtLinkAnh.Size = new System.Drawing.Size(454, 31);
            this.txtLinkAnh.TabIndex = 104;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(37, 538);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 29);
            this.label3.TabIndex = 103;
            this.label3.Text = "Ảnh đại diện:";
            // 
            // cbChucNang
            // 
            this.cbChucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChucNang.ForeColor = System.Drawing.Color.Navy;
            this.cbChucNang.FormattingEnabled = true;
            this.cbChucNang.Location = new System.Drawing.Point(213, 341);
            this.cbChucNang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbChucNang.Name = "cbChucNang";
            this.cbChucNang.Size = new System.Drawing.Size(146, 37);
            this.cbChucNang.TabIndex = 102;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(37, 345);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 29);
            this.label10.TabIndex = 101;
            this.label10.Text = "Chức năng:";
            // 
            // txtSoDT
            // 
            this.txtSoDT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDT.ForeColor = System.Drawing.Color.Navy;
            this.txtSoDT.Location = new System.Drawing.Point(214, 409);
            this.txtSoDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(298, 35);
            this.txtSoDT.TabIndex = 100;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(39, 412);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 29);
            this.label9.TabIndex = 99;
            this.label9.Text = "Số điện thoại:";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.Navy;
            this.txtMatKhau.Location = new System.Drawing.Point(214, 278);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(298, 35);
            this.txtMatKhau.TabIndex = 98;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(37, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 29);
            this.label8.TabIndex = 97;
            this.label8.Text = "Mật khẩu:";
            // 
            // txtTenDN
            // 
            this.txtTenDN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDN.ForeColor = System.Drawing.Color.Navy;
            this.txtTenDN.Location = new System.Drawing.Point(214, 214);
            this.txtTenDN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(298, 35);
            this.txtTenDN.TabIndex = 96;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(37, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 29);
            this.label4.TabIndex = 95;
            this.label4.Text = "Tên đăng nhập:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.ForeColor = System.Drawing.Color.Navy;
            this.txtHoTen.Location = new System.Drawing.Point(214, 148);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(285, 35);
            this.txtHoTen.TabIndex = 94;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(37, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 29);
            this.label5.TabIndex = 93;
            this.label5.Text = "Họ tên:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(322, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 32);
            this.label11.TabIndex = 92;
            this.label11.Text = "Thông tin ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbTenTK);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.picAvatar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 783);
            this.panel1.TabIndex = 92;
            // 
            // lbTenTK
            // 
            this.lbTenTK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTenTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenTK.ForeColor = System.Drawing.Color.Navy;
            this.lbTenTK.Location = new System.Drawing.Point(61, 445);
            this.lbTenTK.Name = "lbTenTK";
            this.lbTenTK.Size = new System.Drawing.Size(371, 68);
            this.lbTenTK.TabIndex = 40;
            this.lbTenTK.Text = "Admin";
            this.lbTenTK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Location = new System.Drawing.Point(496, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(3, 783);
            this.label12.TabIndex = 39;
            // 
            // picAvatar
            // 
            this.picAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picAvatar.Image = global::PresentationLayer.Properties.Resources.anh_avatar_cute_58;
            this.picAvatar.Location = new System.Drawing.Point(86, 52);
            this.picAvatar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(326, 365);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 38;
            this.picAvatar.TabStop = false;
            // 
            // pnBieuDo
            // 
            this.pnBieuDo.Controls.Add(this.chart_Home);
            this.pnBieuDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBieuDo.Location = new System.Drawing.Point(685, 4);
            this.pnBieuDo.Name = "pnBieuDo";
            this.pnBieuDo.Size = new System.Drawing.Size(583, 783);
            this.pnBieuDo.TabIndex = 2;
            // 
            // chart_Home
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_Home.ChartAreas.Add(chartArea1);
            this.chart_Home.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart_Home.Legends.Add(legend1);
            this.chart_Home.Location = new System.Drawing.Point(0, 0);
            this.chart_Home.Name = "chart_Home";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_Home.Series.Add(series1);
            this.chart_Home.Size = new System.Drawing.Size(583, 783);
            this.chart_Home.TabIndex = 0;
            this.chart_Home.Text = "chart1";
            // 
            // HomeController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HomeController";
            this.Size = new System.Drawing.Size(1279, 829);
            this.Load += new System.EventHandler(this.HomeController_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabLichBay.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichBay)).EndInit();
            this.tabThongTinTK.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.pnBieuDo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Home)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLichBay;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TabPage tabThongTinTK;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTenTK;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.DataGridView dgvLichBay;
        private System.Windows.Forms.Button btnTimKiemLB;
        private System.Windows.Forms.DateTimePicker datetimeNgayBay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Button btnHuyThaoTac;
        private System.Windows.Forms.Button btnCapNhatTT;
        private System.Windows.Forms.TextBox txtLinkAnh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbChucNang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnBieuDo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Home;
    }
}
