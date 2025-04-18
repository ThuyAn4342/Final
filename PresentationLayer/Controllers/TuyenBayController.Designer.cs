namespace PresentationLayer.Controllers
{
    partial class TuyenBayController
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
            this.tabThemSBTG = new System.Windows.Forms.TabPage();
            this.dgvSBTrungGian = new System.Windows.Forms.DataGridView();
            this.Delete_TrungGian = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnThemSBTG = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbMaTB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMaSB = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtThoiGianDung = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabDanhSachTB = new System.Windows.Forms.TabPage();
            this.txtGiaTB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbDiemDen = new System.Windows.Forms.ComboBox();
            this.cbDiemDi = new System.Windows.Forms.ComboBox();
            this.btnCapNhatTB = new System.Windows.Forms.Button();
            this.btnHuyThemTB = new System.Windows.Forms.Button();
            this.btnThemTB = new System.Windows.Forms.Button();
            this.cbSanBayDen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSanBayDi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvTuyenBay = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnTimKiemTB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabTuyenBay = new System.Windows.Forms.TabControl();
            this.tabThemSBTG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSBTrungGian)).BeginInit();
            this.tabDanhSachTB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuyenBay)).BeginInit();
            this.tabTuyenBay.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabThemSBTG
            // 
            this.tabThemSBTG.Controls.Add(this.dgvSBTrungGian);
            this.tabThemSBTG.Controls.Add(this.btnThemSBTG);
            this.tabThemSBTG.Controls.Add(this.label9);
            this.tabThemSBTG.Controls.Add(this.cbMaTB);
            this.tabThemSBTG.Controls.Add(this.label3);
            this.tabThemSBTG.Controls.Add(this.cbMaSB);
            this.tabThemSBTG.Controls.Add(this.label10);
            this.tabThemSBTG.Controls.Add(this.txtThoiGianDung);
            this.tabThemSBTG.Controls.Add(this.label8);
            this.tabThemSBTG.Controls.Add(this.label11);
            this.tabThemSBTG.Location = new System.Drawing.Point(4, 25);
            this.tabThemSBTG.Name = "tabThemSBTG";
            this.tabThemSBTG.Padding = new System.Windows.Forms.Padding(3);
            this.tabThemSBTG.Size = new System.Drawing.Size(1123, 619);
            this.tabThemSBTG.TabIndex = 1;
            this.tabThemSBTG.Text = "Thêm sân bay trung gian";
            this.tabThemSBTG.UseVisualStyleBackColor = true;
            // 
            // dgvSBTrungGian
            // 
            this.dgvSBTrungGian.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSBTrungGian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSBTrungGian.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete_TrungGian});
            this.dgvSBTrungGian.Location = new System.Drawing.Point(16, 172);
            this.dgvSBTrungGian.Name = "dgvSBTrungGian";
            this.dgvSBTrungGian.RowHeadersWidth = 51;
            this.dgvSBTrungGian.RowTemplate.Height = 24;
            this.dgvSBTrungGian.Size = new System.Drawing.Size(895, 360);
            this.dgvSBTrungGian.TabIndex = 93;
            // 
            // Delete_TrungGian
            // 
            this.Delete_TrungGian.HeaderText = "Delete_TrungGian";
            this.Delete_TrungGian.MinimumWidth = 6;
            this.Delete_TrungGian.Name = "Delete_TrungGian";
            // 
            // btnThemSBTG
            // 
            this.btnThemSBTG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThemSBTG.ForeColor = System.Drawing.Color.White;
            this.btnThemSBTG.Location = new System.Drawing.Point(761, 51);
            this.btnThemSBTG.Name = "btnThemSBTG";
            this.btnThemSBTG.Size = new System.Drawing.Size(117, 33);
            this.btnThemSBTG.TabIndex = 92;
            this.btnThemSBTG.Text = "Thêm";
            this.btnThemSBTG.UseVisualStyleBackColor = false;
            this.btnThemSBTG.Click += new System.EventHandler(this.btnThemSBTG_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(326, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(277, 25);
            this.label9.TabIndex = 91;
            this.label9.Text = "Danh sách sân bay trung gian:";
            // 
            // cbMaTB
            // 
            this.cbMaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaTB.ForeColor = System.Drawing.Color.Navy;
            this.cbMaTB.FormattingEnabled = true;
            this.cbMaTB.Location = new System.Drawing.Point(184, 56);
            this.cbMaTB.Name = "cbMaTB";
            this.cbMaTB.Size = new System.Drawing.Size(187, 28);
            this.cbMaTB.TabIndex = 90;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(434, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 22);
            this.label3.TabIndex = 89;
            this.label3.Text = "Thời gian dừng:";
            // 
            // cbMaSB
            // 
            this.cbMaSB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaSB.ForeColor = System.Drawing.Color.Navy;
            this.cbMaSB.FormattingEnabled = true;
            this.cbMaSB.Location = new System.Drawing.Point(175, 92);
            this.cbMaSB.Name = "cbMaSB";
            this.cbMaSB.Size = new System.Drawing.Size(187, 28);
            this.cbMaSB.TabIndex = 88;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(45, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 22);
            this.label10.TabIndex = 87;
            this.label10.Text = "Mã tuyến bay:";
            // 
            // txtThoiGianDung
            // 
            this.txtThoiGianDung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtThoiGianDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThoiGianDung.ForeColor = System.Drawing.Color.Navy;
            this.txtThoiGianDung.Location = new System.Drawing.Point(588, 57);
            this.txtThoiGianDung.Name = "txtThoiGianDung";
            this.txtThoiGianDung.Size = new System.Drawing.Size(64, 27);
            this.txtThoiGianDung.TabIndex = 86;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(45, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 22);
            this.label8.TabIndex = 85;
            this.label8.Text = "Mã sân bay:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(350, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(234, 25);
            this.label11.TabIndex = 84;
            this.label11.Text = "Thêm sân bay trung gian:";
            // 
            // tabDanhSachTB
            // 
            this.tabDanhSachTB.Controls.Add(this.txtGiaTB);
            this.tabDanhSachTB.Controls.Add(this.label12);
            this.tabDanhSachTB.Controls.Add(this.cbDiemDen);
            this.tabDanhSachTB.Controls.Add(this.cbDiemDi);
            this.tabDanhSachTB.Controls.Add(this.btnCapNhatTB);
            this.tabDanhSachTB.Controls.Add(this.btnHuyThemTB);
            this.tabDanhSachTB.Controls.Add(this.btnThemTB);
            this.tabDanhSachTB.Controls.Add(this.cbSanBayDen);
            this.tabDanhSachTB.Controls.Add(this.label4);
            this.tabDanhSachTB.Controls.Add(this.cbSanBayDi);
            this.tabDanhSachTB.Controls.Add(this.label5);
            this.tabDanhSachTB.Controls.Add(this.txtTenTB);
            this.tabDanhSachTB.Controls.Add(this.label6);
            this.tabDanhSachTB.Controls.Add(this.label7);
            this.tabDanhSachTB.Controls.Add(this.dgvTuyenBay);
            this.tabDanhSachTB.Controls.Add(this.btnTimKiemTB);
            this.tabDanhSachTB.Controls.Add(this.label1);
            this.tabDanhSachTB.Controls.Add(this.label2);
            this.tabDanhSachTB.Location = new System.Drawing.Point(4, 25);
            this.tabDanhSachTB.Name = "tabDanhSachTB";
            this.tabDanhSachTB.Padding = new System.Windows.Forms.Padding(3);
            this.tabDanhSachTB.Size = new System.Drawing.Size(1123, 619);
            this.tabDanhSachTB.TabIndex = 0;
            this.tabDanhSachTB.Text = "Danh sách tuyến bay";
            this.tabDanhSachTB.UseVisualStyleBackColor = true;
            // 
            // txtGiaTB
            // 
            this.txtGiaTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGiaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTB.ForeColor = System.Drawing.Color.Navy;
            this.txtGiaTB.Location = new System.Drawing.Point(702, 442);
            this.txtGiaTB.Name = "txtGiaTB";
            this.txtGiaTB.Size = new System.Drawing.Size(193, 30);
            this.txtGiaTB.TabIndex = 130;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(548, 442);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 25);
            this.label12.TabIndex = 129;
            this.label12.Text = "Giá trung bình:";
            // 
            // cbDiemDen
            // 
            this.cbDiemDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDiemDen.FormattingEnabled = true;
            this.cbDiemDen.Location = new System.Drawing.Point(641, 22);
            this.cbDiemDen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDiemDen.Name = "cbDiemDen";
            this.cbDiemDen.Size = new System.Drawing.Size(220, 33);
            this.cbDiemDen.TabIndex = 128;
            // 
            // cbDiemDi
            // 
            this.cbDiemDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDiemDi.FormattingEnabled = true;
            this.cbDiemDi.Location = new System.Drawing.Point(139, 22);
            this.cbDiemDi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDiemDi.Name = "cbDiemDi";
            this.cbDiemDi.Size = new System.Drawing.Size(209, 33);
            this.cbDiemDi.TabIndex = 127;
            // 
            // btnCapNhatTB
            // 
            this.btnCapNhatTB.BackColor = System.Drawing.Color.Blue;
            this.btnCapNhatTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatTB.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatTB.Location = new System.Drawing.Point(496, 563);
            this.btnCapNhatTB.Name = "btnCapNhatTB";
            this.btnCapNhatTB.Size = new System.Drawing.Size(134, 34);
            this.btnCapNhatTB.TabIndex = 126;
            this.btnCapNhatTB.Text = "Cập nhật";
            this.btnCapNhatTB.UseVisualStyleBackColor = false;
            this.btnCapNhatTB.Click += new System.EventHandler(this.btnCapNhatTB_Click);
            // 
            // btnHuyThemTB
            // 
            this.btnHuyThemTB.BackColor = System.Drawing.Color.Red;
            this.btnHuyThemTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyThemTB.ForeColor = System.Drawing.Color.White;
            this.btnHuyThemTB.Location = new System.Drawing.Point(64, 563);
            this.btnHuyThemTB.Name = "btnHuyThemTB";
            this.btnHuyThemTB.Size = new System.Drawing.Size(134, 34);
            this.btnHuyThemTB.TabIndex = 113;
            this.btnHuyThemTB.Text = "Hủy";
            this.btnHuyThemTB.UseVisualStyleBackColor = false;
            this.btnHuyThemTB.Click += new System.EventHandler(this.btnHuyThemTB_Click);
            // 
            // btnThemTB
            // 
            this.btnThemTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThemTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTB.ForeColor = System.Drawing.Color.White;
            this.btnThemTB.Location = new System.Drawing.Point(936, 563);
            this.btnThemTB.Name = "btnThemTB";
            this.btnThemTB.Size = new System.Drawing.Size(134, 34);
            this.btnThemTB.TabIndex = 98;
            this.btnThemTB.Text = "Thêm";
            this.btnThemTB.UseVisualStyleBackColor = false;
            this.btnThemTB.Click += new System.EventHandler(this.btnThemTB_Click);
            // 
            // cbSanBayDen
            // 
            this.cbSanBayDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSanBayDen.ForeColor = System.Drawing.Color.Navy;
            this.cbSanBayDen.FormattingEnabled = true;
            this.cbSanBayDen.Location = new System.Drawing.Point(702, 482);
            this.cbSanBayDen.Name = "cbSanBayDen";
            this.cbSanBayDen.Size = new System.Drawing.Size(121, 33);
            this.cbSanBayDen.TabIndex = 97;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(551, 485);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 96;
            this.label4.Text = "Sân bay đi:";
            // 
            // cbSanBayDi
            // 
            this.cbSanBayDi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSanBayDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSanBayDi.ForeColor = System.Drawing.Color.Navy;
            this.cbSanBayDi.FormattingEnabled = true;
            this.cbSanBayDi.Location = new System.Drawing.Point(204, 501);
            this.cbSanBayDi.Name = "cbSanBayDi";
            this.cbSanBayDi.Size = new System.Drawing.Size(121, 28);
            this.cbSanBayDi.TabIndex = 95;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(60, 456);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 94;
            this.label5.Text = "Tên tuyến bay:";
            // 
            // txtTenTB
            // 
            this.txtTenTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTB.ForeColor = System.Drawing.Color.Navy;
            this.txtTenTB.Location = new System.Drawing.Point(204, 455);
            this.txtTenTB.Name = "txtTenTB";
            this.txtTenTB.Size = new System.Drawing.Size(249, 27);
            this.txtTenTB.TabIndex = 93;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(60, 502);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 92;
            this.label6.Text = "Sân bay đi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(465, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 29);
            this.label7.TabIndex = 91;
            this.label7.Text = "Thêm tuyến bay:";
            // 
            // dgvTuyenBay
            // 
            this.dgvTuyenBay.AllowUserToAddRows = false;
            this.dgvTuyenBay.AllowUserToDeleteRows = false;
            this.dgvTuyenBay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTuyenBay.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTuyenBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTuyenBay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete});
            this.dgvTuyenBay.Location = new System.Drawing.Point(87, 67);
            this.dgvTuyenBay.Name = "dgvTuyenBay";
            this.dgvTuyenBay.ReadOnly = true;
            this.dgvTuyenBay.RowHeadersWidth = 51;
            this.dgvTuyenBay.RowTemplate.Height = 24;
            this.dgvTuyenBay.Size = new System.Drawing.Size(927, 314);
            this.dgvTuyenBay.TabIndex = 0;
            this.dgvTuyenBay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTuyenBay_CellClick);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 8;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            // 
            // btnTimKiemTB
            // 
            this.btnTimKiemTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTimKiemTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemTB.ForeColor = System.Drawing.Color.White;
            this.btnTimKiemTB.Location = new System.Drawing.Point(953, 20);
            this.btnTimKiemTB.Name = "btnTimKiemTB";
            this.btnTimKiemTB.Size = new System.Drawing.Size(140, 39);
            this.btnTimKiemTB.TabIndex = 88;
            this.btnTimKiemTB.Text = "Tìm kiếm";
            this.btnTimKiemTB.UseVisualStyleBackColor = false;
            this.btnTimKiemTB.Click += new System.EventHandler(this.btnTimKiemTB_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(36, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 74;
            this.label1.Text = "Điểm đi:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(527, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 76;
            this.label2.Text = "Điểm đến:";
            // 
            // tabTuyenBay
            // 
            this.tabTuyenBay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabTuyenBay.Controls.Add(this.tabDanhSachTB);
            this.tabTuyenBay.Controls.Add(this.tabThemSBTG);
            this.tabTuyenBay.Location = new System.Drawing.Point(3, 12);
            this.tabTuyenBay.Name = "tabTuyenBay";
            this.tabTuyenBay.SelectedIndex = 0;
            this.tabTuyenBay.Size = new System.Drawing.Size(1131, 648);
            this.tabTuyenBay.TabIndex = 89;
            // 
            // TuyenBayController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabTuyenBay);
            this.Name = "TuyenBayController";
            this.Size = new System.Drawing.Size(1137, 663);
            this.Load += new System.EventHandler(this.TuyenBayController_Load);
            this.tabThemSBTG.ResumeLayout(false);
            this.tabThemSBTG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSBTrungGian)).EndInit();
            this.tabDanhSachTB.ResumeLayout(false);
            this.tabDanhSachTB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuyenBay)).EndInit();
            this.tabTuyenBay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabThemSBTG;
        private System.Windows.Forms.ComboBox cbMaTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMaSB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtThoiGianDung;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabDanhSachTB;
        private System.Windows.Forms.Button btnThemTB;
        private System.Windows.Forms.ComboBox cbSanBayDen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSanBayDi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvTuyenBay;
        private System.Windows.Forms.Button btnTimKiemTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabTuyenBay;
        private System.Windows.Forms.Button btnThemSBTG;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvSBTrungGian;
        private System.Windows.Forms.Button btnHuyThemTB;
        private System.Windows.Forms.Button btnCapNhatTB;
        private System.Windows.Forms.ComboBox cbDiemDen;
        private System.Windows.Forms.ComboBox cbDiemDi;
        private System.Windows.Forms.TextBox txtGiaTB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn Delete_TrungGian;
    }
}
