namespace QuanLyTienGioBBD
{
    partial class FrmNhanVien
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
            btnXoa = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            groupBox1 = new GroupBox();
            btnSua = new Button();
            cboChucVu = new ComboBox();
            lblMaNV = new Label();
            txtMaNV = new TextBox();
            btnThem = new Button();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            txtSoDienThoai = new TextBox();
            label4 = new Label();
            lblChucVu = new Label();
            txtHoVaTen = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvNhanVien = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.Brown;
            btnXoa.Location = new Point(534, 70);
            btnXoa.Margin = new Padding(2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(87, 27);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "❌Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(652, 70);
            btnHuyBo.Margin = new Padding(2);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(70, 27);
            btnHuyBo.TabIndex = 2;
            btnHuyBo.Text = "🚫Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(652, 32);
            btnLuu.Margin = new Padding(2);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(70, 27);
            btnLuu.TabIndex = 2;
            btnLuu.Text = "💾Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(cboChucVu);
            groupBox1.Controls.Add(lblMaNV);
            groupBox1.Controls.Add(txtMaNV);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Controls.Add(txtSoDienThoai);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblChucVu);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(21, 11);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(919, 142);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên:";
            // 
            // btnSua
            // 
            btnSua.Location = new Point(596, 103);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(68, 29);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // cboChucVu
            // 
            cboChucVu.FormattingEnabled = true;
            cboChucVu.Location = new Point(381, 108);
            cboChucVu.Name = "cboChucVu";
            cboChucVu.Size = new Size(151, 28);
            cboChucVu.TabIndex = 10;
            // 
            // lblMaNV
            // 
            lblMaNV.AutoSize = true;
            lblMaNV.Location = new Point(18, 106);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(54, 20);
            lblMaNV.TabIndex = 9;
            lblMaNV.Text = "Mã NV";
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(100, 103);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.ReadOnly = true;
            txtMaNV.Size = new Size(152, 27);
            txtMaNV.TabIndex = 8;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(534, 32);
            btnThem.Margin = new Padding(2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(87, 27);
            btnThem.TabIndex = 2;
            btnThem.Text = "➕Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(379, 67);
            txtMatKhau.Margin = new Padding(2);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(146, 27);
            txtMatKhau.TabIndex = 1;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(379, 26);
            txtTenDangNhap.Margin = new Padding(2);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(146, 27);
            txtTenDangNhap.TabIndex = 1;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(99, 64);
            txtSoDienThoai.Margin = new Padding(2);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(154, 27);
            txtSoDienThoai.TabIndex = 1;
            txtSoDienThoai.KeyPress += txtSoDienThoai_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 64);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 0;
            label4.Text = "Điện Thoại:";
            // 
            // lblChucVu
            // 
            lblChucVu.AutoSize = true;
            lblChucVu.Location = new Point(257, 110);
            lblChucVu.Margin = new Padding(2, 0, 2, 0);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new Size(66, 20);
            lblChucVu.TabIndex = 0;
            lblChucVu.Text = "Chức Vụ:";
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(100, 26);
            txtHoVaTen.Margin = new Padding(2);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(154, 27);
            txtHoVaTen.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(257, 69);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 0;
            label5.Text = "Mật khẩu (*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(257, 27);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 0;
            label2.Text = "Tên đăng nhập (*):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 27);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên (*):";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvNhanVien);
            groupBox2.Location = new Point(16, 157);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(924, 533);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AllowUserToDeleteRows = false;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.Location = new Point(2, 22);
            dgvNhanVien.Margin = new Padding(2);
            dgvNhanVien.MultiSelect = false;
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 62;
            dgvNhanVien.Size = new Size(920, 509);
            dgvNhanVien.TabIndex = 0;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            // 
            // FrmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 653);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Nhân Viên";
            Load += FrmNhanVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnXuat;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnNhap;
        private Button btnTimKiem;
        private Button btnHuyBo;
        private Button btnLuu;
        private GroupBox groupBox1;
        private ComboBox cboQuyenHan;
        private Button btnThem;
        private TextBox txtMatKhau;
        private TextBox txtTenDangNhap;
        private TextBox txtSoDienThoai;
        private Label label4;
        private Label lblChucVu;
        private TextBox txtHoVaTen;
        private Label label5;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dgvNhanVien;
        private Label lblMaNV;
        private TextBox txtMaNV;
        private ComboBox cboChucVu;
        private Button btnSua;
    }
}