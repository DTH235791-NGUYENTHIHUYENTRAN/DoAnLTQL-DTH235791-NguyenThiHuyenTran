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
            lbldangnhap.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbldangnhap.Location = new Point(177, 32);
            lbldangnhap.Name = "lbldangnhap";
            lbldangnhap.Size = new Size(128, 23);
            lbldangnhap.TabIndex = 0;
            lbldangnhap.Text = "ĐĂNG NHẬP";
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Font = new Font("Times New Roman", 10.8F);
            lblTen.Location = new Point(85, 76);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(129, 20);
            lblTen.TabIndex = 1;
            lblTen.Text = "Tên Đăng Nhập:";
            // 
            // lblmk
            // 
            lblmk.AutoSize = true;
            lblmk.Font = new Font("Times New Roman", 10.8F);
            lblmk.Location = new Point(85, 134);
            lblmk.Name = "lblmk";
            lblmk.Size = new Size(82, 20);
            lblmk.TabIndex = 2;
            lblmk.Text = "Mật khẩu:";
            // 
            // btndn
            // 
            btndn.Font = new Font("Times New Roman", 10.8F);
            btndn.Location = new Point(85, 193);
            btndn.Name = "btndn";
            btndn.Size = new Size(119, 29);
            btndn.TabIndex = 3;
            btndn.Text = "Đăng nhập";
            btndn.UseVisualStyleBackColor = true;
            btndn.Click += btndn_Click;
            // 
            // btnHuybo
            // 
            btnHuybo.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnHuybo.Location = new Point(228, 193);
            btnHuybo.Name = "btnHuybo";
            btnHuybo.Size = new Size(125, 29);
            btnHuybo.TabIndex = 4;
            btnHuybo.Text = "Hủy bỏ";
            btnHuybo.UseVisualStyleBackColor = true;
            btnHuybo.Click += btnHuybo_Click;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(228, 76);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(161, 27);
            txtTenDangNhap.TabIndex = 5;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(228, 134);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(161, 27);
            txtMatKhau.TabIndex = 6;
            txtMatKhau.KeyDown += txtMatKhau_KeyDown;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 272);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(btnHuybo);
            Controls.Add(btndn);
            Controls.Add(lblmk);
            Controls.Add(lblTen);
            Controls.Add(lbldangnhap);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
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