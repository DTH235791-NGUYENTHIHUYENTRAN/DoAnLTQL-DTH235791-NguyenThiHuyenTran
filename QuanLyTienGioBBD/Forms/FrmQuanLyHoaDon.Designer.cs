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
            btnXoa = new Button();
            dgvLichSu = new DataGridView();
            btnThoat = new Button();
            dtpTuNgay = new DateTimePicker();
            dtpDenNgay = new DateTimePicker();
            lblTongDoanhThu = new Label();
            btnInLaiBill = new Button();
            btnXuat = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLichSu).BeginInit();
            SuspendLayout();
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(12, 22);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập để tìm";
            txtTimKiem.Size = new Size(162, 27);
            txtTimKiem.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(180, 22);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(307, 20);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(427, 20);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // dgvLichSu
            // 
            dgvLichSu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLichSu.Location = new Point(12, 110);
            dgvLichSu.Name = "dgvLichSu";
            dgvLichSu.RowHeadersWidth = 51;
            dgvLichSu.Size = new Size(776, 188);
            dgvLichSu.TabIndex = 6;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(552, 22);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Location = new Point(15, 64);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(250, 27);
            dtpTuNgay.TabIndex = 8;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Location = new Point(321, 68);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(250, 27);
            dtpDenNgay.TabIndex = 9;
            // 
            // lblTongDoanhThu
            // 
            lblTongDoanhThu.AutoSize = true;
            lblTongDoanhThu.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTongDoanhThu.Location = new Point(25, 336);
            lblTongDoanhThu.Name = "lblTongDoanhThu";
            lblTongDoanhThu.Size = new Size(184, 25);
            lblTongDoanhThu.TabIndex = 10;
            lblTongDoanhThu.Text = "Tổng Doanh Thu";
            // 
            // btnInLaiBill
            // 
            btnInLaiBill.Location = new Point(669, 20);
            btnInLaiBill.Name = "btnInLaiBill";
            btnInLaiBill.Size = new Size(94, 29);
            btnInLaiBill.TabIndex = 11;
            btnInLaiBill.Text = "In Lại HD";
            btnInLaiBill.UseVisualStyleBackColor = true;
            btnInLaiBill.Click += btnInLaiBill_Click;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(613, 73);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 29);
            btnXuat.TabIndex = 12;
            btnXuat.Text = "Xuất Excel";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // FrmQuanLyHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnXuat);
            Controls.Add(btnInLaiBill);
            Controls.Add(lblTongDoanhThu);
            Controls.Add(dtpDenNgay);
            Controls.Add(dtpTuNgay);
            Controls.Add(btnThoat);
            Controls.Add(dgvLichSu);
            Controls.Add(btnXoa);
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
        private Button btnXoa;
        private DataGridView dgvLichSu;
        private Button btnThoat;
        private DateTimePicker dtpTuNgay;
        private DateTimePicker dtpDenNgay;
        private Label lblTongDoanhThu;
        private Button btnInLaiBill;
        private Button btnXuat;
    }
}