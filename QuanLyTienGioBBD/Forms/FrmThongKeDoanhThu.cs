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
using Microsoft.EntityFrameworkCore;

namespace QuanLyTienGioBBD.Forms
{
    public partial class FrmThongKeDoanhThu : Form
    {
        public FrmThongKeDoanhThu()
        {
            InitializeComponent();
            SetupInitialUI();
            ApplyColors();

            dgvThongKe.CellFormatting += dgvThongKe_CellFormatting;
        }

        private void ApplyColors()
        {
            panelDoanhThu.BackColor = Color.Teal;
            lblTongDoanhThu.ForeColor = Color.White;
            panelGioChoi.BackColor = Color.MediumPurple;
            lblTongGioChoi.ForeColor = Color.White;
            panelSoHoaDon.BackColor = Color.Tomato;
            lblSoHoaDon.ForeColor = Color.White;
        }

        private void SetupInitialUI()
        {
            dgvThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongKe.ReadOnly = true;
            dgvThongKe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvThongKe.RowHeadersVisible = false;
        }

        // --- HÀM LỌC NGÀY NHANH ---
        private void SetDateRange(DateTime start, DateTime end)
        {
            dtpTuNgay.Value = start;
            dtpDenNgay.Value = end;
            btnThongKe.PerformClick();
        }

        private void btnHomNay_Click(object sender, EventArgs e) => SetDateRange(DateTime.Today, DateTime.Today);

        private void btnTuanNay_Click(object sender, EventArgs e)
        {
            DateTime start = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday);
            SetDateRange(start, DateTime.Today);
        }

        private void btnThangNay_Click(object sender, EventArgs e)
        {
            DateTime start = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            SetDateRange(start, DateTime.Today);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1).AddTicks(-1);

            try
            {
                using (var db = new QLBidaDbContext())
                {
                    // 1. Lấy dữ liệu từ Database
                    var dsRaw = db.HoaDon
                        .Include(h => h.BanBida)
                        .Where(h => h.GioBatDau >= tuNgay && h.GioBatDau <= denNgay)
                        .ToList();

                    if (!dsRaw.Any()) { ClearData(); return; }

                    // 2. Tính toán Dashboard
                    var dsDaThanhToan = dsRaw.Where(h => (h.TongTien ?? 0) > 0).ToList();

                    lblTongDoanhThu.Text = string.Format("{0:N0} VNĐ", dsDaThanhToan.Sum(h => h.TongTien ?? 0));
                    lblSoHoaDon.Text = dsDaThanhToan.Count.ToString();

                    // Tính tổng giờ chơi quy đổi sang định dạng "Xh Ym"
                    double tongPhutTongCong = dsRaw.Sum(h => ((h.GioKetThuc ?? DateTime.Now) - h.GioBatDau).TotalMinutes);
                    int hTotal = (int)tongPhutTongCong / 60;
                    int mTotal = (int)tongPhutTongCong % 60;
                    lblTongGioChoi.Text = string.Format("{0}h {1}m", hTotal, mTotal);

                    // 3. Hiển thị lên lưới DataGridView
                    dgvThongKe.DataSource = dsRaw.Select(h =>
                    {
                        TimeSpan ts = (h.GioKetThuc ?? DateTime.Now) - h.GioBatDau;
                        return new
                        {
                            h.MaHD,
                            NgayLap = h.GioBatDau.ToString("dd/MM HH:mm"),
                            TenBan = h.BanBida?.TenBan ?? "Bàn " + h.BanBidaID,
                            TrangThai = (h.TongTien > 0) ? "Đã thanh toán" : "Đang chơi",
                            SoGio = string.Format("{0}h {1}m", (int)ts.TotalHours, ts.Minutes),
                            TongTien = h.TongTien ?? 0
                        };
                    }).OrderByDescending(x => x.MaHD).ToList();

                    FormatGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
        }

            private void FormatGridView()
        {
            if (dgvThongKe.Columns["MaHD"] != null)
            {
                dgvThongKe.Columns["MaHD"].HeaderText = "Mã HĐ";
                dgvThongKe.Columns["NgayLap"].HeaderText = "Ngày Lập";
                dgvThongKe.Columns["TenBan"].HeaderText = "Tên Bàn";
                dgvThongKe.Columns["SoGio"].HeaderText = "Giờ Chơi";
                dgvThongKe.Columns["TrangThai"].HeaderText = "Trạng Thái";
                dgvThongKe.Columns["TongTien"].HeaderText = "Tổng Tiền";

                dgvThongKe.Columns["TongTien"].DefaultCellStyle.Format = "N0";
                dgvThongKe.Columns["TongTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvThongKe.Columns["SoGio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void ClearData()
        {
            lblTongDoanhThu.Text = "0 VNĐ";
            lblTongGioChoi.Text = "0h 0m";
            lblSoHoaDon.Text = "0";
            dgvThongKe.DataSource = null;
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (dgvThongKe.Rows.Count == 0) return;

            SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", FileName = "ThongKeDoanhThu.xlsx" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (var workbook = new ClosedXML.Excel.XLWorkbook())
                {
                    // Chuyển DataGridView thành DataTable để xuất
                    DataTable dt = new DataTable();
                    foreach (DataGridViewColumn col in dgvThongKe.Columns) dt.Columns.Add(col.HeaderText);
                    foreach (DataGridViewRow row in dgvThongKe.Rows)
                    {
                        DataRow dr = dt.NewRow();
                        for (int i = 0; i < dgvThongKe.Columns.Count; i++) dr[i] = row.Cells[i].Value;
                        dt.Rows.Add(dr);
                    }

                    var sheet = workbook.Worksheets.Add(dt, "Thống kê");
                    sheet.Columns().AdjustToContents();
                    workbook.SaveAs(sfd.FileName);
                    MessageBox.Show("Xuất file thành công!");
                }
            }
            }

        private void dgvThongKe_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvThongKe.Columns[e.ColumnIndex].Name == "TrangThai" && e.Value != null)
            {
                if (e.Value.ToString() == "Đang chơi")
                {
                    dgvThongKe.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                    dgvThongKe.Rows[e.RowIndex].DefaultCellStyle.Font = new Font(dgvThongKe.Font, FontStyle.Bold);
                }
                else
                {
                    dgvThongKe.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                    dgvThongKe.Rows[e.RowIndex].DefaultCellStyle.Font = new Font(dgvThongKe.Font, FontStyle.Regular);
                }
            }
        }
    }
}
    

            
    

