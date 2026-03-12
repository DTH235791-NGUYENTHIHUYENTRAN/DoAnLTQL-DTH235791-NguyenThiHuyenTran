namespace QuanLyTienGioBBD
{
    partial class FrmQuanLyBan
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
            lblThongTinBan = new Label();
            lblMaBan = new Label();
            lblLoaiBan = new Label();
            lblTrangThai = new Label();
            lblGiaGio = new Label();
            txtMaBan = new TextBox();
            txtLoaiBan = new TextBox();
            txtGiaGio = new TextBox();
            btnBatDau = new Button();
            btntt = new Button();
            btnDoiban = new Button();
            btnLamMoi = new Button();
            lblDS = new Label();
            dgvBan = new DataGridView();
            MaBan = new DataGridViewTextBoxColumn();
            TenBan = new DataGridViewTextBoxColumn();
            Loaiban = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            Giobd = new DataGridViewTextBoxColumn();
            Giokt = new DataGridViewTextBoxColumn();
            btnThoat = new Button();
            txtTrangThai = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvBan).BeginInit();
            SuspendLayout();
            // 
            // lblThongTinBan
            // 
            lblThongTinBan.AutoSize = true;
            lblThongTinBan.Location = new Point(13, 9);
            lblThongTinBan.Name = "lblThongTinBan";
            lblThongTinBan.Size = new Size(104, 20);
            lblThongTinBan.TabIndex = 0;
            lblThongTinBan.Text = "Thông Tin Bàn";
            // 
            // lblMaBan
            // 
            lblMaBan.AutoSize = true;
            lblMaBan.Location = new Point(13, 54);
            lblMaBan.Name = "lblMaBan";
            lblMaBan.Size = new Size(59, 20);
            lblMaBan.TabIndex = 1;
            lblMaBan.Text = "Mã Bàn";
            // 
            // lblLoaiBan
            // 
            lblLoaiBan.AutoSize = true;
            lblLoaiBan.Location = new Point(13, 99);
            lblLoaiBan.Name = "lblLoaiBan";
            lblLoaiBan.Size = new Size(66, 20);
            lblLoaiBan.TabIndex = 2;
            lblLoaiBan.Text = "Loại Bàn";
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(13, 152);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(78, 20);
            lblTrangThai.TabIndex = 3;
            lblTrangThai.Text = "Trạng Thái";
            // 
            // lblGiaGio
            // 
            lblGiaGio.AutoSize = true;
            lblGiaGio.Location = new Point(14, 200);
            lblGiaGio.Name = "lblGiaGio";
            lblGiaGio.Size = new Size(58, 20);
            lblGiaGio.TabIndex = 4;
            lblGiaGio.Text = "Giá Giờ";
            // 
            // txtMaBan
            // 
            txtMaBan.Location = new Point(108, 54);
            txtMaBan.Name = "txtMaBan";
            txtMaBan.Size = new Size(125, 27);
            txtMaBan.TabIndex = 7;
            // 
            // txtLoaiBan
            // 
            txtLoaiBan.Location = new Point(108, 99);
            txtLoaiBan.Name = "txtLoaiBan";
            txtLoaiBan.Size = new Size(125, 27);
            txtLoaiBan.TabIndex = 8;
            // 
            // txtGiaGio
            // 
            txtGiaGio.Location = new Point(108, 200);
            txtGiaGio.Name = "txtGiaGio";
            txtGiaGio.Size = new Size(125, 27);
            txtGiaGio.TabIndex = 9;
            // 
            // btnBatDau
            // 
            btnBatDau.Location = new Point(14, 259);
            btnBatDau.Name = "btnBatDau";
            btnBatDau.Size = new Size(94, 29);
            btnBatDau.TabIndex = 13;
            btnBatDau.Text = "Bắt Đầu";
            btnBatDau.UseVisualStyleBackColor = true;
            btnBatDau.Click += btnBatDau_Click;
            // 
            // btntt
            // 
            btntt.Location = new Point(14, 315);
            btntt.Name = "btntt";
            btntt.Size = new Size(94, 29);
            btntt.TabIndex = 15;
            btntt.Text = "Thanh Toán";
            btntt.UseVisualStyleBackColor = true;
            btntt.Click += btntt_Click;
            // 
            // btnDoiban
            // 
            btnDoiban.Location = new Point(139, 315);
            btnDoiban.Name = "btnDoiban";
            btnDoiban.Size = new Size(94, 29);
            btnDoiban.TabIndex = 16;
            btnDoiban.Text = "Đổi Bàn";
            btnDoiban.UseVisualStyleBackColor = true;
            btnDoiban.Click += btnDoiban_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(74, 370);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 17;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // lblDS
            // 
            lblDS.AutoSize = true;
            lblDS.Location = new Point(266, 9);
            lblDS.Name = "lblDS";
            lblDS.Size = new Size(108, 20);
            lblDS.TabIndex = 18;
            lblDS.Text = "Danh Sách Bàn";
            // 
            // dgvBan
            // 
            dgvBan.AllowUserToAddRows = false;
            dgvBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBan.Columns.AddRange(new DataGridViewColumn[] { MaBan, TenBan, Loaiban, TrangThai, Giobd, Giokt });
            dgvBan.Location = new Point(266, 54);
            dgvBan.Name = "dgvBan";
            dgvBan.RowHeadersWidth = 51;
            dgvBan.Size = new Size(693, 333);
            dgvBan.TabIndex = 19;
            dgvBan.CellClick += dgvBan_CellClick;
            // 
            // MaBan
            // 
            MaBan.DataPropertyName = "MaBan";
            MaBan.HeaderText = "Mã Bàn";
            MaBan.MinimumWidth = 6;
            MaBan.Name = "MaBan";
            // 
            // TenBan
            // 
            TenBan.DataPropertyName = "TenBan";
            TenBan.HeaderText = "Tên Bàn";
            TenBan.MinimumWidth = 6;
            TenBan.Name = "TenBan";
            // 
            // Loaiban
            // 
            Loaiban.DataPropertyName = "Loaiban";
            Loaiban.HeaderText = "Loại Bàn";
            Loaiban.MinimumWidth = 6;
            Loaiban.Name = "Loaiban";
            // 
            // TrangThai
            // 
            TrangThai.DataPropertyName = "TrangThai";
            TrangThai.HeaderText = "Trạng Thái";
            TrangThai.MinimumWidth = 6;
            TrangThai.Name = "TrangThai";
            // 
            // Giobd
            // 
            Giobd.DataPropertyName = "Giobd";
            dataGridViewCellStyle1.Format = "T";
            dataGridViewCellStyle1.NullValue = null;
            Giobd.DefaultCellStyle = dataGridViewCellStyle1;
            Giobd.HeaderText = "Giờ Bắt Đầu";
            Giobd.MinimumWidth = 6;
            Giobd.Name = "Giobd";
            // 
            // Giokt
            // 
            Giokt.DataPropertyName = "Giokt";
            dataGridViewCellStyle2.Format = "T";
            dataGridViewCellStyle2.NullValue = null;
            Giokt.DefaultCellStyle = dataGridViewCellStyle2;
            Giokt.HeaderText = "Giờ Kết Thúc";
            Giokt.MinimumWidth = 6;
            Giokt.Name = "Giokt";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(139, 259);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 23;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtTrangThai
            // 
            txtTrangThai.Location = new Point(110, 151);
            txtTrangThai.Name = "txtTrangThai";
            txtTrangThai.Size = new Size(125, 27);
            txtTrangThai.TabIndex = 24;
            // 
            // FrmQuanLyBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 499);
            Controls.Add(txtTrangThai);
            Controls.Add(btnThoat);
            Controls.Add(dgvBan);
            Controls.Add(lblDS);
            Controls.Add(btnLamMoi);
            Controls.Add(btnDoiban);
            Controls.Add(btntt);
            Controls.Add(btnBatDau);
            Controls.Add(txtGiaGio);
            Controls.Add(txtLoaiBan);
            Controls.Add(txtMaBan);
            Controls.Add(lblGiaGio);
            Controls.Add(lblTrangThai);
            Controls.Add(lblLoaiBan);
            Controls.Add(lblMaBan);
            Controls.Add(lblThongTinBan);
            Name = "FrmQuanLyBan";
            Text = "FrmQuanLyBan";
            Load += FrmQuanLyBan_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblThongTinBan;
        private Label lblMaBan;
        private Label lblLoaiBan;
        private Label lblTrangThai;
        private Label lblGiaGio;
        private TextBox txtMaBan;
        private TextBox txtLoaiBan;
        private TextBox txtGiaGio;
        private Button btnBatDau;
        private Button btntt;
        private Button btnDoiban;
        private Button btnLamMoi;
        private Label lblDS;
        private DataGridView dgvBan;
        private Button btnThoat;
        private DataGridViewTextBoxColumn MaBan;
        private DataGridViewTextBoxColumn TenBan;
        private DataGridViewTextBoxColumn Loaiban;
        private DataGridViewTextBoxColumn TrangThai;
        private DataGridViewTextBoxColumn Giobd;
        private DataGridViewTextBoxColumn Giokt;
        private TextBox txtTrangThai;
    }
}