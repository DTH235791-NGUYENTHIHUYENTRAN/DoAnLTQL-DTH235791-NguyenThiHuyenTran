namespace QuanLyTienGioBBD
{
    partial class FrmHoaDon_ChiTiet
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblKhach = new Label();
            dgvChiTiet = new DataGridView();
            STT = new DataGridViewTextBoxColumn();
            SanPham = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            btnDong = new Button();
            lblTong = new Label();
            lblTienGioChoi = new Label();
            lblTongThanhToan = new Label();
            txtTongTien = new TextBox();
            txtTienGio = new TextBox();
            txtTongThanhToan = new TextBox();
            txtMaHD = new TextBox();
            txtKhachHang = new TextBox();
            cboBan = new ComboBox();
            btnXuat = new Button();
            lbldv = new Label();
            lblSoLuong = new Label();
            txtSoLuong = new TextBox();
            lblDonGia = new Label();
            txtDonGia = new TextBox();
            cboDichVu = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 17);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 0;
            label1.Text = "Thông Tin Hóa Đơn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 64);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 62);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 2;
            label3.Text = "Mã HĐ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(545, 59);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 3;
            label4.Text = "Bàn:";
            // 
            // lblKhach
            // 
            lblKhach.AutoSize = true;
            lblKhach.Location = new Point(292, 62);
            lblKhach.Name = "lblKhach";
            lblKhach.Size = new Size(52, 20);
            lblKhach.TabIndex = 4;
            lblKhach.Text = "Khách:";
            // 
            // dgvChiTiet
            // 
            dgvChiTiet.AllowUserToAddRows = false;
            dgvChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTiet.Columns.AddRange(new DataGridViewColumn[] { STT, SanPham, SoLuong, DonGia, ThanhTien });
            dgvChiTiet.Location = new Point(25, 143);
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.RowHeadersWidth = 51;
            dgvChiTiet.Size = new Size(682, 229);
            dgvChiTiet.TabIndex = 5;
            dgvChiTiet.CellClick += dgvChiTiet_CellClick;
            dgvChiTiet.CellContentClick += dataGridView1_CellContentClick;
            // 
            // STT
            // 
            STT.DataPropertyName = "STT";
            STT.HeaderText = "STT";
            STT.MinimumWidth = 6;
            STT.Name = "STT";
            STT.Width = 125;
            // 
            // SanPham
            // 
            SanPham.DataPropertyName = "SanPham";
            SanPham.HeaderText = "Sản Phẩm";
            SanPham.MinimumWidth = 6;
            SanPham.Name = "SanPham";
            SanPham.Width = 125;
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số Lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            SoLuong.Width = 125;
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            DonGia.HeaderText = "Đơn Giá";
            DonGia.MinimumWidth = 6;
            DonGia.Name = "DonGia";
            DonGia.Width = 125;
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            ThanhTien.HeaderText = "Thành Tiền";
            ThanhTien.MinimumWidth = 6;
            ThanhTien.Name = "ThanhTien";
            ThanhTien.Width = 125;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(732, 194);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(732, 264);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(732, 143);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(732, 324);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(94, 29);
            btnDong.TabIndex = 10;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // lblTong
            // 
            lblTong.AutoSize = true;
            lblTong.Location = new Point(40, 437);
            lblTong.Name = "lblTong";
            lblTong.Size = new Size(151, 20);
            lblTong.TabIndex = 11;
            lblTong.Text = "Tổng Tiền Sản Phẩm :";
            // 
            // lblTienGioChoi
            // 
            lblTienGioChoi.AutoSize = true;
            lblTienGioChoi.Location = new Point(40, 478);
            lblTienGioChoi.Name = "lblTienGioChoi";
            lblTienGioChoi.Size = new Size(101, 20);
            lblTienGioChoi.TabIndex = 12;
            lblTienGioChoi.Text = "Tiền Giờ Chơi:";
            // 
            // lblTongThanhToan
            // 
            lblTongThanhToan.AutoSize = true;
            lblTongThanhToan.Location = new Point(40, 516);
            lblTongThanhToan.Name = "lblTongThanhToan";
            lblTongThanhToan.Size = new Size(127, 20);
            lblTongThanhToan.TabIndex = 13;
            lblTongThanhToan.Text = "Tổng Thanh Toán ";
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(223, 434);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(382, 27);
            txtTongTien.TabIndex = 14;
            // 
            // txtTienGio
            // 
            txtTienGio.Location = new Point(223, 477);
            txtTienGio.Name = "txtTienGio";
            txtTienGio.Size = new Size(382, 27);
            txtTienGio.TabIndex = 15;
            // 
            // txtTongThanhToan
            // 
            txtTongThanhToan.Location = new Point(223, 527);
            txtTongThanhToan.Name = "txtTongThanhToan";
            txtTongThanhToan.Size = new Size(382, 27);
            txtTongThanhToan.TabIndex = 16;
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(117, 56);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(125, 27);
            txtMaHD.TabIndex = 17;
            // 
            // txtKhachHang
            // 
            txtKhachHang.Location = new Point(370, 55);
            txtKhachHang.Name = "txtKhachHang";
            txtKhachHang.Size = new Size(125, 27);
            txtKhachHang.TabIndex = 18;
            // 
            // cboBan
            // 
            cboBan.FormattingEnabled = true;
            cboBan.Location = new Point(628, 54);
            cboBan.Name = "cboBan";
            cboBan.Size = new Size(151, 28);
            cboBan.TabIndex = 19;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(732, 380);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 29);
            btnXuat.TabIndex = 20;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click_1;
            // 
            // lbldv
            // 
            lbldv.AutoSize = true;
            lbldv.Location = new Point(25, 94);
            lbldv.Name = "lbldv";
            lbldv.Size = new Size(85, 20);
            lbldv.TabIndex = 21;
            lbldv.Text = "Mã Dịch Vụ";
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(289, 99);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(75, 20);
            lblSoLuong.TabIndex = 23;
            lblSoLuong.Text = "Số Lượng:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(370, 99);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(125, 27);
            txtSoLuong.TabIndex = 24;
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Location = new Point(548, 105);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(63, 20);
            lblDonGia.TabIndex = 25;
            lblDonGia.Text = "Đơn Giá";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(628, 102);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(151, 27);
            txtDonGia.TabIndex = 26;
            // 
            // cboDichVu
            // 
            cboDichVu.FormattingEnabled = true;
            cboDichVu.Location = new Point(118, 98);
            cboDichVu.Name = "cboDichVu";
            cboDichVu.Size = new Size(151, 28);
            cboDichVu.TabIndex = 27;
            cboDichVu.SelectedIndexChanged += cboDichVu_SelectedIndexChanged;
            // 
            // FrmHoaDon_ChiTiet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 566);
            Controls.Add(cboDichVu);
            Controls.Add(txtDonGia);
            Controls.Add(lblDonGia);
            Controls.Add(txtSoLuong);
            Controls.Add(lblSoLuong);
            Controls.Add(lbldv);
            Controls.Add(btnXuat);
            Controls.Add(cboBan);
            Controls.Add(txtKhachHang);
            Controls.Add(txtMaHD);
            Controls.Add(txtTongThanhToan);
            Controls.Add(txtTienGio);
            Controls.Add(txtTongTien);
            Controls.Add(lblTongThanhToan);
            Controls.Add(lblTienGioChoi);
            Controls.Add(lblTong);
            Controls.Add(btnDong);
            Controls.Add(btnThem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(dgvChiTiet);
            Controls.Add(lblKhach);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmHoaDon_ChiTiet";
            Text = "FrmHoaDon_ChiTiet";
            Load += FrmHoaDon_ChiTiet_Load;
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblKhach;
        private DataGridView dgvChiTiet;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Button btnDong;
        private Label lblTong;
        private Label lblTienGioChoi;
        private Label lblTongThanhToan;
        private TextBox txtTongTien;
        private TextBox txtTienGio;
        private TextBox txtTongThanhToan;
        private TextBox txtMaHD;
        private TextBox txtKhachHang;
        private ComboBox cboBan;
        private Button btnXuat;
        private Label lbldv;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn SanPham;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn ThanhTien;
        private Label lblSoLuong;
        private TextBox txtSoLuong;
        private Label lblDonGia;
        private TextBox txtDonGia;
        private ComboBox cboDichVu;
    }
}