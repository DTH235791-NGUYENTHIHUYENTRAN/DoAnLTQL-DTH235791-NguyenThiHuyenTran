namespace QuanLyTienGioBBD
{
    partial class FrmDichVu
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
            lblthongtin = new Label();
            lbltenDV = new Label();
            lblDonGia = new Label();
            lblSoLuong = new Label();
            txttenDv = new TextBox();
            txtDonGia = new TextBox();
            txtSoLuong = new TextBox();
            groupBox1 = new GroupBox();
            dgvDichVu = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnHuyBo = new Button();
            btnThoat = new Button();
            TenDichVu = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDichVu).BeginInit();
            SuspendLayout();
            // 
            // lblthongtin
            // 
            lblthongtin.AutoSize = true;
            lblthongtin.Location = new Point(17, 18);
            lblthongtin.Name = "lblthongtin";
            lblthongtin.Size = new Size(130, 20);
            lblthongtin.TabIndex = 0;
            lblthongtin.Text = "Thông Tin Dịch Vụ";
            // 
            // lbltenDV
            // 
            lbltenDV.AutoSize = true;
            lbltenDV.Location = new Point(19, 62);
            lbltenDV.Name = "lbltenDV";
            lbltenDV.Size = new Size(87, 20);
            lbltenDV.TabIndex = 1;
            lbltenDV.Text = "Tên Dịch Vụ";
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Location = new Point(24, 112);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(63, 20);
            lblDonGia.TabIndex = 2;
            lblDonGia.Text = "Đơn Giá";
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(24, 165);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(72, 20);
            lblSoLuong.TabIndex = 3;
            lblSoLuong.Text = "Số Lượng";
            // 
            // txttenDv
            // 
            txttenDv.Location = new Point(112, 62);
            txttenDv.Name = "txttenDv";
            txttenDv.Size = new Size(169, 27);
            txttenDv.TabIndex = 4;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(112, 109);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(169, 27);
            txtDonGia.TabIndex = 5;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(112, 162);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(169, 27);
            txtSoLuong.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvDichVu);
            groupBox1.Location = new Point(12, 220);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(763, 218);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh Sách Sản Phẩm";
            // 
            // dgvDichVu
            // 
            dgvDichVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDichVu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDichVu.Columns.AddRange(new DataGridViewColumn[] { TenDichVu, DonGia, SoLuong });
            dgvDichVu.Location = new Point(12, 24);
            dgvDichVu.Name = "dgvDichVu";
            dgvDichVu.RowHeadersWidth = 51;
            dgvDichVu.Size = new Size(745, 188);
            dgvDichVu.TabIndex = 0;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(363, 53);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(364, 107);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(364, 156);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(520, 43);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 11;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(520, 103);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(94, 29);
            btnHuyBo.TabIndex = 12;
            btnHuyBo.Text = "Hủy Bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(520, 156);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 13;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // TenDichVu
            // 
            TenDichVu.DataPropertyName = "TenDichVu";
            TenDichVu.HeaderText = "Tên Dịch Vụ";
            TenDichVu.MinimumWidth = 6;
            TenDichVu.Name = "TenDichVu";
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            DonGia.HeaderText = "Đơn Giá";
            DonGia.MinimumWidth = 6;
            DonGia.Name = "DonGia";
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số Lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            // 
            // FrmDichVu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnHuyBo);
            Controls.Add(btnLuu);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(groupBox1);
            Controls.Add(txtSoLuong);
            Controls.Add(txtDonGia);
            Controls.Add(txttenDv);
            Controls.Add(lblSoLuong);
            Controls.Add(lblDonGia);
            Controls.Add(lbltenDV);
            Controls.Add(lblthongtin);
            Name = "FrmDichVu";
            Text = "FrmDichVu";
            Load += FrmDichVu_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDichVu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblthongtin;
        private Label lbltenDV;
        private Label lblDonGia;
        private Label lblSoLuong;
        private TextBox txttenDv;
        private TextBox txtDonGia;
        private TextBox txtSoLuong;
        private GroupBox groupBox1;
        private DataGridView dgvDichVu;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnHuyBo;
        private Button btnThoat;
        private DataGridViewTextBoxColumn TenDichVu;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn SoLuong;
    }
}