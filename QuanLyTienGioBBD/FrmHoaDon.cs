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
using System.Drawing.Printing;
using Microsoft.EntityFrameworkCore;

namespace QuanLyTienGioBBD
{
    public partial class FrmHoaDon : Form
    {
       
        QLBidaDbContext context = new QLBidaDbContext();
        PrintDocument printDocument = new PrintDocument();
        int id = 0;
        int maHD = 0;
        public FrmHoaDon(int id)
        {
            InitializeComponent();
            maHD = id;
        }

        private void FrmHoaDon_Load(object sender, EventArgs e)
        {


            LoadCombobox();
            LoadHoaDon();
        }

            void TinhTien()
        {
            DateTime batDau = dtpGioBatDau.Value;
            DateTime ketThuc = dtpGioKetThuc.Value;

            double soGio = (ketThuc - batDau).TotalHours;

            double gia = 50000; // giá 1 giờ bida

            double tong = soGio * gia;

            txtTongHoaDon.Text = tong.ToString("N0");
        }

        void TinhTongHoaDon()
        {
            var tong = context.HoaDonChiTiet
                .Where(p => p.HoaDonID == int.Parse(txtMaHD.Text))
                .Sum(p => (decimal?)(p.SoLuong * p.DonGia)) ?? 0;

            txtTongHoaDon.Text = tong.ToString("N0");
        }

        void LoadCombobox()
        {
            cboBanBida.DataSource = null;
            cboBanBida.DataSource = context.BanBida.ToList();
            cboBanBida.DisplayMember = "TenBan";
            cboBanBida.ValueMember = "ID";

            cboNhanVien.DataSource = context.NhanVien.ToList();
            cboNhanVien.DisplayMember = "HoVaTen";
            cboNhanVien.ValueMember = "ID";

            cboKhachHang.DataSource = context.KhachHang.ToList();
            cboKhachHang.DisplayMember = "HoVaTen";
            cboKhachHang.ValueMember = "ID";
        }

        void LoadHoaDon()
        {
            using (var db = new QLBidaDbContext())
            {
                var ds = db.HoaDon
                    .Select(r => new
                    {
                        MaHD = r.MaHD,
                        Ban = r.BanBida != null ? r.BanBida.TenBan : "N/A",
                        KhachHang = r.KhachHang != null ? r.KhachHang.HoVaTen : "Khách vãng lai",
                        GioBatDau = r.GioBatDau,
                        GioKetThuc = r.GioKetThuc,
                        TongTien = r.TongTien,
                        NhanVien = r.NhanVien != null ? r.NhanVien.HoVaTen : "N/A"
                    })
                    .ToList();             

                dgvHoaDon.DataSource = ds;
            }
        }
        void LoadMaHoaDon()
        {
            int max = 0;

            if (context.HoaDon.Any())
            {
                max = context.HoaDon.Max(p => p.MaHD);
            }

            txtMaHD.Text = (max + 1).ToString();
        }


        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvHoaDon.Rows[e.RowIndex];

            txtMaHD.Text = row.Cells["MaHD"].Value?.ToString();

            cboBanBida.Text = row.Cells["Ban"].Value?.ToString();
            cboKhachHang.Text = row.Cells["KhachHang"].Value?.ToString();
            cboNhanVien.Text = row.Cells["NhanVien"].Value?.ToString();

            if (row.Cells["GioBatDau"].Value != null)
                dtpGioBatDau.Value = Convert.ToDateTime(row.Cells["GioBatDau"].Value);

            if (row.Cells["GioKetThuc"].Value != null)
                dtpGioKetThuc.Value = Convert.ToDateTime(row.Cells["GioKetThuc"].Value);

            txtTongHoaDon.Text = row.Cells["TongTien"].Value?.ToString();
        
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();

            hd.BanBidaID = Convert.ToInt32(cboBanBida.SelectedValue);
            hd.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue);
            hd.KhachHangID = Convert.ToInt32(cboKhachHang.SelectedValue);

            hd.GioBatDau = dtpGioBatDau.Value;
            hd.GioKetThuc = dtpGioKetThuc.Value;

            // Nếu textbox rỗng thì cho = 0
            if (string.IsNullOrEmpty(txtTongHoaDon.Text))
                hd.TongTien = 0;
            else
                hd.TongTien = decimal.Parse(txtTongHoaDon.Text.Replace(",", ""));

            context.HoaDon.Add(hd);
            context.SaveChanges();

            MessageBox.Show("Thêm hóa đơn thành công!");

            LoadHoaDon();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtMaHD.Text);

            var hd = context.HoaDon.FirstOrDefault(p => p.MaHD == id);

            if (hd != null)
            {
                hd.BanBidaID = Convert.ToInt32(cboBanBida.SelectedValue);
                hd.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue);
                hd.KhachHangID = Convert.ToInt32(cboKhachHang.SelectedValue);

                hd.GioBatDau = dtpGioBatDau.Value;
                hd.GioKetThuc = dtpGioKetThuc.Value;

                decimal tong = 0;
                decimal.TryParse(txtTongHoaDon.Text.Replace(",", ""), out tong);
                hd.TongTien = tong;

                context.SaveChanges();

                MessageBox.Show("Sửa thành công!");

                LoadHoaDon();
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtMaHD.Text);

            var hd = context.HoaDon.FirstOrDefault(p => p.MaHD == id);

            if (hd != null)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa không?",
                    "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    context.HoaDon.Remove(hd);
                    context.SaveChanges();
                    LoadHoaDon();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtMaHD.Text);

            var ds = context.HoaDon
                .Where(p => p.MaHD == id)
                .Select(p => new
                {
                    p.MaHD,
                    p.BanBidaID,
                    p.NhanVienID,
                    p.GioBatDau,
                    p.GioKetThuc,
                    p.TongTien,

                }).ToList();

            dgvHoaDon.DataSource = ds;
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow != null)
            {
                // Phải lấy đúng mã hóa đơn từ dòng được chọn
                int maHD = Convert.ToInt32(dgvHoaDon.CurrentRow.Cells["MaHD"].Value);

                // Truyền maHD vào đây
                FrmHoaDon_ChiTiet f = new FrmHoaDon_ChiTiet(maHD);
                f.ShowDialog();
            }

        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            var excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;

            var wb = excel.Workbooks.Add();
            var ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.ActiveSheet;

            // Tiêu đề
            ws.Cells[1, 1] = "Mã HD";
            ws.Cells[1, 2] = "Bàn";
            ws.Cells[1, 3] = "Khách Hàng";
            ws.Cells[1, 4] = "Giờ Bắt Đầu";
            ws.Cells[1, 5] = "Giờ Kết Thúc";
            ws.Cells[1, 6] = "Tổng Tiền";

            int row = 2;

            foreach (DataGridViewRow r in dgvHoaDon.Rows)
            {
                if (r.IsNewRow) continue;

                ws.Cells[row, 1] = r.Cells[0].Value;
                ws.Cells[row, 2] = r.Cells[1].Value;
                ws.Cells[row, 3] = r.Cells[2].Value;
                ws.Cells[row, 4] = r.Cells[3].Value;
                ws.Cells[row, 5] = r.Cells[4].Value;
                ws.Cells[row, 6] = r.Cells[5].Value;

                row++;
            }

            ws.Columns.AutoFit();

            MessageBox.Show("Xuất Excel thành công!");

        }

        private void dtpGioKetThuc_ValueChanged(object sender, EventArgs e)
        {
            TinhTien();
        }
    }
}




