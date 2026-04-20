namespace QuanLyTienGioBBD.Forms
{
    partial class FrmThongKeDoanhThu
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
            dtpTuNgay = new DateTimePicker();
            dtpDenNgay = new DateTimePicker();
            btnThongKe = new Button();
            panelDoanhThu = new Panel();
            lblTongDoanhThu = new Label();
            label1 = new Label();
            panelGioChoi = new Panel();
            lblTongGioChoi = new Label();
            label3 = new Label();
            panelSoHoaDon = new Panel();
            lblSoHoaDon = new Label();
            label5 = new Label();
            dgvThongKe = new DataGridView();
            NgayLap = new DataGridViewTextBoxColumn();
            MaHD = new DataGridViewTextBoxColumn();
            TenBan = new DataGridViewTextBoxColumn();
            SoGio = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
            btnXuat = new Button();
            panelDoanhThu.SuspendLayout();
            panelGioChoi.SuspendLayout();
            panelSoHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).BeginInit();
            SuspendLayout();
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new Point(38, 31);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(250, 27);
            dtpTuNgay.TabIndex = 1;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new Point(38, 73);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(250, 27);
            dtpDenNgay.TabIndex = 2;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = SystemColors.AppWorkspace;
            btnThongKe.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnThongKe.Location = new Point(38, 118);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(134, 45);
            btnThongKe.TabIndex = 3;
            btnThongKe.Text = "Thống Kê";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // panelDoanhThu
            // 
            panelDoanhThu.Controls.Add(lblTongDoanhThu);
            panelDoanhThu.Controls.Add(label1);
            panelDoanhThu.Location = new Point(362, 18);
            panelDoanhThu.Name = "panelDoanhThu";
            panelDoanhThu.Size = new Size(200, 145);
            panelDoanhThu.TabIndex = 4;
            // 
            // lblTongDoanhThu
            // 
            lblTongDoanhThu.AutoSize = true;
            lblTongDoanhThu.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblTongDoanhThu.Location = new Point(17, 81);
            lblTongDoanhThu.Name = "lblTongDoanhThu";
            lblTongDoanhThu.Size = new Size(124, 20);
            lblTongDoanhThu.TabIndex = 1;
            lblTongDoanhThu.Text = "Tổng doanh thu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(31, 17);
            label1.Name = "label1";
            label1.Size = new Size(150, 23);
            label1.TabIndex = 0;
            label1.Text = "Tổng Doanh Thu";
            // 
            // panelGioChoi
            // 
            panelGioChoi.Controls.Add(lblTongGioChoi);
            panelGioChoi.Controls.Add(label3);
            panelGioChoi.Location = new Point(579, 18);
            panelGioChoi.Name = "panelGioChoi";
            panelGioChoi.Size = new Size(201, 145);
            panelGioChoi.TabIndex = 5;
            // 
            // lblTongGioChoi
            // 
            lblTongGioChoi.AutoSize = true;
            lblTongGioChoi.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblTongGioChoi.Location = new Point(13, 81);
            lblTongGioChoi.Name = "lblTongGioChoi";
            lblTongGioChoi.Size = new Size(110, 20);
            lblTongGioChoi.TabIndex = 1;
            lblTongGioChoi.Text = "Tổng giờ chơi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(27, 17);
            label3.Name = "label3";
            label3.Size = new Size(135, 23);
            label3.TabIndex = 0;
            label3.Text = "Tổng Giờ Chơi";
            // 
            // panelSoHoaDon
            // 
            panelSoHoaDon.Controls.Add(lblSoHoaDon);
            panelSoHoaDon.Controls.Add(label5);
            panelSoHoaDon.Location = new Point(800, 18);
            panelSoHoaDon.Name = "panelSoHoaDon";
            panelSoHoaDon.Size = new Size(201, 145);
            panelSoHoaDon.TabIndex = 6;
            // 
            // lblSoHoaDon
            // 
            lblSoHoaDon.AutoSize = true;
            lblSoHoaDon.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblSoHoaDon.Location = new Point(23, 81);
            lblSoHoaDon.Name = "lblSoHoaDon";
            lblSoHoaDon.Size = new Size(92, 20);
            lblSoHoaDon.TabIndex = 1;
            lblSoHoaDon.Text = "Số hóa đơn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.Location = new Point(44, 24);
            label5.Name = "label5";
            label5.Size = new Size(111, 23);
            label5.TabIndex = 0;
            label5.Text = "Số Hóa Đơn";
            // 
            // dgvThongKe
            // 
            dgvThongKe.AllowUserToAddRows = false;
            dgvThongKe.AllowUserToDeleteRows = false;
            dgvThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongKe.Columns.AddRange(new DataGridViewColumn[] { NgayLap, MaHD, TenBan, SoGio, TongTien });
            dgvThongKe.Location = new Point(38, 186);
            dgvThongKe.Name = "dgvThongKe";
            dgvThongKe.RowHeadersWidth = 51;
            dgvThongKe.Size = new Size(951, 550);
            dgvThongKe.TabIndex = 7;
            dgvThongKe.CellFormatting += dgvThongKe_CellFormatting;
            // 
            // NgayLap
            // 
            NgayLap.DataPropertyName = "NgayLap";
            NgayLap.HeaderText = "Ngày Lập";
            NgayLap.MinimumWidth = 6;
            NgayLap.Name = "NgayLap";
            // 
            // MaHD
            // 
            MaHD.DataPropertyName = "MaHD";
            MaHD.HeaderText = "Mã HĐ";
            MaHD.MinimumWidth = 6;
            MaHD.Name = "MaHD";
            // 
            // TenBan
            // 
            TenBan.DataPropertyName = "TenBan";
            TenBan.HeaderText = "Tên Bàn";
            TenBan.MinimumWidth = 6;
            TenBan.Name = "TenBan";
            // 
            // SoGio
            // 
            SoGio.DataPropertyName = "SoGio";
            SoGio.HeaderText = "Số Giờ";
            SoGio.MinimumWidth = 6;
            SoGio.Name = "SoGio";
            // 
            // TongTien
            // 
            TongTien.DataPropertyName = "TongTien";
            TongTien.HeaderText = "Tổng Tiền";
            TongTien.MinimumWidth = 6;
            TongTien.Name = "TongTien";
            // 
            // btnXuat
            // 
            btnXuat.BackColor = SystemColors.AppWorkspace;
            btnXuat.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnXuat.Location = new Point(194, 118);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(128, 45);
            btnXuat.TabIndex = 8;
            btnXuat.Text = "Xuất Excel";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // FrmThongKeDoanhThu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 748);
            Controls.Add(btnXuat);
            Controls.Add(dgvThongKe);
            Controls.Add(panelSoHoaDon);
            Controls.Add(panelGioChoi);
            Controls.Add(panelDoanhThu);
            Controls.Add(btnThongKe);
            Controls.Add(dtpDenNgay);
            Controls.Add(dtpTuNgay);
            Name = "FrmThongKeDoanhThu";
            Text = "FrmThongKeDoanhThu";
            panelDoanhThu.ResumeLayout(false);
            panelDoanhThu.PerformLayout();
            panelGioChoi.ResumeLayout(false);
            panelGioChoi.PerformLayout();
            panelSoHoaDon.ResumeLayout(false);
            panelSoHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DateTimePicker dtpTuNgay;
        private DateTimePicker dtpDenNgay;
        private Button btnThongKe;
        private Panel panelDoanhThu;
        private Panel panelGioChoi;
        private Panel panelSoHoaDon;
        private DataGridView dgvThongKe;
        private Button btnXuat;
        private Label lblTongDoanhThu;
        private Label label1;
        private Label lblTongGioChoi;
        private Label label3;
        private Label lblSoHoaDon;
        private Label label5;
        private DataGridViewTextBoxColumn NgayLap;
        private DataGridViewTextBoxColumn MaHD;
        private DataGridViewTextBoxColumn TenBan;
        private DataGridViewTextBoxColumn SoGio;
        private DataGridViewTextBoxColumn TongTien;
    }
}