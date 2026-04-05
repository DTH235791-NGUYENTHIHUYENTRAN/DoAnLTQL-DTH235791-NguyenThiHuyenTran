using QuanLyTienGioBBD.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;

namespace QuanLyTienGioBBD.Forms
{
    public partial class FrmQuanLyHoaDon : Form
    {
        private QLBidaDbContext db = new QLBidaDbContext();
        private string currentRole;
        private PrintDocument pd = new PrintDocument();
        private HoaDon hoaDonInLai = null;
        public FrmQuanLyHoaDon(string role)
        {
            InitializeComponent();
            this.currentRole = role;
            pd.PrintPage += Pd_PrintPage;
        }

        void LoadLichSu()
        {
            db = new QLBidaDbContext(); // Làm tươi context

            var tuNgay = dtpTuNgay.Value.Date;
            var denNgay = dtpDenNgay.Value.Date.AddDays(1);
            string sdt = txtTimKiem.Text.Trim();

            var query = db.HoaDon.AsQueryable();

            // Lọc theo thời gian
            query = query.Where(x => x.GioKetThuc >= tuNgay && x.GioKetThuc < denNgay);

            // Lọc theo SĐT nếu có nhập
            if (!string.IsNullOrEmpty(sdt))
            {
                query = query.Where(x => x.KhachHang.DienThoai.Contains(sdt));
            }

            // Lấy dữ liệu về List để tính toán
            var dataResult = query.Select(x => new
            {
                MaHD = x.MaHD,
                TenBan = x.BanBida.TenBan,
                KhachHang = x.KhachHang != null ? x.KhachHang.TenKH : "Khách lẻ",
                SDT = x.KhachHang != null ? x.KhachHang.DienThoai : "",
                Vao = x.GioBatDau,
                Ra = x.GioKetThuc,
                TongTien = x.TongTien ?? 0 // Tránh lỗi Null
            }).OrderByDescending(x => x.Ra).ToList();

            dgvLichSu.DataSource = dataResult;

            // Tính tổng doanh thu trực tiếp từ List dataResult cho nhanh
            decimal tong = dataResult.Sum(x => x.TongTien);
            lblTongDoanhThu.Text = "Tổng doanh thu: " + tong.ToString("N0") + " VND";

            DinhDangLuoi();
        }

        void DinhDangLuoi()
        {
            if (dgvLichSu.Columns["MaHD"] != null) dgvLichSu.Columns["MaHD"].HeaderText = "Mã HD";
            if (dgvLichSu.Columns["TongTien"] != null)
            {
                dgvLichSu.Columns["TongTien"].HeaderText = "Thành Tiền";
                dgvLichSu.Columns["TongTien"].DefaultCellStyle.Format = "N0"; // Hiện 50,000 thay vì 50000
            }
        }
        private void FrmQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            // Mặc định xem từ đầu ngày hôm nay đến hết ngày hôm nay
            dtpTuNgay.Value = DateTime.Now.Date;
            dtpDenNgay.Value = DateTime.Now.Date;

            // Phân quyền
            bool isAdmin = string.Equals(currentRole, "Admin", StringComparison.OrdinalIgnoreCase);
            btnXoa.Enabled = isAdmin;
            lblTongDoanhThu.Visible = isAdmin; // Chỉ chủ mới được xem tổng tiền

            LoadLichSu();
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadLichSu();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLichSu.CurrentRow == null) return;
            int maHD = (int)dgvLichSu.CurrentRow.Cells["MaHD"].Value;

            if (MessageBox.Show($"Xóa hóa đơn #{maHD} sẽ làm thay đổi báo cáo doanh thu. Tiếp tục?",
                "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var hd = db.HoaDon.Find(maHD);
                if (hd != null)
                {
                    db.HoaDon.Remove(hd);
                    db.SaveChanges();
                    LoadLichSu();
                    MessageBox.Show("Đã xóa hóa đơn.");
                }
            }

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            dtpTuNgay.Value = DateTime.Now.Date;
            dtpDenNgay.Value = DateTime.Now.Date;
            LoadLichSu();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        void TinhTongDoanhThu()
        {
            decimal tong = 0;
            foreach (DataGridViewRow row in dgvLichSu.Rows)
            {
                if (row.Cells["TongTien"].Value != null)
                {
                    tong += Convert.ToDecimal(row.Cells["TongTien"].Value);
                }
            }
            lblTongDoanhThu.Text = "Tổng tiền: " + tong.ToString("N0") + " VND";
        }

        private void btnInLaiBill_Click(object sender, EventArgs e)
        {
            if (dgvLichSu.CurrentRow == null) return;

            int maHD = Convert.ToInt32(dgvLichSu.CurrentRow.Cells["MaHD"].Value);
            hoaDonInLai = db.HoaDon.FirstOrDefault(x => x.MaHD == maHD);

            if (hoaDonInLai != null)
            {
                PrintPreviewDialog ppd = new PrintPreviewDialog { Document = pd };
                ppd.ShowDialog();

            }
        }
        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (hoaDonInLai == null) return;

            Graphics g = e.Graphics;
            Font fTitle = new Font("Arial", 18, FontStyle.Bold);
            Font fBody = new Font("Arial", 10, FontStyle.Regular);
            Font fHeader = new Font("Arial", 10, FontStyle.Bold);

            float y = 20;
            g.DrawString("BIDA HTRAN - COPY BILL", fTitle, Brushes.Black, 50, y); y += 40;
            g.DrawString($"Mã HĐ: #{hoaDonInLai.MaHD}", fBody, Brushes.Black, 10, y); y += 20;
            g.DrawString($"Thời gian ra: {hoaDonInLai.GioKetThuc:dd/MM/yyyy HH:mm}", fBody, Brushes.Black, 10, y); y += 20;
            g.DrawString($"Bàn: {hoaDonInLai.BanBida.TenBan}", fBody, Brushes.Black, 10, y); y += 20;
            g.DrawLine(Pens.Black, 10, y, 300, y); y += 10;
            g.DrawString($"TỔNG TIỀN: {hoaDonInLai.TongTien?.ToString("N0")} VND",
                new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 10, y);
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (dgvLichSu.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Files (*.xlsx)|*.xlsx";
                sfd.FileName = "BaoCaoDoanhThu_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Thiết lập bản quyền cho EPPlus (Bắt buộc)
                        ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                        using (ExcelPackage pck = new ExcelPackage())
                        {
                            // Tạo một sheet mới
                            ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Doanh Thu");

                            // 1. Tạo tiêu đề cột (Header) dựa trên DataGridView
                            int colIndex = 1;
                            foreach (DataGridViewColumn col in dgvLichSu.Columns)
                            {
                                if (col.Visible) // Chỉ xuất các cột đang hiện
                                {
                                    ws.Cells[1, colIndex].Value = col.HeaderText;
                                    ws.Cells[1, colIndex].Style.Font.Bold = true;
                                    ws.Cells[1, colIndex].Style.Fill.SetBackground(Color.LightGray);
                                    colIndex++;
                                }
                            }

                            // 2. Đổ dữ liệu từ lưới vào Excel
                            for (int i = 0; i < dgvLichSu.Rows.Count; i++)
                            {
                                int excelCol = 1;
                                for (int j = 0; j < dgvLichSu.Columns.Count; j++)
                                {
                                    if (dgvLichSu.Columns[j].Visible)
                                    {
                                        var cellValue = dgvLichSu.Rows[i].Cells[j].Value;
                                        ws.Cells[i + 2, excelCol].Value = cellValue;

                                        // Định dạng ngày tháng nếu là cột thời gian
                                        if (cellValue is DateTime)
                                        {
                                            ws.Cells[i + 2, excelCol].Style.Numberformat.Format = "dd/mm/yyyy HH:mm";
                                        }
                                        excelCol++;
                                    }
                                }
                            }

                            // 3. Tự động căn chỉnh độ rộng cột
                            ws.Cells.AutoFitColumns();

                            // 4. Lưu file
                            File.WriteAllBytes(sfd.FileName, pck.GetAsByteArray());
                            MessageBox.Show("Xuất file Excel thành công!", "Chúc mừng");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message);
                    }
                }
            }
        }
    }
}

