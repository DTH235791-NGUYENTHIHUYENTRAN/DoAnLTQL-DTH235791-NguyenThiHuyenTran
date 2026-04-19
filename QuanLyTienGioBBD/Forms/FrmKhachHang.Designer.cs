namespace QuanLyTienGioBBD.Forms
{
    partial class FrmKhachHang
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
            btntk = new Button();
            dgvKhachHang = new DataGridView();
            btnXoa = new Button();
            btnHuybo = new Button();
            btnLuu = new Button();
            btnThem = new Button();
            txtDienThoai = new TextBox();
            txtTenKH = new TextBox();
            lbldt = new Label();
            lblHoTen = new Label();
            btnSua = new Button();
            lblKhach = new Label();
            cboLoaiKH = new ComboBox();
            groupBox1 = new GroupBox();
            txtUuDai = new TextBox();
            txtDiem = new TextBox();
            txtMaKH = new TextBox();
            lblUuDai = new Label();
            lblDiem = new Label();
            lblMaKh = new Label();
            txtTimKiem = new TextBox();
            btnXuat = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btntk
            // 
            btntk.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btntk.Location = new Point(12, 208);
            btntk.Name = "btntk";
            btntk.Size = new Size(127, 29);
            btntk.TabIndex = 49;
            btntk.Text = "Tìm Kiếm";
            btntk.UseVisualStyleBackColor = true;
            btntk.Click += btntk_Click;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.AllowUserToDeleteRows = false;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Location = new Point(24, 297);
            dgvKhachHang.MultiSelect = false;
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.Size = new Size(804, 232);
            dgvKhachHang.TabIndex = 48;
            dgvKhachHang.CellClick += dgvKhachHang_CellClick;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnXoa.Location = new Point(673, 251);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 45;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnHuybo
            // 
            btnHuybo.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnHuybo.Location = new Point(397, 252);
            btnHuybo.Name = "btnHuybo";
            btnHuybo.Size = new Size(94, 29);
            btnHuybo.TabIndex = 43;
            btnHuybo.Text = "Hủy bỏ";
            btnHuybo.UseVisualStyleBackColor = true;
            btnHuybo.Click += btnHuybo_Click;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnLuu.Location = new Point(263, 252);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 41;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnThem.Location = new Point(24, 252);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 40;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            txtDienThoai.Location = new Point(180, 69);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(217, 30);
            txtDienThoai.TabIndex = 39;
            // 
            // txtTenKH
            // 
            txtTenKH.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            txtTenKH.Location = new Point(180, 23);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(217, 30);
            txtTenKH.TabIndex = 38;
            // 
            // lbldt
            // 
            lbldt.AutoSize = true;
            lbldt.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lbldt.Location = new Point(12, 69);
            lbldt.Name = "lbldt";
            lbldt.Size = new Size(102, 23);
            lbldt.TabIndex = 36;
            lbldt.Text = "Điện Thoại";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblHoTen.Location = new Point(12, 30);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(150, 23);
            lblHoTen.TabIndex = 35;
            lblHoTen.Text = "Tên Khách Hàng";
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnSua.Location = new Point(136, 252);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 42;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // lblKhach
            // 
            lblKhach.AutoSize = true;
            lblKhach.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblKhach.Location = new Point(12, 121);
            lblKhach.Name = "lblKhach";
            lblKhach.Size = new Size(78, 20);
            lblKhach.TabIndex = 50;
            lblKhach.Text = "Loại KH";
            // 
            // cboLoaiKH
            // 
            cboLoaiKH.FormattingEnabled = true;
            cboLoaiKH.Location = new Point(180, 113);
            cboLoaiKH.Name = "cboLoaiKH";
            cboLoaiKH.Size = new Size(217, 28);
            cboLoaiKH.TabIndex = 51;
            cboLoaiKH.SelectedIndexChanged += cboLoaiKH_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtUuDai);
            groupBox1.Controls.Add(txtDiem);
            groupBox1.Controls.Add(lblKhach);
            groupBox1.Controls.Add(cboLoaiKH);
            groupBox1.Controls.Add(txtMaKH);
            groupBox1.Controls.Add(lblUuDai);
            groupBox1.Controls.Add(lblDiem);
            groupBox1.Controls.Add(lblMaKh);
            groupBox1.Controls.Add(lblHoTen);
            groupBox1.Controls.Add(txtTenKH);
            groupBox1.Controls.Add(lbldt);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(12, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(662, 167);
            groupBox1.TabIndex = 52;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // txtUuDai
            // 
            txtUuDai.Location = new Point(510, 126);
            txtUuDai.Name = "txtUuDai";
            txtUuDai.Size = new Size(125, 28);
            txtUuDai.TabIndex = 52;
            // 
            // txtDiem
            // 
            txtDiem.Location = new Point(513, 71);
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(125, 28);
            txtDiem.TabIndex = 44;
            txtDiem.KeyPress += txtDiem_KeyPress;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(513, 22);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(125, 28);
            txtMaKH.TabIndex = 43;
            // 
            // lblUuDai
            // 
            lblUuDai.AutoSize = true;
            lblUuDai.Location = new Point(429, 132);
            lblUuDai.Name = "lblUuDai";
            lblUuDai.Size = new Size(65, 20);
            lblUuDai.TabIndex = 42;
            lblUuDai.Text = "Ưu Đãi";
            // 
            // lblDiem
            // 
            lblDiem.AutoSize = true;
            lblDiem.Location = new Point(429, 79);
            lblDiem.Name = "lblDiem";
            lblDiem.Size = new Size(50, 20);
            lblDiem.TabIndex = 41;
            lblDiem.Text = "Điểm";
            // 
            // lblMaKh
            // 
            lblMaKh.AutoSize = true;
            lblMaKh.Location = new Point(429, 25);
            lblMaKh.Name = "lblMaKh";
            lblMaKh.Size = new Size(68, 20);
            lblMaKh.TabIndex = 40;
            lblMaKh.Text = "Mã KH";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(155, 210);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(213, 27);
            txtTimKiem.TabIndex = 53;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnXuat
            // 
            btnXuat.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnXuat.Location = new Point(534, 252);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 29);
            btnXuat.TabIndex = 54;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // button1
            // 
            button1.Location = new Point(712, 122);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 55;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // FrmKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 541);
            Controls.Add(button1);
            Controls.Add(btnXuat);
            Controls.Add(txtTimKiem);
            Controls.Add(groupBox1);
            Controls.Add(dgvKhachHang);
            Controls.Add(btnXoa);
            Controls.Add(btnHuybo);
            Controls.Add(btnLuu);
            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btntk);
            Name = "FrmKhachHang";
            Text = "FrmKhachHang";
            Load += FrmKhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btntk;
        private DataGridView dgvKhachHang;
        private Button btnXoa;
        private Button btnHuybo;
        private Button btnLuu;
        private Button btnThem;
        private TextBox txtDienThoai;
        private TextBox txtTenKH;
        private Label lbldt;
        private Label lblHoTen;
        private Button btnSua;
        private Label lblKhach;
        private ComboBox cboLoaiKH;
        private GroupBox groupBox1;
        private TextBox txtMaKH;
        private Label lblUuDai;
        private Label lblDiem;
        private Label lblMaKh;
        private TextBox txtDiem;
        private TextBox txtTimKiem;
        private TextBox txtUuDai;
        private Button btnXuat;
        private Button button1;
    }
}