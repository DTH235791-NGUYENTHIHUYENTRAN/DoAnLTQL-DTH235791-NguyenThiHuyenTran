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
          
            var listBan = db.Ban.Select(x => new { x.MaBan, x.TenBan }).ToList();
            listBan.Insert(0, new { MaBan = 0, TenBan = "--- Tất cả bàn ---" });

            cboBan.DataSource = listBan;
            cboBan.DisplayMember = "TenBan";
            cboBan.ValueMember = "MaBan";
        }

        void LoadLichSu()
        {
            db = new QLBidaDbContext(); 

            var tuNgay = dtpTuNgay.Value.Date;
            var denNgay = dtpDenNgay.Value.Date.AddDays(1);
            string key = txtTimKiem.Text.Trim().ToLower();
            int maBanHienTai = (cboBan.SelectedValue != null) ? (int)cboBan.SelectedValue : 0;

            var query = db.HoaDon.AsQueryable();

          
            query = query.Where(x => x.GioKetThuc >= tuNgay && x.GioKetThuc < denNgay);
          
            if (maBanHienTai > 0)
            {
                query = query.Where(x => x.BanBidaID == maBanHienTai);
            }           
            if (!string.IsNullOrEmpty(key))
            {
                query = query.Where(x => x.MaHD.ToString() == key ||
                                         (x.KhachHang != null && x.KhachHang.TenKH.ToLower().Contains(key)) ||
                                         (x.KhachHang != null && x.KhachHang.DienThoai.Contains(key)));
            }

           
            var dataResult = query.Select(x => new
            {
                MaHD = x.MaHD,
                TenBan = x.BanBida.TenBan,
                KhachHang = x.KhachHang != null ? x.KhachHang.TenKH : "Khách lẻ",
                SDT = x.KhachHang != null ? x.KhachHang.DienThoai : "",
                
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
           
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Xuất hóa đơn ra tập tin Excel";
            sfd.Filter = "Excel Workbook|*.xlsx";
            sfd.FileName = "BaoCaoDoanhThu_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".xlsx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    
                    DataTable table = new DataTable();
                    table.Columns.Add("Mã HD", typeof(int));
                    table.Columns.Add("Tên Bàn", typeof(string));
                    table.Columns.Add("Khách Hàng", typeof(string));
                    table.Columns.Add("Nhân Viên", typeof(string));
                    table.Columns.Add("Giờ Vào", typeof(DateTime));
                    table.Columns.Add("Giờ Ra", typeof(DateTime));
                    table.Columns.Add("Thành Tiền", typeof(decimal));

                    
                    var tuNgay = dtpTuNgay.Value.Date;
                    var denNgay = dtpDenNgay.Value.Date.AddDays(1);
                    int maBanHienTai = (cboBan.SelectedValue != null) ? (int)cboBan.SelectedValue : 0;

                    var query = db.HoaDon.Where(x => x.GioKetThuc >= tuNgay && x.GioKetThuc < denNgay);

                    if (maBanHienTai > 0)
                        query = query.Where(x => x.BanBidaID == maBanHienTai);

                    var danhSachHoaDon = query.ToList();

                    
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

                    
                    using (ClosedXML.Excel.XLWorkbook wb = new ClosedXML.Excel.XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "Doanh Thu");

                        // Định dạng cột tiền có dấu phẩy phân cách
                        sheet.Column(7).Style.NumberFormat.Format = "#,##0";                       
                        sheet.Columns().AdjustToContents();                       
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

