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
            this.tabThemSBTG.Location = new System.Drawing.Point(4, 29);
            this.tabThemSBTG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabThemSBTG.Name = "tabThemSBTG";
            this.tabThemSBTG.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabThemSBTG.Size = new System.Drawing.Size(1264, 777);
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
            this.dgvSBTrungGian.Location = new System.Drawing.Point(18, 215);
            this.dgvSBTrungGian.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSBTrungGian.Name = "dgvSBTrungGian";
            this.dgvSBTrungGian.RowHeadersWidth = 51;
            this.dgvSBTrungGian.RowTemplate.Height = 24;
            this.dgvSBTrungGian.Size = new System.Drawing.Size(1007, 450);
            this.dgvSBTrungGian.TabIndex = 93;
            this.dgvSBTrungGian.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSBTrungGian_CellClick);
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
            this.btnThemSBTG.Location = new System.Drawing.Point(856, 64);
            this.btnThemSBTG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemSBTG.Name = "btnThemSBTG";
            this.btnThemSBTG.Size = new System.Drawing.Size(132, 41);
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
            this.label9.Location = new System.Drawing.Point(367, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(331, 29);
            this.label9.TabIndex = 91;
            this.label9.Text = "Danh sách sân bay trung gian:";
            // 
            // cbMaTB
            // 
            this.cbMaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaTB.ForeColor = System.Drawing.Color.Navy;
            this.cbMaTB.FormattingEnabled = true;
            this.cbMaTB.Location = new System.Drawing.Point(207, 70);
            this.cbMaTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbMaTB.Name = "cbMaTB";
            this.cbMaTB.Size = new System.Drawing.Size(210, 33);
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
            this.label3.Location = new System.Drawing.Point(488, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 26);
            this.label3.TabIndex = 89;
            this.label3.Text = "Thời gian dừng:";
            // 
            // cbMaSB
            // 
            this.cbMaSB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaSB.ForeColor = System.Drawing.Color.Navy;
            this.cbMaSB.FormattingEnabled = true;
            this.cbMaSB.Location = new System.Drawing.Point(197, 115);
            this.cbMaSB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbMaSB.Name = "cbMaSB";
            this.cbMaSB.Size = new System.Drawing.Size(210, 33);
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
            this.label10.Location = new System.Drawing.Point(51, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 26);
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
            this.txtThoiGianDung.Location = new System.Drawing.Point(662, 71);
            this.txtThoiGianDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtThoiGianDung.Name = "txtThoiGianDung";
            this.txtThoiGianDung.Size = new System.Drawing.Size(72, 31);
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
            this.label8.Location = new System.Drawing.Point(51, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 26);
            this.label8.TabIndex = 85;
            this.label8.Text = "Mã sân bay:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(394, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(282, 29);
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
            this.tabDanhSachTB.Location = new System.Drawing.Point(4, 29);
            this.tabDanhSachTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabDanhSachTB.Name = "tabDanhSachTB";
            this.tabDanhSachTB.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabDanhSachTB.Size = new System.Drawing.Size(1264, 777);
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
            this.txtGiaTB.Location = new System.Drawing.Point(790, 552);
            this.txtGiaTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaTB.Name = "txtGiaTB";
            this.txtGiaTB.Size = new System.Drawing.Size(217, 35);
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
            this.label12.Location = new System.Drawing.Point(616, 552);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 29);
            this.label12.TabIndex = 129;
            this.label12.Text = "Giá trung bình:";
            // 
            // cbDiemDen
            // 
            this.cbDiemDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDiemDen.FormattingEnabled = true;
            this.cbDiemDen.Location = new System.Drawing.Point(721, 28);
            this.cbDiemDen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDiemDen.Name = "cbDiemDen";
            this.cbDiemDen.Size = new System.Drawing.Size(247, 37);
            this.cbDiemDen.TabIndex = 128;
            // 
            // cbDiemDi
            // 
            this.cbDiemDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDiemDi.FormattingEnabled = true;
            this.cbDiemDi.Location = new System.Drawing.Point(156, 28);
            this.cbDiemDi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDiemDi.Name = "cbDiemDi";
            this.cbDiemDi.Size = new System.Drawing.Size(235, 37);
            this.cbDiemDi.TabIndex = 127;
            // 
            // btnCapNhatTB
            // 
            this.btnCapNhatTB.BackColor = System.Drawing.Color.Blue;
            this.btnCapNhatTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatTB.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatTB.Location = new System.Drawing.Point(558, 704);
            this.btnCapNhatTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCapNhatTB.Name = "btnCapNhatTB";
            this.btnCapNhatTB.Size = new System.Drawing.Size(151, 42);
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
            this.btnHuyThemTB.Location = new System.Drawing.Point(72, 704);
            this.btnHuyThemTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuyThemTB.Name = "btnHuyThemTB";
            this.btnHuyThemTB.Size = new System.Drawing.Size(151, 42);
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
            this.btnThemTB.Location = new System.Drawing.Point(1053, 704);
            this.btnThemTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemTB.Name = "btnThemTB";
            this.btnThemTB.Size = new System.Drawing.Size(151, 42);
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
            this.cbSanBayDen.Location = new System.Drawing.Point(790, 602);
            this.cbSanBayDen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSanBayDen.Name = "cbSanBayDen";
            this.cbSanBayDen.Size = new System.Drawing.Size(136, 37);
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
            this.label4.Location = new System.Drawing.Point(620, 606);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 29);
            this.label4.TabIndex = 96;
            this.label4.Text = "Sân bay đi:";
            // 
            // cbSanBayDi
            // 
            this.cbSanBayDi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSanBayDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSanBayDi.ForeColor = System.Drawing.Color.Navy;
            this.cbSanBayDi.FormattingEnabled = true;
            this.cbSanBayDi.Location = new System.Drawing.Point(230, 626);
            this.cbSanBayDi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSanBayDi.Name = "cbSanBayDi";
            this.cbSanBayDi.Size = new System.Drawing.Size(136, 33);
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
            this.label5.Location = new System.Drawing.Point(68, 570);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 25);
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
            this.txtTenTB.Location = new System.Drawing.Point(230, 569);
            this.txtTenTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenTB.Name = "txtTenTB";
            this.txtTenTB.Size = new System.Drawing.Size(280, 31);
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
            this.label6.Location = new System.Drawing.Point(68, 628);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 92;
            this.label6.Text = "Sân bay đi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(523, 496);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 32);
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
            this.dgvTuyenBay.Location = new System.Drawing.Point(98, 84);
            this.dgvTuyenBay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTuyenBay.Name = "dgvTuyenBay";
            this.dgvTuyenBay.ReadOnly = true;
            this.dgvTuyenBay.RowHeadersWidth = 51;
            this.dgvTuyenBay.RowTemplate.Height = 24;
            this.dgvTuyenBay.Size = new System.Drawing.Size(1043, 392);
            this.dgvTuyenBay.TabIndex = 0;
            this.dgvTuyenBay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTuyenBay_CellClick);
            // 
            // btnTimKiemTB
            // 
            this.btnTimKiemTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTimKiemTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemTB.ForeColor = System.Drawing.Color.White;
            this.btnTimKiemTB.Location = new System.Drawing.Point(1072, 25);
            this.btnTimKiemTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimKiemTB.Name = "btnTimKiemTB";
            this.btnTimKiemTB.Size = new System.Drawing.Size(158, 49);
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
            this.label1.Location = new System.Drawing.Point(40, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
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
            this.label2.Location = new System.Drawing.Point(593, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 29);
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
            this.tabTuyenBay.Location = new System.Drawing.Point(3, 15);
            this.tabTuyenBay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabTuyenBay.Name = "tabTuyenBay";
            this.tabTuyenBay.SelectedIndex = 0;
            this.tabTuyenBay.Size = new System.Drawing.Size(1272, 810);
            this.tabTuyenBay.TabIndex = 89;
            // 
            // TuyenBayController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabTuyenBay);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TuyenBayController";
            this.Size = new System.Drawing.Size(1279, 829);
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
        private System.Windows.Forms.DataGridViewImageColumn Delete_TrungGian;
    }
}
