namespace QuanLyTienGioBBD
{
    partial class FrmBanBiDa
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblLoaiBan = new Label();
            lblTenLoaiBan = new Label();
            lblGia = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnHuy = new Button();
            dgvLoaiBan = new DataGridView();
            groupBox1 = new GroupBox();
            txtTen = new TextBox();
            txtGia = new TextBox();
            btnThoat = new Button();
            TenLoaiBan = new DataGridViewTextBoxColumn();
            Idd = new DataGridViewTextBoxColumn();
            GiaMoiGIo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiBan).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblLoaiBan
            // 
            lblLoaiBan.AutoSize = true;
            lblLoaiBan.Location = new Point(12, 21);
            lblLoaiBan.Name = "lblLoaiBan";
            lblLoaiBan.Size = new Size(136, 20);
            lblLoaiBan.TabIndex = 0;
            lblLoaiBan.Text = "Thông Tin Loại Bàn";
            // 
            // lblTenLoaiBan
            // 
            lblTenLoaiBan.AutoSize = true;
            lblTenLoaiBan.Location = new Point(21, 55);
            lblTenLoaiBan.Name = "lblTenLoaiBan";
            lblTenLoaiBan.Size = new Size(93, 20);
            lblTenLoaiBan.TabIndex = 1;
            lblTenLoaiBan.Text = "Tên Loại Bàn";
            // 
            // lblGia
            // 
            lblGia.AutoSize = true;
            lblGia.Location = new Point(26, 90);
            lblGia.Name = "lblGia";
            lblGia.Size = new Size(88, 20);
            lblGia.TabIndex = 2;
            lblGia.Text = "Giá Mỗi Giờ";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(374, 21);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(374, 81);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(509, 21);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(509, 81);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 6;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(636, 21);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 7;
            btnHuy.Text = "Hủy Bỏ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // dgvLoaiBan
            // 
            dgvLoaiBan.AllowUserToAddRows = false;
            dgvLoaiBan.AllowUserToDeleteRows = false;
            dgvLoaiBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoaiBan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiBan.Columns.AddRange(new DataGridViewColumn[] { TenLoaiBan, Idd, GiaMoiGIo });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvLoaiBan.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLoaiBan.Location = new Point(9, 26);
            dgvLoaiBan.Name = "dgvLoaiBan";
            dgvLoaiBan.RowHeadersWidth = 51;
            dgvLoaiBan.Size = new Size(788, 260);
            dgvLoaiBan.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvLoaiBan);
            groupBox1.Location = new Point(12, 138);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 300);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh Sách Loại Bàn";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(134, 55);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(185, 27);
            txtTen.TabIndex = 10;
            // 
            // txtGia
            // 
            txtGia.Location = new Point(134, 90);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(185, 27);
            txtGia.TabIndex = 11;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(636, 81);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 12;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // TenLoaiBan
            // 
            TenLoaiBan.DataPropertyName = "TenLoaiBan";
            TenLoaiBan.HeaderText = "Tên Loại Bàn";
            TenLoaiBan.MinimumWidth = 6;
            TenLoaiBan.Name = "TenLoaiBan";
            // 
            // Idd
            // 
            Idd.DataPropertyName = "ID";
            Idd.HeaderText = "ID";
            Idd.MinimumWidth = 6;
            Idd.Name = "Idd";
            // 
            // GiaMoiGIo
            // 
            GiaMoiGIo.DataPropertyName = "GiaTienGio";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            GiaMoiGIo.DefaultCellStyle = dataGridViewCellStyle1;
            GiaMoiGIo.HeaderText = "Giá Mỗi Giờ";
            GiaMoiGIo.MinimumWidth = 6;
            GiaMoiGIo.Name = "GiaMoiGIo";
            // 
            // FrmBanBiDa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(txtGia);
            Controls.Add(txtTen);
            Controls.Add(groupBox1);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(lblGia);
            Controls.Add(lblTenLoaiBan);
            Controls.Add(lblLoaiBan);
            Name = "FrmBanBiDa";
            Text = "FrmBanBiDa";
            Load += FrmBanBiDa_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLoaiBan).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLoaiBan;
        private Label lblTenLoaiBan;
        private Label lblGia;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnHuy;
        private DataGridView dgvLoaiBan;
        private GroupBox groupBox1;
        private TextBox txtTen;
        private TextBox txtGia;
        private Button btnThoat;
        private DataGridViewTextBoxColumn TenLoaiBan;
        private DataGridViewTextBoxColumn Idd;
        private DataGridViewTextBoxColumn GiaMoiGIo;
    }
}