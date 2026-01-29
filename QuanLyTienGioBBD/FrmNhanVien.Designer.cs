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
            btnXuat = new Button();
            btnThoat = new Button();
            btnXoa = new Button();
            btnNhap = new Button();
            btnTimKiem = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            groupBox1 = new GroupBox();
            cboQuyenHan = new ComboBox();
            btnThem = new Button();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            txtDienThoai = new TextBox();
            txtDiaChi = new TextBox();
            label4 = new Label();
            label6 = new Label();
            txtHoVaTen = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            TenDangNhap = new DataGridViewTextBoxColumn();
            QuyenHan = new DataGridViewTextBoxColumn();
            HoVaTen = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(694, 96);
            btnXuat.Margin = new Padding(2);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(112, 27);
            btnXuat.TabIndex = 2;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(617, 96);
            btnThoat.Margin = new Padding(2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(70, 27);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.Brown;
            btnXoa.Location = new Point(534, 96);
            btnXoa.Margin = new Padding(2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(70, 27);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(694, 64);
            btnNhap.Margin = new Padding(2);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(112, 27);
            btnNhap.TabIndex = 2;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(694, 32);
            btnTimKiem.Margin = new Padding(2);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(112, 27);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(617, 64);
            btnHuyBo.Margin = new Padding(2);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(70, 27);
            btnHuyBo.TabIndex = 2;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(617, 32);
            btnLuu.Margin = new Padding(2);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(70, 27);
            btnLuu.TabIndex = 2;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(534, 64);
            btnSua.Margin = new Padding(2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(70, 27);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboQuyenHan);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(21, 11);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(911, 142);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên:";
            // 
            // cboQuyenHan
            // 
            cboQuyenHan.FormattingEnabled = true;
            cboQuyenHan.Items.AddRange(new object[] { "Quản lý", "Nhân viên" });
            cboQuyenHan.Location = new Point(379, 110);
            cboQuyenHan.Margin = new Padding(2);
            cboQuyenHan.Name = "cboQuyenHan";
            cboQuyenHan.Size = new Size(146, 28);
            cboQuyenHan.TabIndex = 3;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(534, 32);
            btnThem.Margin = new Padding(2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(70, 27);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
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
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(379, 26);
            txtTenDangNhap.Margin = new Padding(2);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(146, 27);
            txtTenDangNhap.TabIndex = 1;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(100, 111);
            txtDienThoai.Margin = new Padding(2);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(154, 27);
            txtDienThoai.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(100, 68);
            txtDiaChi.Margin = new Padding(2);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(154, 27);
            txtDiaChi.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 113);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 0;
            label4.Text = "Điện Thoại:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(257, 113);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 0;
            label6.Text = "Quyền hạn (*):";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 69);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 0;
            label3.Text = "Địa chỉ:";
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
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(16, 157);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(918, 533);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { TenDangNhap, QuyenHan, HoVaTen, DienThoai, DiaChi });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(2, 22);
            dataGridView.Margin = new Padding(2);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.Size = new Size(914, 509);
            dataGridView.TabIndex = 0;
            // 
            // TenDangNhap
            // 
            TenDangNhap.DataPropertyName = "TenDangNhap";
            TenDangNhap.FillWeight = 106.363686F;
            TenDangNhap.HeaderText = "Tên Đăng Nhập";
            TenDangNhap.MinimumWidth = 8;
            TenDangNhap.Name = "TenDangNhap";
            // 
            // QuyenHan
            // 
            QuyenHan.DataPropertyName = "QuyenHan";
            QuyenHan.FillWeight = 106.363686F;
            QuyenHan.HeaderText = "Quyền Hạn";
            QuyenHan.MinimumWidth = 8;
            QuyenHan.Name = "QuyenHan";
            // 
            // HoVaTen
            // 
            HoVaTen.DataPropertyName = "HoVaTen";
            HoVaTen.FillWeight = 106.363686F;
            HoVaTen.HeaderText = "Họ Và Tên";
            HoVaTen.MinimumWidth = 8;
            HoVaTen.Name = "HoVaTen";
            // 
            // DienThoai
            // 
            DienThoai.DataPropertyName = "DienThoai";
            DienThoai.FillWeight = 106.363686F;
            DienThoai.HeaderText = "Điện Thoại";
            DienThoai.MinimumWidth = 8;
            DienThoai.Name = "DienThoai";
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.FillWeight = 106.363686F;
            DiaChi.HeaderText = "Địa Chỉ";
            DiaChi.MinimumWidth = 8;
            DiaChi.Name = "DiaChi";
            // 
            // FrmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 450);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "FrmNhanVien";
            Text = "FrmNhanVien";
            Load += FrmNhanVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
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
        private Button btnSua;
        private GroupBox groupBox1;
        private ComboBox cboQuyenHan;
        private Button btnThem;
        private TextBox txtMatKhau;
        private TextBox txtTenDangNhap;
        private TextBox txtDienThoai;
        private TextBox txtDiaChi;
        private Label label4;
        private Label label6;
        private TextBox txtHoVaTen;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewTextBoxColumn QuyenHan;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn DiaChi;
    }
}