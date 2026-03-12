namespace QuanLyTienGioBBD
{
    partial class FrmHoaDon
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lbltt = new Label();
            label2 = new Label();
            lblBan = new Label();
            lblNhanVien = new Label();
            lblGioKetThuc = new Label();
            lblTongHoaDon = new Label();
            lblNgayLap = new Label();
            lblKhachHang = new Label();
            lblGioBatDau = new Label();
            btnXoa = new Button();
            btnSua = new Button();
            btnThoat = new Button();
            btnTimKiem = new Button();
            txtMaHD = new TextBox();
            cboBanBida = new ComboBox();
            cboNhanVien = new ComboBox();
            cboKhachHang = new ComboBox();
            txtTongHoaDon = new TextBox();
            dgvHoaDon = new DataGridView();
            MaHD = new DataGridViewTextBoxColumn();
            Ban = new DataGridViewTextBoxColumn();
            KhachHang = new DataGridViewTextBoxColumn();
            GioBatDau = new DataGridViewTextBoxColumn();
            GioKetThuc = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
            dtpNgayLap = new DateTimePicker();
            dtpGioKetThuc = new DateTimePicker();
            dtpGioBatDau = new DateTimePicker();
            lblDS = new Label();
            btnChiTiet = new Button();
            btnThem = new Button();
            btnXuat = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            SuspendLayout();
            // 
            // lbltt
            // 
            lbltt.AutoSize = true;
            lbltt.Location = new Point(37, 22);
            lbltt.Name = "lbltt";
            lbltt.Size = new Size(139, 20);
            lbltt.TabIndex = 0;
            lbltt.Text = "Thông Tin Hóa Đơn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 76);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã Hóa Đơn";
            // 
            // lblBan
            // 
            lblBan.AutoSize = true;
            lblBan.Location = new Point(48, 121);
            lblBan.Name = "lblBan";
            lblBan.Size = new Size(59, 20);
            lblBan.TabIndex = 2;
            lblBan.Text = "Mã Bàn";
            // 
            // lblNhanVien
            // 
            lblNhanVien.AutoSize = true;
            lblNhanVien.Location = new Point(48, 170);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(77, 20);
            lblNhanVien.TabIndex = 3;
            lblNhanVien.Text = "Nhân Viên";
            // 
            // lblGioKetThuc
            // 
            lblGioKetThuc.AutoSize = true;
            lblGioKetThuc.Location = new Point(48, 213);
            lblGioKetThuc.Name = "lblGioKetThuc";
            lblGioKetThuc.Size = new Size(93, 20);
            lblGioKetThuc.TabIndex = 4;
            lblGioKetThuc.Text = "Giờ Kết Thúc";
            // 
            // lblTongHoaDon
            // 
            lblTongHoaDon.AutoSize = true;
            lblTongHoaDon.Location = new Point(43, 256);
            lblTongHoaDon.Name = "lblTongHoaDon";
            lblTongHoaDon.Size = new Size(107, 20);
            lblTongHoaDon.TabIndex = 5;
            lblTongHoaDon.Text = "Tổng Hóa Đơn";
            // 
            // lblNgayLap
            // 
            lblNgayLap.AutoSize = true;
            lblNgayLap.Location = new Point(538, 85);
            lblNgayLap.Name = "lblNgayLap";
            lblNgayLap.Size = new Size(72, 20);
            lblNgayLap.TabIndex = 6;
            lblNgayLap.Text = "Ngày Lập";
            // 
            // lblKhachHang
            // 
            lblKhachHang.AutoSize = true;
            lblKhachHang.Location = new Point(542, 130);
            lblKhachHang.Name = "lblKhachHang";
            lblKhachHang.Size = new Size(89, 20);
            lblKhachHang.TabIndex = 7;
            lblKhachHang.Text = "Khách Hàng";
            // 
            // lblGioBatDau
            // 
            lblGioBatDau.AutoSize = true;
            lblGioBatDau.Location = new Point(538, 179);
            lblGioBatDau.Name = "lblGioBatDau";
            lblGioBatDau.Size = new Size(89, 20);
            lblGioBatDau.TabIndex = 8;
            lblGioBatDau.Text = "Giờ Bắt Đầu";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(178, 512);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(294, 508);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(542, 512);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 15;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(414, 512);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 16;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(154, 76);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(125, 27);
            txtMaHD.TabIndex = 17;
            // 
            // cboBanBida
            // 
            cboBanBida.FormattingEnabled = true;
            cboBanBida.Location = new Point(154, 123);
            cboBanBida.Name = "cboBanBida";
            cboBanBida.Size = new Size(151, 28);
            cboBanBida.TabIndex = 18;
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(154, 167);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(151, 28);
            cboNhanVien.TabIndex = 19;
            // 
            // cboKhachHang
            // 
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(663, 130);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(151, 28);
            cboKhachHang.TabIndex = 20;
            // 
            // txtTongHoaDon
            // 
            txtTongHoaDon.Location = new Point(154, 256);
            txtTongHoaDon.Name = "txtTongHoaDon";
            txtTongHoaDon.Size = new Size(125, 27);
            txtTongHoaDon.TabIndex = 22;
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Columns.AddRange(new DataGridViewColumn[] { MaHD, Ban, KhachHang, GioBatDau, GioKetThuc, TongTien });
            dgvHoaDon.Location = new Point(37, 333);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.RowHeadersWidth = 51;
            dgvHoaDon.Size = new Size(935, 149);
            dgvHoaDon.TabIndex = 24;
            dgvHoaDon.CellContentClick += dgvHoaDon_CellContentClick;
            // 
            // MaHD
            // 
            MaHD.DataPropertyName = "MaHD";
            MaHD.HeaderText = "Mã HĐ";
            MaHD.MinimumWidth = 6;
            MaHD.Name = "MaHD";
            // 
            // Ban
            // 
            Ban.DataPropertyName = "Ban";
            Ban.HeaderText = "Bàn";
            Ban.MinimumWidth = 6;
            Ban.Name = "Ban";
            // 
            // KhachHang
            // 
            KhachHang.DataPropertyName = "KhachHang";
            KhachHang.HeaderText = "Khách Hàng";
            KhachHang.MinimumWidth = 6;
            KhachHang.Name = "KhachHang";
            // 
            // GioBatDau
            // 
            GioBatDau.DataPropertyName = "GioBatDau";
            dataGridViewCellStyle1.Format = "T";
            dataGridViewCellStyle1.NullValue = null;
            GioBatDau.DefaultCellStyle = dataGridViewCellStyle1;
            GioBatDau.HeaderText = "Giờ Bắt Đầu";
            GioBatDau.MinimumWidth = 6;
            GioBatDau.Name = "GioBatDau";
            // 
            // GioKetThuc
            // 
            GioKetThuc.DataPropertyName = "GioKetThuc";
            dataGridViewCellStyle2.Format = "T";
            dataGridViewCellStyle2.NullValue = null;
            GioKetThuc.DefaultCellStyle = dataGridViewCellStyle2;
            GioKetThuc.HeaderText = "Giờ Kết Thúc";
            GioKetThuc.MinimumWidth = 6;
            GioKetThuc.Name = "GioKetThuc";
            // 
            // TongTien
            // 
            TongTien.DataPropertyName = "TongTien";
            TongTien.HeaderText = "Tổng Tiền";
            TongTien.MinimumWidth = 6;
            TongTien.Name = "TongTien";
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.Location = new Point(663, 85);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(250, 27);
            dtpNgayLap.TabIndex = 25;
            // 
            // dtpGioKetThuc
            // 
            dtpGioKetThuc.Format = DateTimePickerFormat.Time;
            dtpGioKetThuc.Location = new Point(154, 213);
            dtpGioKetThuc.Name = "dtpGioKetThuc";
            dtpGioKetThuc.ShowUpDown = true;
            dtpGioKetThuc.Size = new Size(250, 27);
            dtpGioKetThuc.TabIndex = 26;
            dtpGioKetThuc.Value = new DateTime(2026, 3, 9, 20, 57, 18, 0);
            dtpGioKetThuc.ValueChanged += dtpGioKetThuc_ValueChanged;
            // 
            // dtpGioBatDau
            // 
            dtpGioBatDau.Format = DateTimePickerFormat.Time;
            dtpGioBatDau.Location = new Point(663, 179);
            dtpGioBatDau.Name = "dtpGioBatDau";
            dtpGioBatDau.ShowUpDown = true;
            dtpGioBatDau.Size = new Size(250, 27);
            dtpGioBatDau.TabIndex = 27;
            // 
            // lblDS
            // 
            lblDS.AutoSize = true;
            lblDS.Location = new Point(37, 298);
            lblDS.Name = "lblDS";
            lblDS.Size = new Size(143, 20);
            lblDS.TabIndex = 28;
            lblDS.Text = "Danh Sách Hóa Đơn";
            // 
            // btnChiTiet
            // 
            btnChiTiet.Location = new Point(673, 512);
            btnChiTiet.Name = "btnChiTiet";
            btnChiTiet.Size = new Size(94, 29);
            btnChiTiet.TabIndex = 29;
            btnChiTiet.Text = "Chi Tiết";
            btnChiTiet.UseVisualStyleBackColor = true;
            btnChiTiet.Click += btnChiTiet_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(56, 508);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 30;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(804, 512);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 29);
            btnXuat.TabIndex = 31;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // FrmHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 568);
            Controls.Add(btnXuat);
            Controls.Add(btnThem);
            Controls.Add(btnChiTiet);
            Controls.Add(lblDS);
            Controls.Add(dtpGioBatDau);
            Controls.Add(dtpGioKetThuc);
            Controls.Add(dtpNgayLap);
            Controls.Add(dgvHoaDon);
            Controls.Add(txtTongHoaDon);
            Controls.Add(cboKhachHang);
            Controls.Add(cboNhanVien);
            Controls.Add(cboBanBida);
            Controls.Add(txtMaHD);
            Controls.Add(btnTimKiem);
            Controls.Add(btnThoat);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(lblGioBatDau);
            Controls.Add(lblKhachHang);
            Controls.Add(lblNgayLap);
            Controls.Add(lblTongHoaDon);
            Controls.Add(lblGioKetThuc);
            Controls.Add(lblNhanVien);
            Controls.Add(lblBan);
            Controls.Add(label2);
            Controls.Add(lbltt);
            Name = "FrmHoaDon";
            Text = "FrmHoaDon";
            Load += FrmHoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltt;
        private Label label2;
        private Label lblBan;
        private Label lblNhanVien;
        private Label lblGioKetThuc;
        private Label lblTongHoaDon;
        private Label lblNgayLap;
        private Label lblKhachHang;
        private Label lblGioBatDau;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThoat;
        private Button btnTimKiem;
        private TextBox txtMaHD;
        private ComboBox cboBanBida;
        private ComboBox cboNhanVien;
        private ComboBox cboKhachHang;
        private TextBox txtTongHoaDon;
        private DataGridView dgvHoaDon;
        private DateTimePicker dtpNgayLap;
        private DateTimePicker dtpGioKetThuc;
        private DateTimePicker dtpGioBatDau;
        private Label lblDS;
        private Button btnChiTiet;
        private Button btnThem;
        private Button btnXuat;
        private DataGridViewTextBoxColumn MaHD;
        private DataGridViewTextBoxColumn Ban;
        private DataGridViewTextBoxColumn KhachHang;
        private DataGridViewTextBoxColumn GioBatDau;
        private DataGridViewTextBoxColumn GioKetThuc;
        private DataGridViewTextBoxColumn TongTien;
    }
}