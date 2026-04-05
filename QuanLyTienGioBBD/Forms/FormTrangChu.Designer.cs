namespace QuanLyTienGioBBD.Forms
{
    partial class FormTrangChu
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
            lblLienKet = new ToolStripStatusLabel();
            lblTrangThai = new ToolStripStatusLabel();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            mnuBaoCaoThongKe = new ToolStripMenuItem();
            mnuDoanhThu = new ToolStripMenuItem();
            mnuHoaDon = new ToolStripMenuItem();
            mnuNhanVien = new ToolStripMenuItem();
            mnuBanBida = new ToolStripMenuItem();
            mnuQuanLy = new ToolStripMenuItem();
            mnuKhachHang = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            mnuDangXuat = new ToolStripMenuItem();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            mnuTroGiup = new ToolStripMenuItem();
            hươngDânSưDungToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblLienKet
            // 
            lblLienKet.IsLink = true;
            lblLienKet.Name = "lblLienKet";
            lblLienKet.Size = new Size(81, 20);
            lblLienKet.Text = "© 2024 FIT";
            // 
            // lblTrangThai
            // 
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(72, 20);
            lblTrangThai.Text = "Xin Chào!";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTrangThai, toolStripStatusLabel1, lblLienKet });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(632, 20);
            toolStripStatusLabel1.Spring = true;
            // 
            // mnuBaoCaoThongKe
            // 
            mnuBaoCaoThongKe.DropDownItems.AddRange(new ToolStripItem[] { mnuDoanhThu });
            mnuBaoCaoThongKe.Name = "mnuBaoCaoThongKe";
            mnuBaoCaoThongKe.Size = new Size(148, 24);
            mnuBaoCaoThongKe.Text = "Báo Cáo-Thống Kê";
            // 
            // mnuDoanhThu
            // 
            mnuDoanhThu.Name = "mnuDoanhThu";
            mnuDoanhThu.Size = new Size(235, 26);
            mnuDoanhThu.Text = "Thống Kê Doanh Thu ";
            mnuDoanhThu.Click += mnuDoanhThu_Click;
            // 
            // mnuHoaDon
            // 
            mnuHoaDon.Name = "mnuHoaDon";
            mnuHoaDon.Size = new Size(172, 26);
            mnuHoaDon.Text = "Hóa Đơn ";
            mnuHoaDon.Click += mnuHoaDon_Click;
            // 
            // mnuNhanVien
            // 
            mnuNhanVien.Name = "mnuNhanVien";
            mnuNhanVien.Size = new Size(172, 26);
            mnuNhanVien.Text = "Nhân Viên";
            mnuNhanVien.Click += mnuNhanVien_Click;
            // 
            // mnuBanBida
            // 
            mnuBanBida.Name = "mnuBanBida";
            mnuBanBida.Size = new Size(172, 26);
            mnuBanBida.Text = "Bàn Bida";
            mnuBanBida.Click += mnuBanBida_Click;
            // 
            // mnuQuanLy
            // 
            mnuQuanLy.DropDownItems.AddRange(new ToolStripItem[] { mnuBanBida, mnuKhachHang, mnuNhanVien, mnuHoaDon });
            mnuQuanLy.Name = "mnuQuanLy";
            mnuQuanLy.Size = new Size(75, 24);
            mnuQuanLy.Text = "Quản Lý";
            // 
            // mnuKhachHang
            // 
            mnuKhachHang.Name = "mnuKhachHang";
            mnuKhachHang.Size = new Size(172, 26);
            mnuKhachHang.Text = "Khách Hàng";
            mnuKhachHang.Click += mnuKhachHang_Click;
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuThoat.Size = new Size(183, 26);
            mnuThoat.Text = "Thoát";
            mnuThoat.Click += mnuThoat_Click;
            // 
            // mnuDangXuat
            // 
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Size = new Size(183, 26);
            mnuDangXuat.Text = "Đăng Xuất";
            mnuDangXuat.Click += mnuDangXuat_Click;
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuDangXuat, mnuThoat });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            hệThốngToolStripMenuItem.Size = new Size(88, 24);
            hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, mnuQuanLy, mnuBaoCaoThongKe, mnuTroGiup });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "FormMain";
            // 
            // mnuTroGiup
            // 
            mnuTroGiup.DropDownItems.AddRange(new ToolStripItem[] { hươngDânSưDungToolStripMenuItem });
            mnuTroGiup.Name = "mnuTroGiup";
            mnuTroGiup.Size = new Size(79, 24);
            mnuTroGiup.Text = "Trợ Giúp";
            // 
            // hươngDânSưDungToolStripMenuItem
            // 
            hươngDânSưDungToolStripMenuItem.Name = "hươngDânSưDungToolStripMenuItem";
            hươngDânSưDungToolStripMenuItem.Size = new Size(224, 26);
            hươngDânSưDungToolStripMenuItem.Text = "Hướng dẫn sử dụng";
            hươngDânSưDungToolStripMenuItem.Click += hươngDânSưDungToolStripMenuItem_Click;
            // 
            // FormTrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Name = "FormTrangChu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang chủ";
            WindowState = FormWindowState.Maximized;
            Load += FormTrangChu_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripStatusLabel lblLienKet;
        private ToolStripStatusLabel lblTrangThai;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripMenuItem mnuThongTinPhanMem;
        private ToolStripMenuItem mnuHuongDanSuDung;
        private ToolStripMenuItem mnuBaoCaoThongKe;
        private ToolStripMenuItem mnuHoaDon;
        private ToolStripMenuItem mnuNhanVien;
        private ToolStripMenuItem mnuBanBida;
        private ToolStripMenuItem mnuQuanLy;
        private ToolStripMenuItem mnuKhachHang;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem mnuDoiMatKhau;
        private ToolStripMenuItem mnuDangXuat;
        private ToolStripMenuItem mnuDangNhap;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuDoanhThu;
        private ToolStripMenuItem mnuTroGiup;
        private ToolStripMenuItem hươngDânSưDungToolStripMenuItem;
    }
}