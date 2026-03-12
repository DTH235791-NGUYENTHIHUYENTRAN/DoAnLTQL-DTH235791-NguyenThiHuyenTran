using Microsoft.EntityFrameworkCore;
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

namespace QuanLyTienGioBBD
{
    public partial class FrmHoaDon_ChiTiet : Form
    {

        QLBidaDbContext context = new QLBidaDbContext();

        int maHD = 0;
        int id = 0;
        public FrmHoaDon_ChiTiet(int maHD = 0)
        {
            InitializeComponent();
            this.maHD = maHD;
        }

        private void FrmHoaDon_ChiTiet_Load(object sender, EventArgs e)
        {

            LoadBan();
            LoadThongTinHoaDon();
            LoadChiTietHoaDon();
            LoadDichVu();
            TinhTienGio();
            TinhTien();

        }



        void TinhTongTienSP()
        {
            decimal tienSP = 0;
            decimal tienGio = 0;

            decimal.TryParse(txtTongTien.Text.Replace(",", ""), out tienSP);
            decimal.TryParse(txtTienGio.Text.Replace(",", ""), out tienGio);

            decimal tong = tienSP + tienGio;

            txtTongThanhToan.Text = tong.ToString("N0");
        }

        void LoadDichVu()
        {
            cboDichVu.SelectedIndexChanged -= cboDichVu_SelectedIndexChanged;

            var listDV = context.DichVu.ToList();
            cboDichVu.DataSource = listDV;
            cboDichVu.DisplayMember = "TenDichVu";
            cboDichVu.ValueMember = "ID";

            cboDichVu.SelectedIndex = -1;
            txtDonGia.Text = "0";

            // Đăng ký lại sự kiện sau khi đã load xong
            cboDichVu.SelectedIndexChanged += cboDichVu_SelectedIndexChanged;
        }

        void LoadThongTinHoaDon()
        {
            var hd = context.HoaDon
                .Include(p => p.KhachHang)
                .Include(p => p.BanBida)
                .FirstOrDefault(p => p.MaHD == maHD);

            if (hd == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn");
                return;
            }

            txtMaHD.Text = hd.MaHD.ToString();

            if (hd.KhachHang != null)
                txtKhachHang.Text = hd.KhachHang.HoVaTen;
            else
                txtKhachHang.Text = "Khách lẻ";

            if (hd.BanBida != null)
                cboBan.Text = hd.BanBida.TenBan;
        }
        void LoadChiTietHoaDon()
        {
            var ds = context.HoaDonChiTiet
        .Include(p => p.DichVu)
        .Where(p => p.HoaDonID == maHD)
        .Select(p => new
        {
            STT = p.ID,
            SanPham = p.DichVu.TenDichVu,
            SoLuong = p.SoLuong,
            DonGia = p.DonGia,
            ThanhTien = p.ThanhTien
        })
        .ToList();

            dgvChiTiet.DataSource = ds;
        }
        void TinhTien()
        {
            decimal tongTienSP = 0;

            foreach (DataGridViewRow row in dgvChiTiet.Rows)
            {
                if (row.Cells["ThanhTien"].Value != null)
                {
                    tongTienSP += Convert.ToDecimal(row.Cells["ThanhTien"].Value);
                }
            }

            txtTongTien.Text = tongTienSP.ToString("N0");

            TinhTongTienSP();
        }



        void TinhTienGio()
        {
            var hd = context.HoaDon.Find(maHD);
            // Kiểm tra kỹ xem hóa đơn có tồn tại và đã kết thúc chưa
            if (hd == null || hd.GioKetThuc == null) return;

            // Ép kiểu (cast) về TimeSpan để không bị lỗi compile
            TimeSpan duration = (TimeSpan)(hd.GioKetThuc.Value - hd.GioBatDau);

            double tongPhut = duration.TotalMinutes;

            // Giả sử 60k/giờ = 1.000đ/phút
            decimal giaMoiPhut = 1000;
            decimal tienGio = (decimal)tongPhut * giaMoiPhut;

            txtTienGio.Text = tienGio.ToString("N0");

            // Hiển thị thời gian
            lblTienGioChoi.Text = $"Đã chơi: {(int)duration.TotalHours}h {duration.Minutes}m";
        }
        void LoadBan()
        {
            cboBan.DataSource = context.BanBida.ToList();
            cboBan.DisplayMember = "TenBan";
            cboBan.ValueMember = "ID";
        }

        void LoadHoaDon()
        {
            dgvChiTiet.DataSource = context.HoaDon
                .Select(p => new
                {

                    p.BanBidaID,
                    p.TongTien,

                }).ToList();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                HoaDonChiTiet ct = new HoaDonChiTiet();

                ct.HoaDonID = maHD;
                ct.DichVuID = (int)cboDichVu.SelectedValue;
                ct.SoLuong = int.Parse(txtSoLuong.Text);
                ct.DonGia = decimal.Parse(txtDonGia.Text);
                ct.ThanhTien = ct.SoLuong * ct.DonGia;

                context.HoaDonChiTiet.Add(ct);
                context.SaveChanges();

                LoadChiTietHoaDon();
                TinhTien();

                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (id <= 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng dữ liệu từ lưới để sửa!");
                return;
            }

            try
            {
                // Tìm chi tiết hóa đơn
                var ct = context.HoaDonChiTiet.FirstOrDefault(p => p.ID == id);

                if (ct != null)
                {
                    // Cập nhật dữ liệu
                    ct.DichVuID = (int)cboDichVu.SelectedValue;
                    ct.SoLuong = int.Parse(txtSoLuong.Text);
                    ct.DonGia = decimal.Parse(txtDonGia.Text);

                    // ⭐ THÊM DÒNG NÀY
                    ct.ThanhTien = ct.SoLuong * ct.DonGia;

                    // Lưu
                    context.SaveChanges();

                    // Load lại dữ liệu
                    LoadChiTietHoaDon();
                    TinhTien();

                    MessageBox.Show("Sửa thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message);
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                var ct = context.HoaDonChiTiet.Find(id);

                if (ct != null)
                {
                    context.HoaDonChiTiet.Remove(ct);
                    context.SaveChanges();

                    LoadChiTietHoaDon();
                    TinhTien();

                    MessageBox.Show("Xóa thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvChiTiet.Rows[e.RowIndex];

                id = Convert.ToInt32(row.Cells["STT"].Value);
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
                txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
            }
        }



        private void btnXuat_Click_1(object sender, EventArgs e)
        {
            var excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;

            var wb = excel.Workbooks.Add();
            var ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.ActiveSheet;

            // ===== TIÊU ĐỀ =====
            ws.Cells[1, 1] = "STT";
            ws.Cells[1, 2] = "Sản Phẩm";
            ws.Cells[1, 3] = "Số Lượng";
            ws.Cells[1, 4] = "Đơn Giá";
            ws.Cells[1, 5] = "Thành Tiền";

            // In đậm tiêu đề
            Microsoft.Office.Interop.Excel.Range header =
                ws.Range["A1:E1"];
            header.Font.Bold = true;

            int row = 2;

            // ===== DỮ LIỆU TỪ DATAGRIDVIEW =====
            for (int i = 0; i < dgvChiTiet.Rows.Count; i++)
            {
                if (dgvChiTiet.Rows[i].IsNewRow) continue;

                ws.Cells[row, 1] = dgvChiTiet.Rows[i].Cells[0].Value;
                ws.Cells[row, 2] = dgvChiTiet.Rows[i].Cells[1].Value;
                ws.Cells[row, 3] = dgvChiTiet.Rows[i].Cells[2].Value;
                ws.Cells[row, 4] = dgvChiTiet.Rows[i].Cells[3].Value;
                ws.Cells[row, 5] = dgvChiTiet.Rows[i].Cells[4].Value;

                row++;
            }

            // ===== ĐỊNH DẠNG TIỀN =====
            ws.Range["D2:E" + row].NumberFormat = "#,##0";

            // ===== KẺ BẢNG =====
            Microsoft.Office.Interop.Excel.Range table =
                ws.Range["A1:E" + (row - 1)];
            table.Borders.LineStyle = 1;

            // ===== THÔNG TIN HÓA ĐƠN =====
            ws.Cells[1, 7] = "Mã Hóa Đơn:";
            ws.Cells[1, 8] = txtMaHD.Text;

            ws.Cells[2, 7] = "Khách:";
            ws.Cells[2, 8] = txtKhachHang.Text;

            ws.Cells[3, 7] = "Bàn:";
            ws.Cells[3, 8] = cboBan.Text;

            ws.Cells[4, 7] = "Tổng Thanh Toán:";
            ws.Cells[4, 8] = txtTongThanhToan.Text;

            // In đậm phần thông tin
            ws.Range["G1:G4"].Font.Bold = true;

            // ===== TỰ GIÃN CỘT =====
            ws.Columns.AutoFit();

            MessageBox.Show("Xuất Excel thành công!");
        }

        private void dgvChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvChiTiet.Rows[e.RowIndex];

                id = Convert.ToInt32(row.Cells["STT"].Value);

                cboDichVu.Text = row.Cells["SanPham"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
                txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
            }
        }

        private void cboDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDichVu.SelectedValue == null || !int.TryParse(cboDichVu.SelectedValue.ToString(), out int idDV))
            {
                return;
            }

            // Tìm đơn giá từ database hoặc từ danh sách đã load
            var dv = context.DichVu.FirstOrDefault(p => p.ID == idDV);

            if (dv != null)
            {
                txtDonGia.Text = dv.DonGia.ToString(); // Hoặc dùng "N0" nếu muốn định dạng số
            }
        }
    }
}
    


