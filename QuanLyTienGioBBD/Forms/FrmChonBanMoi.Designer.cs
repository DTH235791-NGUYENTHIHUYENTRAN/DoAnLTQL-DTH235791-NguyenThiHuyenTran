namespace QuanLyTienGioBBD.Forms
{
    partial class FrmChonBanMoi
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
            lblchonban = new Label();
            cboBanTrong = new ComboBox();
            btnXacNhan = new Button();
            btnHuyBo = new Button();
            SuspendLayout();
            // 
            // lblchonban
            // 
            lblchonban.AutoSize = true;
            lblchonban.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblchonban.Location = new Point(78, 36);
            lblchonban.Name = "lblchonban";
            lblchonban.Size = new Size(303, 25);
            lblchonban.TabIndex = 0;
            lblchonban.Text = "Chọn bàn muốn chuyển đến:";
            // 
            // cboBanTrong
            // 
            cboBanTrong.FormattingEnabled = true;
            cboBanTrong.Location = new Point(138, 91);
            cboBanTrong.Name = "cboBanTrong";
            cboBanTrong.Size = new Size(151, 28);
            cboBanTrong.TabIndex = 1;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(76, 136);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(115, 49);
            btnXacNhan.TabIndex = 2;
            btnXacNhan.Text = "Xác Nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(207, 141);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(123, 44);
            btnHuyBo.TabIndex = 3;
            btnHuyBo.Text = "Hủy Bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // FrmChonBanMoi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 234);
            Controls.Add(btnHuyBo);
            Controls.Add(btnXacNhan);
            Controls.Add(cboBanTrong);
            Controls.Add(lblchonban);
            Name = "FrmChonBanMoi";
            Text = "FrmChonBanMoi";
            Load += FrmChonBanMoi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblchonban;
        private ComboBox cboBanTrong;
        private Button btnXacNhan;
        private Button btnHuyBo;
    }
}