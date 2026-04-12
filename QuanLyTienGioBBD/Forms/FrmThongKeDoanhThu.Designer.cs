namespace QuanLyTienGioBBD.Forms
{
    partial class FrmThongKeDoanhThu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dtpTuNgay = new DateTimePicker();
            dtpDenNgay = new DateTimePicker();
            btnThongKe = new Button();
            panelDoanhThu = new Panel();
            lblTongDoanhThu = new Label();
            label1 = new Label();
            panelGioChoi = new Panel();
            lblTongGioChoi = new Label();
            label3 = new Label();
            panelSoHoaDon = new Panel();
            lblSoHoaDon = new Label();
            label5 = new Label();
            dgvThongKe = new DataGridView();
            btnXuat = new Button();
            NgayLap = new DataGridViewTextBoxColumn();
            MaHD = new DataGridViewTextBoxColumn();
            TenBan = new DataGridViewTextBoxColumn();
            SoGio = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)chartDoanhThu).BeginInit();
            panelDoanhThu.SuspendLayout();
            panelGioChoi.SuspendLayout();
            panelSoHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).BeginInit();
            SuspendLayout();
            // 
            // chartDoanhThu
            // 
            chartArea1.Name = "ChartArea1";
            chartDoanhThu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartDoanhThu.Legends.Add(legend1);
            chartDoanhThu.Location = new Point(12, 160);
            chartDoanhThu.Name = "chartDoanhThu";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDoanhThu.Series.Add(series1);
            chartDoanhThu.Size = new Size(309, 286);
            chartDoanhThu.TabIndex = 0;
            chartDoanhThu.Text = "chart1";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new Point(38, 31);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(250, 27);
            dtpTuNgay.TabIndex = 1;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new Point(38, 93);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(250, 27);
            dtpDenNgay.TabIndex = 2;
            // 
            // btnThongKe
            // 
            btnThongKe.Location = new Point(12, 505);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(94, 29);
            btnThongKe.TabIndex = 3;
            btnThongKe.Text = "Thống Kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // panelDoanhThu
            // 
            panelDoanhThu.Controls.Add(lblTongDoanhThu);
            panelDoanhThu.Controls.Add(label1);
            panelDoanhThu.Location = new Point(362, 18);
            panelDoanhThu.Name = "panelDoanhThu";
            panelDoanhThu.Size = new Size(200, 145);
            panelDoanhThu.TabIndex = 4;
            // 
            // lblTongDoanhThu
            // 
            lblTongDoanhThu.AutoSize = true;
            lblTongDoanhThu.Location = new Point(22, 72);
            lblTongDoanhThu.Name = "lblTongDoanhThu";
            lblTongDoanhThu.Size = new Size(114, 20);
            lblTongDoanhThu.TabIndex = 1;
            lblTongDoanhThu.Text = "Tổng doanh thu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 18);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 0;
            label1.Text = "Tổng Doanh Thu";
            // 
            // panelGioChoi
            // 
            panelGioChoi.Controls.Add(lblTongGioChoi);
            panelGioChoi.Controls.Add(label3);
            panelGioChoi.Location = new Point(579, 18);
            panelGioChoi.Name = "panelGioChoi";
            panelGioChoi.Size = new Size(201, 145);
            panelGioChoi.TabIndex = 5;
            // 
            // lblTongGioChoi
            // 
            lblTongGioChoi.AutoSize = true;
            lblTongGioChoi.Location = new Point(27, 72);
            lblTongGioChoi.Name = "lblTongGioChoi";
            lblTongGioChoi.Size = new Size(101, 20);
            lblTongGioChoi.TabIndex = 1;
            lblTongGioChoi.Text = "Tổng giờ chơi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 20);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 0;
            label3.Text = "Tổng Giờ Chơi";
            // 
            // panelSoHoaDon
            // 
            panelSoHoaDon.Controls.Add(lblSoHoaDon);
            panelSoHoaDon.Controls.Add(label5);
            panelSoHoaDon.Location = new Point(800, 18);
            panelSoHoaDon.Name = "panelSoHoaDon";
            panelSoHoaDon.Size = new Size(201, 145);
            panelSoHoaDon.TabIndex = 6;
            // 
            // lblSoHoaDon
            // 
            lblSoHoaDon.AutoSize = true;
            lblSoHoaDon.Location = new Point(44, 72);
            lblSoHoaDon.Name = "lblSoHoaDon";
            lblSoHoaDon.Size = new Size(85, 20);
            lblSoHoaDon.TabIndex = 1;
            lblSoHoaDon.Text = "Số hóa đơn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 24);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 0;
            label5.Text = "Số Hóa Đơn";
            // 
            // dgvThongKe
            // 
            dgvThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongKe.Columns.AddRange(new DataGridViewColumn[] { NgayLap, MaHD, TenBan, SoGio, TongTien });
            dgvThongKe.Location = new Point(362, 213);
            dgvThongKe.Name = "dgvThongKe";
            dgvThongKe.RowHeadersWidth = 51;
            dgvThongKe.Size = new Size(650, 279);
            dgvThongKe.TabIndex = 7;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(155, 505);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 29);
            btnXuat.TabIndex = 8;
            btnXuat.Text = "Xuất Excel";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // NgayLap
            // 
            NgayLap.DataPropertyName = "NgayLap";
            NgayLap.HeaderText = "Ngày Lập";
            NgayLap.MinimumWidth = 6;
            NgayLap.Name = "NgayLap";
            NgayLap.Width = 125;
            // 
            // MaHD
            // 
            MaHD.DataPropertyName = "MaHD";
            MaHD.HeaderText = "Mã HĐ";
            MaHD.MinimumWidth = 6;
            MaHD.Name = "MaHD";
            MaHD.Width = 125;
            // 
            // TenBan
            // 
            TenBan.DataPropertyName = "TenBan";
            TenBan.HeaderText = "Tên Bàn";
            TenBan.MinimumWidth = 6;
            TenBan.Name = "TenBan";
            TenBan.Width = 125;
            // 
            // SoGio
            // 
            SoGio.DataPropertyName = "SoGio";
            SoGio.HeaderText = "Số Giờ";
            SoGio.MinimumWidth = 6;
            SoGio.Name = "SoGio";
            SoGio.Width = 125;
            // 
            // TongTien
            // 
            TongTien.DataPropertyName = "TongTien";
            TongTien.HeaderText = "Tổng Tiền";
            TongTien.MinimumWidth = 6;
            TongTien.Name = "TongTien";
            TongTien.Width = 125;
            // 
            // FrmThongKeDoanhThu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 606);
            Controls.Add(btnXuat);
            Controls.Add(dgvThongKe);
            Controls.Add(panelSoHoaDon);
            Controls.Add(panelGioChoi);
            Controls.Add(panelDoanhThu);
            Controls.Add(btnThongKe);
            Controls.Add(dtpDenNgay);
            Controls.Add(dtpTuNgay);
            Controls.Add(chartDoanhThu);
            Name = "FrmThongKeDoanhThu";
            Text = "FrmThongKeDoanhThu";
            ((System.ComponentModel.ISupportInitialize)chartDoanhThu).EndInit();
            panelDoanhThu.ResumeLayout(false);
            panelDoanhThu.PerformLayout();
            panelGioChoi.ResumeLayout(false);
            panelGioChoi.PerformLayout();
            panelSoHoaDon.ResumeLayout(false);
            panelSoHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private DateTimePicker dtpTuNgay;
        private DateTimePicker dtpDenNgay;
        private Button btnThongKe;
        private Panel panelDoanhThu;
        private Panel panelGioChoi;
        private Panel panelSoHoaDon;
        private DataGridView dgvThongKe;
        private Button btnXuat;
        private Label lblTongDoanhThu;
        private Label label1;
        private Label lblTongGioChoi;
        private Label label3;
        private Label lblSoHoaDon;
        private Label label5;
        private DataGridViewTextBoxColumn NgayLap;
        private DataGridViewTextBoxColumn MaHD;
        private DataGridViewTextBoxColumn TenBan;
        private DataGridViewTextBoxColumn SoGio;
        private DataGridViewTextBoxColumn TongTien;
    }
}