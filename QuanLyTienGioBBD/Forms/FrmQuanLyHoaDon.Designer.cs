namespace QuanLyTienGioBBD.Forms
{
    partial class FrmQuanLyHoaDon
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
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            btnLamMoi = new Button();
            dgvLichSu = new DataGridView();
            btnThoat = new Button();
            dtpTuNgay = new DateTimePicker();
            dtpDenNgay = new DateTimePicker();
            lblTongDoanhThu = new Label();
            btnXuat = new Button();
            cboBan = new ComboBox();
            lblBan = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLichSu).BeginInit();
            SuspendLayout();
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(15, 14);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập để tìm";
            txtTimKiem.Size = new Size(196, 27);
            txtTimKiem.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(279, 9);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(132, 39);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(454, 8);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(103, 39);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // dgvLichSu
            // 
            dgvLichSu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLichSu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLichSu.Location = new Point(12, 123);
            dgvLichSu.Name = "dgvLichSu";
            dgvLichSu.RowHeadersWidth = 51;
            dgvLichSu.Size = new Size(1094, 434);
            dgvLichSu.TabIndex = 6;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(756, 8);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(96, 34);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new Point(15, 64);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(203, 27);
            dtpTuNgay.TabIndex = 8;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new Point(257, 64);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(177, 27);
            dtpDenNgay.TabIndex = 9;
            // 
            // lblTongDoanhThu
            // 
            lblTongDoanhThu.AutoSize = true;
            lblTongDoanhThu.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTongDoanhThu.Location = new Point(770, 65);
            lblTongDoanhThu.Name = "lblTongDoanhThu";
            lblTongDoanhThu.Size = new Size(184, 25);
            lblTongDoanhThu.TabIndex = 10;
            lblTongDoanhThu.Text = "Tổng Doanh Thu";
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(601, 10);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(117, 37);
            btnXuat.TabIndex = 12;
            btnXuat.Text = "Xuất Excel";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // cboBan
            // 
            cboBan.FormattingEnabled = true;
            cboBan.Location = new Point(582, 66);
            cboBan.Name = "cboBan";
            cboBan.Size = new Size(151, 28);
            cboBan.TabIndex = 13;
            cboBan.SelectedIndexChanged += cboBan_SelectedIndexChanged;
            // 
            // lblBan
            // 
            lblBan.AutoSize = true;
            lblBan.Location = new Point(493, 71);
            lblBan.Name = "lblBan";
            lblBan.Size = new Size(64, 20);
            lblBan.TabIndex = 14;
            lblBan.Text = "Lọc Bàn:";
            // 
            // FrmQuanLyHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 569);
            Controls.Add(lblBan);
            Controls.Add(cboBan);
            Controls.Add(btnXuat);
            Controls.Add(lblTongDoanhThu);
            Controls.Add(dtpDenNgay);
            Controls.Add(dtpTuNgay);
            Controls.Add(btnThoat);
            Controls.Add(dgvLichSu);
            Controls.Add(btnLamMoi);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Name = "FrmQuanLyHoaDon";
            Text = "FrmQuanLyHoaDon";
            Load += FrmQuanLyHoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLichSu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private Button btnLamMoi;
        private DataGridView dgvLichSu;
        private Button btnThoat;
        private DateTimePicker dtpTuNgay;
        private DateTimePicker dtpDenNgay;
        private Label lblTongDoanhThu;
        private Button btnXuat;
        private ComboBox cboBan;
        private Label lblBan;
    }
}