using QuanLyTienGioBBD.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.IO;

namespace QuanLyTienGioBBD.Forms
{
    public partial class FrmQuanLyHoaDon : Form
    {
        private QLBidaDbContext db = new QLBidaDbContext();
        private string currentRole;
        public FrmQuanLyHoaDon(string role)
        {
            InitializeComponent();          
            this.currentRole = role;
        }

        void LoadComboBan()
        {
            // Lấy danh sách từ bảng Ban (Dựa trên lỗi cũ của bạn là db.Ban)
            var listBan = db.Ban.Select(x => new { x.MaBan, x.TenBan }).ToList();
            listBan.Insert(0, new { MaBan = 0, TenBan = "--- Tất cả bàn ---" });

            cboBan.DataSource = listBan;
            cboBan.DisplayMember = "TenBan";
            cboBan.ValueMember = "MaBan";
        }

        void LoadLichSu()
        {
            db = new QLBidaDbContext(); // Làm mới dữ liệu

            var tuNgay = dtpTuNgay.Value.Date;
            var denNgay = dtpDenNgay.Value.Date.AddDays(1);
            string key = txtTimKiem.Text.Trim().ToLower();
            int maBanHienTai = (cboBan.SelectedValue != null) ? (int)cboBan.SelectedValue : 0;

            var query = db.HoaDon.AsQueryable();

            // 1. Lọc theo thời gian
            query = query.Where(x => x.GioKetThuc >= tuNgay && x.GioKetThuc < denNgay);

            // 2. Lọc theo Bàn (Dùng BanBidaID theo model HoaDon của bạn)
            if (maBanHienTai > 0)
            {
                query = query.Where(x => x.BanBidaID == maBanHienTai);
            }

            // 3. Tìm kiếm theo Mã, Tên KH hoặc SĐT
            if (!string.IsNullOrEmpty(key))
            {
                query = query.Where(x => x.MaHD.ToString() == key ||
                                         (x.KhachHang != null && x.KhachHang.TenKH.ToLower().Contains(key)) ||
                                         (x.KhachHang != null && x.KhachHang.DienThoai.Contains(key)));
            }

            // 4. Đổ dữ liệu ra anonymous object (Khớp chuẩn TenNV)
            var dataResult = query.Select(x => new
            {
                MaHD = x.MaHD,
                TenBan = x.BanBida.TenBan,
                KhachHang = x.KhachHang != null ? x.KhachHang.TenKH : "Khách lẻ",
                SDT = x.KhachHang != null ? x.KhachHang.DienThoai : "",
                // Đã sửa thành TenNV theo model NhanVien bạn gửi
                NhanVien = x.NhanVien != null ? x.NhanVien.TenNV : "Admin",
                Vao = x.GioBatDau,
                Ra = x.GioKetThuc,
                TongTien = x.TongTien ?? 0
            }).OrderByDescending(x => x.Ra).ToList();

            dgvLichSu.DataSource = dataResult;

            // Tính tổng tiền
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
                dgvLichSu.Columns["TongTien"].DefaultCellStyle.Format = "N0";
                dgvLichSu.Columns["TongTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvLichSu.Columns["TongTien"].DefaultCellStyle.ForeColor = Color.Blue;
            }
        }
        private void FrmQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            // Thiết lập ngày mặc định
            dtpTuNgay.Value = DateTime.Now.Date;
            dtpDenNgay.Value = DateTime.Now.Date;

            LoadComboBan();

            // Phân quyền hiển thị tổng doanh thu
            bool isAdmin = string.Equals(currentRole, "Admin", StringComparison.OrdinalIgnoreCase);
            lblTongDoanhThu.Visible = isAdmin;

            LoadLichSu();
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadLichSu();

        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            if (cboBan.Items.Count > 0) cboBan.SelectedIndex = 0;
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


        private void btnXuat_Click(object sender, EventArgs e)
        {
            // 1. Thiết lập lưu file
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Xuất hóa đơn ra tập tin Excel";
            sfd.Filter = "Excel Workbook|*.xlsx";
            sfd.FileName = "BaoCaoDoanhThu_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".xlsx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // 2. Tạo DataTable để chứa dữ liệu
                    DataTable table = new DataTable();
                    table.Columns.Add("Mã HD", typeof(int));
                    table.Columns.Add("Tên Bàn", typeof(string));
                    table.Columns.Add("Khách Hàng", typeof(string));
                    table.Columns.Add("Nhân Viên", typeof(string));
                    table.Columns.Add("Giờ Vào", typeof(DateTime));
                    table.Columns.Add("Giờ Ra", typeof(DateTime));
                    table.Columns.Add("Thành Tiền", typeof(decimal));

                    // 3. Lấy dữ liệu từ Database (Sử dụng các bộ lọc hiện tại trên Form)
                    var tuNgay = dtpTuNgay.Value.Date;
                    var denNgay = dtpDenNgay.Value.Date.AddDays(1);
                    int maBanHienTai = (cboBan.SelectedValue != null) ? (int)cboBan.SelectedValue : 0;

                    var query = db.HoaDon.Where(x => x.GioKetThuc >= tuNgay && x.GioKetThuc < denNgay);

                    if (maBanHienTai > 0)
                        query = query.Where(x => x.BanBidaID == maBanHienTai);

                    var danhSachHoaDon = query.ToList();

                    // 4. Đổ dữ liệu vào DataTable
                    if (danhSachHoaDon != null)
                    {
                        foreach (var h in danhSachHoaDon)
                        {
                            table.Rows.Add(
                                h.MaHD,
                                h.BanBida?.TenBan,
                                h.KhachHang?.TenKH ?? "Khách lẻ",
                                h.NhanVien?.TenNV ?? "Admin",
                                h.GioBatDau,
                                h.GioKetThuc,
                                h.TongTien ?? 0
                            );
                        }
                    }

                    // 5. Sử dụng ClosedXML (XLWorkbook) để tạo file Excel
                    using (ClosedXML.Excel.XLWorkbook wb = new ClosedXML.Excel.XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "Doanh Thu");

                        // Định dạng cột tiền có dấu phẩy phân cách
                        sheet.Column(7).Style.NumberFormat.Format = "#,##0";

                        // Tự động căn chỉnh độ rộng cột
                        sheet.Columns().AdjustToContents();

                        // Lưu file
                        wb.SaveAs(sfd.FileName);

                        MessageBox.Show("Đã xuất dữ liệu ra tập tin Excel thành công.", "Thành công",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất dữ liệu: " + ex.Message, "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            }
                }
        
        private void cboBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBan.Focused) LoadLichSu();
        }

       
    }
}

