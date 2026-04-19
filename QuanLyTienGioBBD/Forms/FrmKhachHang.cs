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
using ClosedXML.Excel;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;


namespace QuanLyTienGioBBD.Forms
{
    public partial class FrmKhachHang : Form
    {
        private string role;
        private int? idDangChon = null;
        private QLBidaDbContext db = new QLBidaDbContext();
        private bool dangThem = false;

        public FrmKhachHang(string role)
        {
            InitializeComponent();
            this.role = role;

        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            LoadLoaiKhach();
            LoadData();

            // Mặc định ban đầu: Khóa hết các ô nhập và nút Lưu
            BatTatChinhSua(false);

            // Cấu hình các ô đặc biệt
            txtMaKH.ReadOnly = true;
            txtUuDai.ReadOnly = true; // Ưu đãi luôn luôn chỉ để xem
            txtUuDai.BackColor = Color.LightGray;

            // Phân quyền Admin
            bool isAdmin = role.Equals("Admin", StringComparison.OrdinalIgnoreCase);
            btnXoa.Visible = isAdmin;
            txtDiem.ReadOnly = !isAdmin;
            btnXuat.Visible = isAdmin;
        }

        void BatTatChinhSua(bool allows)
        {
            bool isAdmin = role.Equals("Admin", StringComparison.OrdinalIgnoreCase);

            // Nhân viên và Admin đều được nhập Tên/SĐT khi Thêm hoặc Sửa
            txtTenKH.Enabled = allows;
            txtDienThoai.Enabled = allows;

            // CHỈ ADMIN mới được can thiệp tay vào Điểm và Loại khách
            txtDiem.Enabled = allows && isAdmin;
            cboLoaiKH.Enabled = allows && isAdmin;

            // Điều khiển các nút bấm theo trạng thái (State-Machine)
            btnThem.Enabled = !allows;
            btnSua.Enabled = !allows;
            btnXoa.Enabled = !allows && isAdmin;
            btnXuat.Enabled = !allows && isAdmin;

            btnLuu.Enabled = allows;
            btnHuybo.Enabled = allows;

            dgvKhachHang.Enabled = !allows;
        }

        void LoadLoaiKhach()
        {
            cboLoaiKH.DataSource = db.LoaiKhach.ToList();
            cboLoaiKH.DisplayMember = "TenLoai";
            cboLoaiKH.ValueMember = "ID";
            cboLoaiKH.SelectedIndex = -1;
        }

        void CapNhatUuDaiTuDong()
        {
            // Tự động nhảy số Ưu đãi dựa trên Text của ComboBox Loại khách
            string hangKhach = cboLoaiKH.Text;

            if (hangKhach.Contains("VIP"))
                txtUuDai.Text = "10%";
            else if (hangKhach.Contains("Thành viên"))
                txtUuDai.Text = "5%";
            else
                txtUuDai.Text = "0%";
        }

        void LoadData()
        {
            db = new QLBidaDbContext(); // Refresh data
            dgvKhachHang.DataSource = db.KhachHang.Select(kh => new
            {
                kh.ID,
                kh.TenKH,
                SDT = kh.DienThoai,
                LoaiKH = kh.LoaiKhach.TenLoai,
                kh.Diem,
                kh.LoaiKhachID
            }).ToList();
            DinhDangLuoi();
        }

        void DinhDangLuoi()
        {
            if (dgvKhachHang.Columns["ID"] != null) dgvKhachHang.Columns["ID"].HeaderText = "Mã KH";
            if (dgvKhachHang.Columns["TenKH"] != null) dgvKhachHang.Columns["TenKH"].HeaderText = "Tên Khách";
            if (dgvKhachHang.Columns["SDT"] != null) dgvKhachHang.Columns["SDT"].HeaderText = "SĐT";
            if (dgvKhachHang.Columns["LoaiKH"] != null) dgvKhachHang.Columns["LoaiKH"].HeaderText = "Hạng";
            if (dgvKhachHang.Columns["Diem"] != null) dgvKhachHang.Columns["Diem"].HeaderText = "Điểm";
            if (dgvKhachHang.Columns["LoaiKhachID"] != null) dgvKhachHang.Columns["LoaiKhachID"].Visible = false;

            foreach (DataGridViewRow row in dgvKhachHang.Rows)
            {
                if (row.Cells["LoaiKH"].Value?.ToString() == "VIP")
                {
                    row.DefaultCellStyle.ForeColor = Color.DarkGoldenrod;
                    row.DefaultCellStyle.Font = new Font(dgvKhachHang.Font, FontStyle.Bold);
                }
            }
        }

        void ClearForm()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtDienThoai.Clear();
            txtDiem.Text = "0";
            cboLoaiKH.SelectedIndex = -1;
            idDangChon = null;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dangThem = true;
            idDangChon = null;

            txtMaKH.Clear();
            txtTenKH.Clear();
            txtDienThoai.Clear();
            txtDiem.Text = "0";
            cboLoaiKH.SelectedIndex = -1;
            txtUuDai.Text = "0%";

            BatTatChinhSua(true);
            txtTenKH.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (idDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa trên danh sách!", "Nhắc nhở");
                return;
            }
            dangThem = false;
            BatTatChinhSua(true);
            txtTenKH.Focus();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (idDangChon == null) return;

            string password = Microsoft.VisualBasic.Interaction.InputBox("Nhập mật khẩu Admin (123) để xóa:", "Xác thực", "");
            if (password == "123")
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        var kh = db.KhachHang.Find(idDangChon);
                        db.KhachHang.Remove(kh);
                        db.SaveChanges();
                        LoadData();
                        MessageBox.Show("Xóa thành công!");
                    }
                    catch { MessageBox.Show("Không thể xóa khách hàng này vì đã có lịch sử chơi bida!"); }
                }
            }
            else { MessageBox.Show("Sai mật khẩu!"); }

        }

        private void btntk_Click(object sender, EventArgs e)
        {
            // Tìm kiếm thông minh: Gõ đến đâu tìm đến đó
            string keyword = txtTimKiem.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword))
            {
                LoadData();
                return;
            }

            var result = db.KhachHang
                .Where(x => x.TenKH.ToLower().Contains(keyword) || x.DienThoai.Contains(keyword))
                .Select(kh => new
                {
                    kh.ID,
                    kh.TenKH,
                    SDT = kh.DienThoai,
                    LoaiKH = kh.LoaiKhach.TenLoai,
                    kh.Diem,
                    kh.LoaiKhachID
                }).ToList();

            dgvKhachHang.DataSource = result;
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            BatTatChinhSua(false);
            LoadData();
            idDangChon = null;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!");
                return;
            }

            try
            {
                bool isAdmin = role.Equals("Admin", StringComparison.OrdinalIgnoreCase);

                if (dangThem)
                {
                    // Tự tìm loại "Khách thường" để gán mặc định
                    var loaiThuong = db.LoaiKhach.FirstOrDefault(l => l.TenLoai.Contains("Thường") || l.TenLoai.Contains("Thành viên"));

                    var khMoi = new KhachHang
                    {
                        TenKH = txtTenKH.Text.Trim(),
                        DienThoai = txtDienThoai.Text.Trim(),
                        Diem = 0,
                        LoaiKhachID = loaiThuong != null ? loaiThuong.ID : 1
                    };
                    db.KhachHang.Add(khMoi);
                }
                else
                {
                    var kh = db.KhachHang.Find(idDangChon);
                    if (kh != null)
                    {
                        kh.TenKH = txtTenKH.Text.Trim();
                        kh.DienThoai = txtDienThoai.Text.Trim();

                        if (isAdmin)
                        {
                            if (int.TryParse(txtDiem.Text, out int d)) kh.Diem = d;
                            if (cboLoaiKH.SelectedValue != null) kh.LoaiKhachID = (int)cboLoaiKH.SelectedValue;
                        }

                        // Tự động thăng hạng VIP nếu đủ điểm
                        if (kh.Diem >= 100)
                        {
                            var vip = db.LoaiKhach.FirstOrDefault(l => l.TenLoai.ToUpper() == "VIP");
                            if (vip != null) kh.LoaiKhachID = vip.ID;
                        }
                    }
                }

                db.SaveChanges();
                MessageBox.Show("Đã lưu dữ liệu thành công!");
                BatTatChinhSua(false);
                LoadData();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }

        }


        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvKhachHang.Rows[e.RowIndex];
            idDangChon = Convert.ToInt32(row.Cells["ID"].Value);

            txtMaKH.Text = idDangChon.ToString();
            txtTenKH.Text = row.Cells["TenKH"].Value?.ToString();
            txtDienThoai.Text = row.Cells["SDT"].Value?.ToString();
            txtDiem.Text = row.Cells["Diem"].Value?.ToString();
            cboLoaiKH.SelectedValue = row.Cells["LoaiKhachID"].Value;

            CapNhatUuDaiTuDong();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim().ToLower();
            var query = db.KhachHang.AsQueryable();
            if (!string.IsNullOrEmpty(keyword))
                query = query.Where(x => x.TenKH.ToLower().Contains(keyword) || x.DienThoai.Contains(keyword));

            dgvKhachHang.DataSource = query.Select(kh => new
            {
                kh.ID,
                kh.TenKH,
                SDT = kh.DienThoai,
                LoaiKH = kh.LoaiKhach.TenLoai,
                kh.Diem,
                kh.LoaiKhachID
            }).ToList();
            DinhDangLuoi();
        }

        private void txtDiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void cboLoaiKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatUuDaiTuDong();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
          
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Xuất danh sách khách hàng ra tập tin Excel";
                sfd.Filter = "Excel Workbook|*.xlsx";
                sfd.FileName = "DanhSachKhachHang_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        DataTable table = new DataTable();
                        // Thiết lập các cột dựa đúng theo Model của bạn
                        table.Columns.Add("Mã KH", typeof(int));
                        table.Columns.Add("Tên Khách Hàng", typeof(string));
                        table.Columns.Add("Số Điện Thoại", typeof(string));
                        table.Columns.Add("Điểm Tích Lũy", typeof(int));
                        table.Columns.Add("Loại Khách", typeof(string));

                    // Truy vấn lấy dữ liệu kèm theo bảng LoaiKhach để lấy TenLoai
                    var danhSachKhachHang = db.KhachHang.Include(x => x.LoaiKhach).ToList();

                    foreach (var k in danhSachKhachHang)
                        {
                            table.Rows.Add(
                                k.ID,
                                k.TenKH,      // Đã khớp với TenKH trong Model
                                k.DienThoai,  // Đã khớp với DienThoai
                                k.Diem,       // Điểm kiểu int, không cần ?? 0 nữa
                                k.LoaiKhach?.TenLoai ?? "Chưa xác định" // Lấy tên loại (VIP/Thường)
                            );
                        }

                        using (ClosedXML.Excel.XLWorkbook wb = new ClosedXML.Excel.XLWorkbook())
                        {
                            var sheet = wb.Worksheets.Add(table, "Khách Hàng");

                            // Trang trí tiêu đề cho chuyên nghiệp
                            var header = sheet.Row(1);
                            header.Style.Font.Bold = true;
                            header.Style.Fill.BackgroundColor = ClosedXML.Excel.XLColor.AliceBlue;

                            sheet.Columns().AdjustToContents();
                            wb.SaveAs(sfd.FileName);

                            MessageBox.Show("Xuất danh sách khách hàng thành công!", "Thông báo",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi hệ thống",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
        }
    }
}


     
    



