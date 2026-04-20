namespace QuanLyTienGioBBD.Forms
{
    partial class FrmBatDauChoi
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
            lblBan = new Label();
            dtpBatDau = new DateTimePicker();
            cboNhanVien = new ComboBox();
            lblGiobd = new Label();
            lblnv = new Label();
            btnBatDau = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // lblBan
            // 
            lblBan.AutoSize = true;
            lblBan.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblBan.Location = new Point(175, 9);
            lblBan.Name = "lblBan";
            lblBan.Size = new Size(67, 25);
            lblBan.TabIndex = 0;
            lblBan.Text = "Bàn: ";
            // 
            // dtpBatDau
            // 
            dtpBatDau.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpBatDau.Format = DateTimePickerFormat.Custom;
            dtpBatDau.Location = new Point(66, 81);
            dtpBatDau.Name = "dtpBatDau";
            dtpBatDau.Size = new Size(250, 27);
            dtpBatDau.TabIndex = 1;
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(66, 160);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(250, 28);
            cboNhanVien.TabIndex = 2;
            // 
            // lblGiobd
            // 
            lblGiobd.AutoSize = true;
            lblGiobd.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblGiobd.Location = new Point(66, 45);
            lblGiobd.Name = "lblGiobd";
            lblGiobd.Size = new Size(123, 23);
            lblGiobd.TabIndex = 3;
            lblGiobd.Text = "Giờ Bắt Đầu:";
            // 
            // lblnv
            // 
            lblnv.AutoSize = true;
            lblnv.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblnv.Location = new Point(70, 124);
            lblnv.Name = "lblnv";
            lblnv.Size = new Size(103, 23);
            lblnv.TabIndex = 4;
            lblnv.Text = "Nhân Viên:";
            // 
            // btnBatDau
            // 
            btnBatDau.BackColor = Color.HotPink;
            btnBatDau.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnBatDau.Location = new Point(66, 210);
            btnBatDau.Name = "btnBatDau";
            btnBatDau.Size = new Size(107, 38);
            btnBatDau.TabIndex = 5;
            btnBatDau.Text = "Bắt Đầu";
            btnBatDau.UseVisualStyleBackColor = false;
            btnBatDau.Click += btnBatDau_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.HotPink;
            btnHuy.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnHuy.Location = new Point(203, 209);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(113, 39);
            btnHuy.TabIndex = 6;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // FrmBatDauChoi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(443, 323);
            Controls.Add(btnHuy);
            Controls.Add(btnBatDau);
            Controls.Add(lblnv);
            Controls.Add(lblGiobd);
            Controls.Add(cboNhanVien);
            Controls.Add(dtpBatDau);
            Controls.Add(lblBan);
            Name = "FrmBatDauChoi";
            Text = "FrmBatDauChoi";
            Load += FrmBatDauChoi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBan;
        private DateTimePicker dtpBatDau;
        private ComboBox cboNhanVien;
        private Label lblGiobd;
        private Label lblnv;
        private Button btnBatDau;
        private Button btnHuy;
    }
}