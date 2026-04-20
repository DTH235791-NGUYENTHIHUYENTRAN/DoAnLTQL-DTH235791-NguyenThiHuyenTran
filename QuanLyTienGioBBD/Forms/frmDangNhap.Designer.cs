namespace QuanLyTienGioBBD.Forms
{
    partial class frmDangNhap
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
            lbldangnhap = new Label();
            lblTen = new Label();
            lblmk = new Label();
            btndn = new Button();
            btnHuybo = new Button();
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            SuspendLayout();
            // 
            // lbldangnhap
            // 
            lbldangnhap.AutoSize = true;
            lbldangnhap.BackColor = Color.Transparent;
            lbldangnhap.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbldangnhap.ForeColor = SystemColors.ControlLightLight;
            lbldangnhap.Location = new Point(160, 38);
            lbldangnhap.Name = "lbldangnhap";
            lbldangnhap.Size = new Size(152, 25);
            lbldangnhap.TabIndex = 0;
            lbldangnhap.Text = "ĐĂNG NHẬP";
            // 
            // lblTen
            // 
            lblTen.BackColor = Color.Transparent;
            lblTen.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTen.ForeColor = Color.White;
            lblTen.Location = new Point(18, 97);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(186, 35);
            lblTen.TabIndex = 1;
            lblTen.Text = "Tên Đăng Nhập:";
            // 
            // lblmk
            // 
            lblmk.BackColor = Color.Transparent;
            lblmk.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblmk.ForeColor = Color.White;
            lblmk.Location = new Point(18, 169);
            lblmk.Name = "lblmk";
            lblmk.Size = new Size(140, 31);
            lblmk.TabIndex = 2;
            lblmk.Text = "Mật khẩu:";
            // 
            // btndn
            // 
            btndn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btndn.Location = new Point(85, 228);
            btndn.Name = "btndn";
            btndn.Size = new Size(119, 37);
            btndn.TabIndex = 3;
            btndn.Text = "Đăng nhập";
            btndn.UseVisualStyleBackColor = true;
            btndn.Click += btndn_Click;
            // 
            // btnHuybo
            // 
            btnHuybo.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnHuybo.Location = new Point(228, 228);
            btnHuybo.Name = "btnHuybo";
            btnHuybo.Size = new Size(125, 37);
            btnHuybo.TabIndex = 4;
            btnHuybo.Text = "Hủy bỏ";
            btnHuybo.UseVisualStyleBackColor = true;
            btnHuybo.Click += btnHuybo_Click;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(228, 96);
            txtTenDangNhap.Multiline = true;
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(192, 36);
            txtTenDangNhap.TabIndex = 5;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(228, 160);
            txtMatKhau.Multiline = true;
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(192, 40);
            txtMatKhau.TabIndex = 6;
            txtMatKhau.KeyDown += txtMatKhau_KeyDown;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.frmdn;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(482, 318);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(btnHuybo);
            Controls.Add(btndn);
            Controls.Add(lblmk);
            Controls.Add(lblTen);
            Controls.Add(lbldangnhap);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += frmDangNhap_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbldangnhap;
        private Label lblTen;
        private Label lblmk;
        private Button btndn;
        private Button btnHuybo;
        private TextBox txtTenDangNhap;
        private TextBox txtMatKhau;
    }
}