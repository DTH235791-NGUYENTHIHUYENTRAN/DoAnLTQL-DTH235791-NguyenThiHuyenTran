namespace QuanLyTienGioBBD.Forms
{
    partial class FrmTinhTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTinhTien));
            lblBatDau = new Label();
            lblKetThuc = new Label();
            lblThoiGian = new Label();
            lblGiaBan = new Label();
            lblTongTien = new Label();
            btnThanhToan = new Button();
            cboThanhToan = new ComboBox();
            picQR = new PictureBox();
            lblLoaiKH = new Label();
            lblDiem = new Label();
            lblTenKH = new Label();
            groupBox1 = new GroupBox();
            txtTienKhach = new TextBox();
            lblTienThua = new Label();
            lblGiamGia = new Label();
            lblTienGoc = new Label();
            groupBox2 = new GroupBox();
            lblBan = new Label();
            lblUuDai = new Label();
            txtSDT = new TextBox();
            btnDong = new Button();
            groupBox3 = new GroupBox();
            lblTienBanHienTai = new Label();
            lblGhiChuBanCu = new Label();
            lblTienBanCu = new Label();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)picQR).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // lblBatDau
            // 
            lblBatDau.AutoSize = true;
            lblBatDau.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblBatDau.Location = new Point(8, 39);
            lblBatDau.Name = "lblBatDau";
            lblBatDau.Size = new Size(109, 23);
            lblBatDau.TabIndex = 1;
            lblBatDau.Text = "Giờ bắt đầu";
            // 
            // lblKetThuc
            // 
            lblKetThuc.AutoSize = true;
            lblKetThuc.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblKetThuc.Location = new Point(8, 93);
            lblKetThuc.Name = "lblKetThuc";
            lblKetThuc.Size = new Size(117, 23);
            lblKetThuc.TabIndex = 2;
            lblKetThuc.Text = "Giờ kết thúc";
            // 
            // lblThoiGian
            // 
            lblThoiGian.AutoSize = true;
            lblThoiGian.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblThoiGian.Location = new Point(8, 143);
            lblThoiGian.Name = "lblThoiGian";
            lblThoiGian.Size = new Size(131, 23);
            lblThoiGian.TabIndex = 3;
            lblThoiGian.Text = "Tổng thời gian";
            // 
            // lblGiaBan
            // 
            lblGiaBan.AutoSize = true;
            lblGiaBan.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblGiaBan.Location = new Point(8, 188);
            lblGiaBan.Name = "lblGiaBan";
            lblGiaBan.Size = new Size(79, 23);
            lblGiaBan.TabIndex = 4;
            lblGiaBan.Text = "Tiền giờ";
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblTongTien.Location = new Point(13, 159);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(90, 23);
            lblTongTien.TabIndex = 5;
            lblTongTien.Text = "Tổng tiền";
            // 
            // btnThanhToan
            // 
            btnThanhToan.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnThanhToan.Location = new Point(550, 704);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(155, 37);
            btnThanhToan.TabIndex = 6;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // cboThanhToan
            // 
            cboThanhToan.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            cboThanhToan.FormattingEnabled = true;
            cboThanhToan.Location = new Point(6, 172);
            cboThanhToan.Name = "cboThanhToan";
            cboThanhToan.Size = new Size(151, 31);
            cboThanhToan.TabIndex = 7;
            cboThanhToan.SelectedIndexChanged += cboThanhToan_SelectedIndexChanged;
            // 
            // picQR
            // 
            picQR.Image = (Image)resources.GetObject("picQR.Image");
            picQR.Location = new Point(235, 26);
            picQR.Name = "picQR";
            picQR.Size = new Size(176, 159);
            picQR.SizeMode = PictureBoxSizeMode.StretchImage;
            picQR.TabIndex = 8;
            picQR.TabStop = false;
            picQR.Visible = false;
            // 
            // lblLoaiKH
            // 
            lblLoaiKH.AutoSize = true;
            lblLoaiKH.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lblLoaiKH.Location = new Point(12, 130);
            lblLoaiKH.Name = "lblLoaiKH";
            lblLoaiKH.Size = new Size(78, 20);
            lblLoaiKH.TabIndex = 9;
            lblLoaiKH.Text = "Loại KH";
            // 
            // lblDiem
            // 
            lblDiem.AutoSize = true;
            lblDiem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblDiem.Location = new Point(15, 188);
            lblDiem.Name = "lblDiem";
            lblDiem.Size = new Size(54, 23);
            lblDiem.TabIndex = 10;
            lblDiem.Text = "Điểm";
            // 
            // lblTenKH
            // 
            lblTenKH.AutoSize = true;
            lblTenKH.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTenKH.Location = new Point(6, 82);
            lblTenKH.Name = "lblTenKH";
            lblTenKH.Size = new Size(94, 20);
            lblTenKH.TabIndex = 12;
            lblTenKH.Text = "Tên Khách";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Ivory;
            groupBox1.Controls.Add(lblBatDau);
            groupBox1.Controls.Add(lblKetThuc);
            groupBox1.Controls.Add(lblThoiGian);
            groupBox1.Controls.Add(lblGiaBan);
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(434, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(484, 236);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thời Gian Chơi";
            // 
            // txtTienKhach
            // 
            txtTienKhach.Location = new Point(6, 53);
            txtTienKhach.Name = "txtTienKhach";
            txtTienKhach.Size = new Size(167, 30);
            txtTienKhach.TabIndex = 9;
            txtTienKhach.TextChanged += txtTienKhach_TextChanged;
            // 
            // lblTienThua
            // 
            lblTienThua.AutoSize = true;
            lblTienThua.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblTienThua.Location = new Point(9, 109);
            lblTienThua.Name = "lblTienThua";
            lblTienThua.Size = new Size(98, 23);
            lblTienThua.TabIndex = 8;
            lblTienThua.Text = "Tiền Thừa";
            // 
            // lblGiamGia
            // 
            lblGiamGia.AutoSize = true;
            lblGiamGia.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblGiamGia.Location = new Point(15, 91);
            lblGiamGia.Name = "lblGiamGia";
            lblGiamGia.Size = new Size(92, 23);
            lblGiamGia.TabIndex = 7;
            lblGiamGia.Text = "Giảm Giá";
            // 
            // lblTienGoc
            // 
            lblTienGoc.AutoSize = true;
            lblTienGoc.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblTienGoc.Location = new Point(15, 32);
            lblTienGoc.Name = "lblTienGoc";
            lblTienGoc.Size = new Size(88, 23);
            lblTienGoc.TabIndex = 6;
            lblTienGoc.Text = "Tiền Gốc";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Snow;
            groupBox2.Controls.Add(lblBan);
            groupBox2.Controls.Add(lblUuDai);
            groupBox2.Controls.Add(txtSDT);
            groupBox2.Controls.Add(lblTenKH);
            groupBox2.Controls.Add(lblDiem);
            groupBox2.Controls.Add(lblLoaiKH);
            groupBox2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(416, 236);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin Khách Hàng";
            // 
            // lblBan
            // 
            lblBan.AutoSize = true;
            lblBan.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBan.Location = new Point(258, 39);
            lblBan.Name = "lblBan";
            lblBan.Size = new Size(43, 23);
            lblBan.TabIndex = 16;
            lblBan.Text = "Bàn";
            // 
            // lblUuDai
            // 
            lblUuDai.AutoSize = true;
            lblUuDai.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblUuDai.Location = new Point(164, 185);
            lblUuDai.Name = "lblUuDai";
            lblUuDai.Size = new Size(70, 23);
            lblUuDai.TabIndex = 15;
            lblUuDai.Text = "Ưu Đãi";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(6, 39);
            txtSDT.Name = "txtSDT";
            txtSDT.PlaceholderText = "Nhập SĐT (nếu có hội viên)";
            txtSDT.Size = new Size(205, 30);
            txtSDT.TabIndex = 14;
            txtSDT.TextChanged += txtSDT_TextChanged;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(801, 697);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(117, 44);
            btnDong.TabIndex = 72;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.AliceBlue;
            groupBox3.Controls.Add(lblTienBanHienTai);
            groupBox3.Controls.Add(lblGhiChuBanCu);
            groupBox3.Controls.Add(lblTienBanCu);
            groupBox3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox3.Location = new Point(12, 267);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(491, 237);
            groupBox3.TabIndex = 73;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tính Tiền";
            // 
            // lblTienBanHienTai
            // 
            lblTienBanHienTai.AutoSize = true;
            lblTienBanHienTai.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTienBanHienTai.Location = new Point(15, 51);
            lblTienBanHienTai.Name = "lblTienBanHienTai";
            lblTienBanHienTai.Size = new Size(164, 23);
            lblTienBanHienTai.TabIndex = 75;
            lblTienBanHienTai.Text = "Tiền Bàn Hiện Tại";
            // 
            // lblGhiChuBanCu
            // 
            lblGhiChuBanCu.AutoSize = true;
            lblGhiChuBanCu.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblGhiChuBanCu.Location = new Point(15, 155);
            lblGhiChuBanCu.Name = "lblGhiChuBanCu";
            lblGhiChuBanCu.Size = new Size(148, 23);
            lblGhiChuBanCu.TabIndex = 74;
            lblGhiChuBanCu.Text = "Ghi Chú Bàn Cũ";
            // 
            // lblTienBanCu
            // 
            lblTienBanCu.AutoSize = true;
            lblTienBanCu.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblTienBanCu.Location = new Point(15, 104);
            lblTienBanCu.Name = "lblTienBanCu";
            lblTienBanCu.Size = new Size(115, 23);
            lblTienBanCu.TabIndex = 73;
            lblTienBanCu.Text = "Tiền Bàn Cũ";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.ButtonHighlight;
            groupBox4.Controls.Add(lblTienGoc);
            groupBox4.Controls.Add(lblGiamGia);
            groupBox4.Controls.Add(lblTongTien);
            groupBox4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox4.Location = new Point(550, 267);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(368, 237);
            groupBox4.TabIndex = 76;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tổng Tiền";
            // 
            // groupBox5
            // 
            groupBox5.BackColor = SystemColors.ControlLightLight;
            groupBox5.Controls.Add(txtTienKhach);
            groupBox5.Controls.Add(lblTienThua);
            groupBox5.Controls.Add(picQR);
            groupBox5.Controls.Add(cboThanhToan);
            groupBox5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox5.Location = new Point(18, 527);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(443, 234);
            groupBox5.TabIndex = 77;
            groupBox5.TabStop = false;
            groupBox5.Text = "Thanh Toán";
            // 
            // FrmTinhTien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(962, 798);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnThanhToan);
            Controls.Add(btnDong);
            Name = "FrmTinhTien";
            Text = "Tính Tiền";
            Load += FrmTinhTien_Load;
            ((System.ComponentModel.ISupportInitialize)picQR).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblBatDau;
        private Label lblKetThuc;
        private Label lblThoiGian;
        private Label lblGiaBan;
        private Label lblTongTien;
        private Button btnThanhToan;
        private ComboBox cboThanhToan;
        private PictureBox picQR;
        private Label lblLoaiKH;
        private Label lblDiem;
        private Label lblTenKH;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtSDT;
        private Label lblUuDai;
        private Label lblGiamGia;
        private Label lblTienGoc;
        private Label lblBan;
        private TextBox txtTienKhach;
        private Label lblTienThua;
        private Button btnDong;
        private GroupBox groupBox3;
        private Label lblGhiChuBanCu;
        private Label lblTienBanCu;
        private Label lblTienBanHienTai;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
    }
}