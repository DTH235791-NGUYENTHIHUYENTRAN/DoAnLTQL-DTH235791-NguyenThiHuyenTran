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
            groupBoxThuong.SuspendLayout();
            groupBoxThongTin.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelThuong
            // 
            flowLayoutPanelThuong.Dock = DockStyle.Fill;
            flowLayoutPanelThuong.Location = new Point(3, 23);
            flowLayoutPanelThuong.Name = "flowLayoutPanelThuong";
            flowLayoutPanelThuong.Size = new Size(726, 250);
            flowLayoutPanelThuong.TabIndex = 1;
            // 
            // groupBoxThuong
            // 
            groupBoxThuong.Controls.Add(flowLayoutPanelThuong);
            groupBoxThuong.Location = new Point(29, 21);
            groupBoxThuong.Name = "groupBoxThuong";
            groupBoxThuong.Size = new Size(732, 276);
            groupBoxThuong.TabIndex = 2;
            groupBoxThuong.TabStop = false;
            groupBoxThuong.Text = "Bàn Bida";
            // 
            // groupBoxThongTin
            // 
            groupBoxThongTin.Controls.Add(lblLoaiBan);
            groupBoxThongTin.Controls.Add(cboLoaiBan);
            groupBoxThongTin.Controls.Add(cboTrangThai);
            groupBoxThongTin.Controls.Add(txtTenBan);
            groupBoxThongTin.Controls.Add(label3);
            groupBoxThongTin.Controls.Add(lblTenban);
            groupBoxThongTin.Location = new Point(32, 303);
            groupBoxThongTin.Name = "groupBoxThongTin";
            groupBoxThongTin.Size = new Size(733, 148);
            groupBoxThongTin.TabIndex = 4;
            groupBoxThongTin.TabStop = false;
            groupBoxThongTin.Text = "Thông Tin Bàn";
            // 
            // lblLoaiBan
            // 
            lblLoaiBan.AutoSize = true;
            lblLoaiBan.Location = new Point(281, 35);
            lblLoaiBan.Name = "lblLoaiBan";
            lblLoaiBan.Size = new Size(69, 20);
            lblLoaiBan.TabIndex = 7;
            lblLoaiBan.Text = "Loại Bàn:";
            // 
            // cboLoaiBan
            // 
            cboLoaiBan.FormattingEnabled = true;
            cboLoaiBan.Location = new Point(370, 26);
            cboLoaiBan.Name = "cboLoaiBan";
            cboLoaiBan.Size = new Size(151, 28);
            cboLoaiBan.TabIndex = 6;
            // 
            // cboTrangThai
            // 
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(96, 87);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(151, 28);
            cboTrangThai.TabIndex = 5;
            // 
            // txtTenBan
            // 
            txtTenBan.Location = new Point(96, 35);
            txtTenBan.Name = "txtTenBan";
            txtTenBan.Size = new Size(155, 27);
            txtTenBan.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 86);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 2;
            label3.Text = "Trạng Thái:";
            // 
            // lblTenban
            // 
            lblTenban.AutoSize = true;
            lblTenban.Location = new Point(15, 35);
            lblTenban.Name = "lblTenban";
            lblTenban.Size = new Size(64, 20);
            lblTenban.TabIndex = 1;
            lblTenban.Text = "Tên Bàn:";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(791, 44);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(791, 106);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(791, 173);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnBatDau
            // 
            btnBatDau.Location = new Point(791, 241);
            btnBatDau.Name = "btnBatDau";
            btnBatDau.Size = new Size(94, 29);
            btnBatDau.TabIndex = 8;
            btnBatDau.Text = "Bắt Đầu";
            btnBatDau.UseVisualStyleBackColor = true;
            btnBatDau.Click += btnBatDau_Click;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(791, 312);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(94, 29);
            btnThanhToan.TabIndex = 9;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(799, 389);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(94, 29);
            btnHuyBo.TabIndex = 10;
            btnHuyBo.Text = "Hủy Bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // FrmQuanLyBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 575);
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
    }
}