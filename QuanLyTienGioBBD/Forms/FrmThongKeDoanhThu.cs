using QuanLyTienGioBBD.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using QuanLyTienGioBBD.Data;

namespace QuanLyTienGioBBD.Forms
{
    public partial class FrmThongKeDoanhThu : Form
    {
        public FrmThongKeDoanhThu()
        {
            InitializeComponent();
            SetupInitialUI(); // Thiết lập giao diện ban đầu
            ApplyColors();    // Tô màu cho các Panel
        }

        // 1. Tô màu sắc cho các Panel (Dựa trên yêu cầu của bạn)
        private void ApplyColors()
        {
            // Màu xanh ngọc cho Doanh Thu
            panelDoanhThu.BackColor = Color.Teal;
            lblTongDoanhThu.ForeColor = Color.White;

            // Màu tím cho Giờ Chơi
            panelGioChoi.BackColor = Color.MediumPurple;
            lblTongGioChoi.ForeColor = Color.White;

            // Màu đỏ cam cho Số Hóa Đơn
            panelSoHoaDon.BackColor = Color.Tomato;
            lblSoHoaDon.ForeColor = Color.White;
        }

        // 2. Thiết lập cấu hình biểu đồ và bảng ban đầu
        private void SetupInitialUI()
        {
            // Cấu hình biểu đồ (Chart)
            chartDoanhThu.Series.Clear();
            var series = new Series("Doanh Thu")
            {
                ChartType = SeriesChartType.Column, // Biểu đồ dạng cột
                XValueType = ChartValueType.String,
                IsValueShownAsLabel = true,         // Hiện số tiền trên đầu cột
                Color = Color.DodgerBlue
            };
            chartDoanhThu.Series.Add(series);
            chartDoanhThu.ChartAreas[0].AxisX.Title = "Ngày/Tháng";
            chartDoanhThu.ChartAreas[0].AxisY.Title = "VNĐ";
            chartDoanhThu.ChartAreas[0].AxisY.LabelStyle.Format = "N0";

            // Làm trống dữ liệu hiển thị ban đầu
            lblTongDoanhThu.Text = "0 VNĐ";
            lblTongGioChoi.Text = "0 Giờ";
            lblSoHoaDon.Text = "0";

            // Cấu hình DataGridView để tự giãn cột
            dgvThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            // Lấy khoảng thời gian chuẩn (từ 00:00 ngày bắt đầu đến 23:59 ngày kết thúc)
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1).AddTicks(-1);

            try
            {
                using (var db = new QLBidaDbContext())
                {
                    // Lấy danh sách hóa đơn từ Database dựa trên GioBatDau
                    var dsHoaDon = db.HoaDon
                        .Where(h => h.GioBatDau >= tuNgay && h.GioBatDau <= denNgay)
                        .ToList();

                    if (dsHoaDon.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu trong khoảng thời gian này!", "Thông báo");
                        // Reset về 0 nếu không có dữ liệu
                        lblTongDoanhThu.Text = "0 VNĐ";
                        lblTongGioChoi.Text = "0 Giờ";
                        lblSoHoaDon.Text = "0";
                        dgvThongKe.DataSource = null;
                        chartDoanhThu.Series["Doanh Thu"].Points.Clear();
                        return;
                    }

                    // --- PHẦN 1: TÍNH TOÁN CÁC CHỈ SỐ TỔNG ---
                    decimal tongTien = dsHoaDon.Sum(h => h.TongTien ?? 0);
                    int soHD = dsHoaDon.Count();

                    // Tính tổng giờ chơi (Kết thúc - Bắt đầu)
                    double tongGio = dsHoaDon
                        .Where(h => h.GioKetThuc.HasValue)
                        .Sum(h => (h.GioKetThuc.Value - h.GioBatDau).TotalHours);

                    // Cập nhật lên các Label
                    lblTongDoanhThu.Text = string.Format("{0:N0} VNĐ", tongTien);
                    lblTongGioChoi.Text = tongGio.ToString("N1") + " Giờ";
                    lblSoHoaDon.Text = soHD.ToString();

                    // --- PHẦN 2: ĐỔ DỮ LIỆU VÀO DATAGRIDVIEW ---
                    dgvThongKe.DataSource = dsHoaDon.Select(h => new {
                        MaHD = h.MaHD,
                        NgayLap = h.GioBatDau.ToString("dd/MM/yyyy"),
                        Ban = "Bàn " + h.BanBidaID,
                        SoGio = h.GioKetThuc.HasValue ? (h.GioKetThuc.Value - h.GioBatDau).TotalHours.ToString("N1") : "0",
                        TongTien = h.TongTien
                    }).ToList();

                    // --- PHẦN 3: VẼ BIỂU ĐỒ DOANH THU THEO NGÀY ---
                    chartDoanhThu.Series["Doanh Thu"].Points.Clear();
                    var duLieuBieuDo = dsHoaDon
                        .GroupBy(h => h.GioBatDau.ToString("dd/MM"))
                        .Select(g => new { Ngay = g.Key, DoanhThu = g.Sum(h => h.TongTien ?? 0) })
                        .OrderBy(x => x.Ngay);

                    foreach (var item in duLieuBieuDo)
                    {
                        chartDoanhThu.Series["Doanh Thu"].Points.AddXY(item.Ngay, item.DoanhThu);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (dgvThongKe.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng thực hiện thống kê trước khi xuất dữ liệu!");
                return;
            }

            // Bạn có thể thêm thư viện EPPlus để viết code xuất Excel ở đây
            MessageBox.Show("Tính năng Xuất Excel đã sẵn sàng kết nối.");
        }
    }
}
