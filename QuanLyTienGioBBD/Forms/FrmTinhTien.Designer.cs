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
            lblGia = new Label();
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
            lblUudai = new Label();
            txtSDT = new TextBox();
            btnDong = new Button();
            ((System.ComponentModel.ISupportInitialize)picQR).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblBatDau
            // 
            lblBatDau.AutoSize = true;
            lblBatDau.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblBatDau.Location = new Point(6, 23);
            lblBatDau.Name = "lblBatDau";
            lblBatDau.Size = new Size(109, 23);
            lblBatDau.TabIndex = 1;
            lblBatDau.Text = "Giờ bắt đầu";
            // 
            // lblKetThuc
            // 
            lblKetThuc.AutoSize = true;
            lblKetThuc.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblKetThuc.Location = new Point(6, 61);
            lblKetThuc.Name = "lblKetThuc";
            lblKetThuc.Size = new Size(117, 23);
            lblKetThuc.TabIndex = 2;
            lblKetThuc.Text = "Giờ kết thúc";
            // 
            // lblThoiGian
            // 
            lblThoiGian.AutoSize = true;
            lblThoiGian.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblThoiGian.Location = new Point(6, 102);
            lblThoiGian.Name = "lblThoiGian";
            lblThoiGian.Size = new Size(131, 23);
            lblThoiGian.TabIndex = 3;
            lblThoiGian.Text = "Tổng thời gian";
            // 
            // lblGia
            // 
            lblGia.AutoSize = true;
            lblGia.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblGia.Location = new Point(6, 142);
            lblGia.Name = "lblGia";
            lblGia.Size = new Size(79, 23);
            lblGia.TabIndex = 4;
            lblGia.Text = "Tiền giờ";
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblTongTien.Location = new Point(6, 176);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(90, 23);
            lblTongTien.TabIndex = 5;
            lblTongTien.Text = "Tổng tiền";
            // 
            // btnThanhToan
            // 
            btnThanhToan.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnThanhToan.Location = new Point(18, 505);
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
            cboThanhToan.Location = new Point(12, 229);
            cboThanhToan.Name = "cboThanhToan";
            cboThanhToan.Size = new Size(151, 31);
            cboThanhToan.TabIndex = 7;
            cboThanhToan.SelectedIndexChanged += cboThanhToan_SelectedIndexChanged;
            // 
            // picQR
            // 
            picQR.Image = (Image)resources.GetObject("picQR.Image");
            picQR.Location = new Point(9, 272);
            picQR.Name = "picQR";
            picQR.Size = new Size(154, 139);
            picQR.SizeMode = PictureBoxSizeMode.StretchImage;
            picQR.TabIndex = 8;
            picQR.TabStop = false;
            picQR.Visible = false;
            // 
            // lblLoaiKH
            // 
            lblLoaiKH.AutoSize = true;
            lblLoaiKH.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lblLoaiKH.Location = new Point(151, 82);
            lblLoaiKH.Name = "lblLoaiKH";
            lblLoaiKH.Size = new Size(78, 20);
            lblLoaiKH.TabIndex = 9;
            lblLoaiKH.Text = "Loại KH";
            // 
            // lblDiem
            // 
            lblDiem.AutoSize = true;
            lblDiem.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lblDiem.Location = new Point(6, 119);
            lblDiem.Name = "lblDiem";
            lblDiem.Size = new Size(50, 20);
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
            groupBox1.Controls.Add(txtTienKhach);
            groupBox1.Controls.Add(lblTienThua);
            groupBox1.Controls.Add(lblGiamGia);
            groupBox1.Controls.Add(lblTienGoc);
            groupBox1.Controls.Add(lblBatDau);
            groupBox1.Controls.Add(lblKetThuc);
            groupBox1.Controls.Add(lblThoiGian);
            groupBox1.Controls.Add(lblGia);
            groupBox1.Controls.Add(lblTongTien);
            groupBox1.Location = new Point(311, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 411);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thời Gian Chơi";
            // 
            // txtTienKhach
            // 
            txtTienKhach.Location = new Point(12, 287);
            txtTienKhach.Name = "txtTienKhach";
            txtTienKhach.Size = new Size(125, 27);
            txtTienKhach.TabIndex = 9;
            txtTienKhach.TextChanged += txtTienKhach_TextChanged;
            // 
            // lblTienThua
            // 
            lblTienThua.AutoSize = true;
            lblTienThua.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblTienThua.Location = new Point(12, 336);
            lblTienThua.Name = "lblTienThua";
            lblTienThua.Size = new Size(98, 23);
            lblTienThua.TabIndex = 8;
            lblTienThua.Text = "Tiền Thừa";
            // 
            // lblGiamGia
            // 
            lblGiamGia.AutoSize = true;
            lblGiamGia.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblGiamGia.Location = new Point(8, 250);
            lblGiamGia.Name = "lblGiamGia";
            lblGiamGia.Size = new Size(92, 23);
            lblGiamGia.TabIndex = 7;
            lblGiamGia.Text = "Giảm Giá";
            // 
            // lblTienGoc
            // 
            lblTienGoc.AutoSize = true;
            lblTienGoc.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblTienGoc.Location = new Point(8, 215);
            lblTienGoc.Name = "lblTienGoc";
            lblTienGoc.Size = new Size(88, 23);
            lblTienGoc.TabIndex = 6;
            lblTienGoc.Text = "Tiền Gốc";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblBan);
            groupBox2.Controls.Add(lblUudai);
            groupBox2.Controls.Add(txtSDT);
            groupBox2.Controls.Add(lblTenKH);
            groupBox2.Controls.Add(lblDiem);
            groupBox2.Controls.Add(lblLoaiKH);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(293, 200);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin Khách Hàng";
            // 
            // lblBan
            // 
            lblBan.AutoSize = true;
            lblBan.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBan.Location = new Point(154, 117);
            lblBan.Name = "lblBan";
            lblBan.Size = new Size(43, 23);
            lblBan.TabIndex = 16;
            lblBan.Text = "Bàn";
            // 
            // lblUudai
            // 
            lblUudai.AutoSize = true;
            lblUudai.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblUudai.Location = new Point(6, 158);
            lblUudai.Name = "lblUudai";
            lblUudai.Size = new Size(54, 17);
            lblUudai.TabIndex = 15;
            lblUudai.Text = "Ưu Đãi";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(6, 39);
            txtSDT.Name = "txtSDT";
            txtSDT.PlaceholderText = "Nhập SĐT (nếu có hội viên)";
            txtSDT.Size = new Size(205, 27);
            txtSDT.TabIndex = 14;
            txtSDT.TextChanged += txtSDT_TextChanged;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(378, 511);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(94, 29);
            btnDong.TabIndex = 72;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            // 
            // FrmTinhTien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 650);
            Controls.Add(btnDong);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(picQR);
            Controls.Add(cboThanhToan);
            Controls.Add(btnThanhToan);
            Name = "FrmTinhTien";
            Text = "Tính Tiền";
            Load += FrmTinhTien_Load;
            ((System.ComponentModel.ISupportInitialize)picQR).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblBatDau;
        private Label lblKetThuc;
        private Label lblThoiGian;
        private Label lblGia;
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
        private Label lblUudai;
        private Label lblGiamGia;
        private Label lblTienGoc;
        private Label lblBan;
        private TextBox txtTienKhach;
        private Label lblTienThua;
        private Button btnDong;
    }
}