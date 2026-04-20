namespace QuanLyTienGioBBD.Forms
{
    partial class FrmQuanLyBan
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
            flowLayoutPanelThuong = new FlowLayoutPanel();
            groupBoxThuong = new GroupBox();
            groupBoxThongTin = new GroupBox();
            lblLoaiBan = new Label();
            cboLoaiBan = new ComboBox();
            cboTrangThai = new ComboBox();
            txtTenBan = new TextBox();
            label3 = new Label();
            lblTenban = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnBatDau = new Button();
            btnThanhToan = new Button();
            btnHuyBo = new Button();
            btnChuyenBan = new Button();
            button1 = new Button();
            groupBoxThuong.SuspendLayout();
            groupBoxThongTin.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelThuong
            // 
            flowLayoutPanelThuong.Dock = DockStyle.Fill;
            flowLayoutPanelThuong.Location = new Point(3, 26);
            flowLayoutPanelThuong.Name = "flowLayoutPanelThuong";
            flowLayoutPanelThuong.Size = new Size(726, 247);
            flowLayoutPanelThuong.TabIndex = 1;
            // 
            // groupBoxThuong
            // 
            groupBoxThuong.Controls.Add(flowLayoutPanelThuong);
            groupBoxThuong.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBoxThuong.Location = new Point(29, 21);
            groupBoxThuong.Name = "groupBoxThuong";
            groupBoxThuong.Size = new Size(732, 276);
            groupBoxThuong.TabIndex = 2;
            groupBoxThuong.TabStop = false;
            groupBoxThuong.Text = "Bàn Bida";
            // 
            // groupBoxThongTin
            // 
            groupBoxThongTin.BackColor = Color.Pink;
            groupBoxThongTin.Controls.Add(lblLoaiBan);
            groupBoxThongTin.Controls.Add(cboLoaiBan);
            groupBoxThongTin.Controls.Add(cboTrangThai);
            groupBoxThongTin.Controls.Add(txtTenBan);
            groupBoxThongTin.Controls.Add(label3);
            groupBoxThongTin.Controls.Add(lblTenban);
            groupBoxThongTin.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBoxThongTin.Location = new Point(25, 335);
            groupBoxThongTin.Name = "groupBoxThongTin";
            groupBoxThongTin.Size = new Size(733, 219);
            groupBoxThongTin.TabIndex = 4;
            groupBoxThongTin.TabStop = false;
            groupBoxThongTin.Text = "Thông Tin Bàn";
            // 
            // lblLoaiBan
            // 
            lblLoaiBan.AutoSize = true;
            lblLoaiBan.Location = new Point(377, 90);
            lblLoaiBan.Name = "lblLoaiBan";
            lblLoaiBan.Size = new Size(93, 23);
            lblLoaiBan.TabIndex = 7;
            lblLoaiBan.Text = "Loại Bàn:";
            // 
            // cboLoaiBan
            // 
            cboLoaiBan.FormattingEnabled = true;
            cboLoaiBan.Location = new Point(486, 82);
            cboLoaiBan.Name = "cboLoaiBan";
            cboLoaiBan.Size = new Size(151, 31);
            cboLoaiBan.TabIndex = 6;
            // 
            // cboTrangThai
            // 
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(145, 125);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(176, 31);
            cboTrangThai.TabIndex = 5;
            // 
            // txtTenBan
            // 
            txtTenBan.Location = new Point(145, 56);
            txtTenBan.Name = "txtTenBan";
            txtTenBan.Size = new Size(176, 30);
            txtTenBan.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 125);
            label3.Name = "label3";
            label3.Size = new Size(110, 23);
            label3.TabIndex = 2;
            label3.Text = "Trạng Thái:";
            // 
            // lblTenban
            // 
            lblTenban.AutoSize = true;
            lblTenban.Location = new Point(15, 59);
            lblTenban.Name = "lblTenban";
            lblTenban.Size = new Size(87, 23);
            lblTenban.TabIndex = 1;
            lblTenban.Text = "Tên Bàn:";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.DeepPink;
            btnThem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnThem.Location = new Point(25, 601);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(104, 36);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.DeepPink;
            btnSua.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSua.Location = new Point(170, 601);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(104, 35);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.DeepPink;
            btnXoa.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnXoa.Location = new Point(317, 601);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(104, 35);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnBatDau
            // 
            btnBatDau.BackColor = Color.DeepPink;
            btnBatDau.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnBatDau.Location = new Point(232, 661);
            btnBatDau.Name = "btnBatDau";
            btnBatDau.Size = new Size(104, 40);
            btnBatDau.TabIndex = 8;
            btnBatDau.Text = "Bắt Đầu";
            btnBatDau.UseVisualStyleBackColor = false;
            btnBatDau.Click += btnBatDau_Click;
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = Color.DeepPink;
            btnThanhToan.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnThanhToan.Location = new Point(414, 664);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(127, 37);
            btnThanhToan.TabIndex = 9;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.DeepPink;
            btnHuyBo.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnHuyBo.Location = new Point(682, 593);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(115, 43);
            btnHuyBo.TabIndex = 10;
            btnHuyBo.Text = "Hủy Bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnChuyenBan
            // 
            btnChuyenBan.BackColor = Color.DeepPink;
            btnChuyenBan.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnChuyenBan.Location = new Point(491, 597);
            btnChuyenBan.Name = "btnChuyenBan";
            btnChuyenBan.Size = new Size(127, 39);
            btnChuyenBan.TabIndex = 11;
            btnChuyenBan.Text = "Chuyển Bàn";
            btnChuyenBan.UseVisualStyleBackColor = false;
            btnChuyenBan.Click += btnChuyenBan_Click;
            // 
            // button1
            // 
            button1.Location = new Point(864, 535);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 12;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // FrmQuanLyBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(809, 738);
            Controls.Add(button1);
            Controls.Add(btnChuyenBan);
            Controls.Add(btnHuyBo);
            Controls.Add(btnThanhToan);
            Controls.Add(btnBatDau);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(groupBoxThongTin);
            Controls.Add(groupBoxThuong);
            Name = "FrmQuanLyBan";
            Text = "FrmQuanLyBan";
            Load += FrmQuanLyBan_Load;
            groupBoxThuong.ResumeLayout(false);
            groupBoxThongTin.ResumeLayout(false);
            groupBoxThongTin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanelThuong;
        private GroupBox groupBoxThuong;
        private GroupBox groupBoxThongTin;
        private TextBox txtTenBan;
        private Label label3;
        private Label lblTenban;
        private ComboBox cboTrangThai;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnBatDau;
        private Button btnThanhToan;
        private Label lblLoaiBan;
        private ComboBox cboLoaiBan;
        private Button btnHuyBo;
        private Button btnChuyenBan;
        private Button button1;
    }
}