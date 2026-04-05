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

namespace QuanLyTienGioBBD
{
    public partial class FrmNhanVien : Form
    {
        private QLBidaDbContext db = new QLBidaDbContext();
        private int? maDangChon = null;
        private string role;

        public FrmNhanVien(string role)
        {
            InitializeComponent();
            this.role = role;

            // XỊN: Ẩn mật khẩu trong TextBox khi gõ
            txtMatKhau.UseSystemPasswordChar = true;
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
            SetPermissions();


        }

        private void SetPermissions()
        {
            // Phân quyền chuyên nghiệp
            bool isAdmin = string.Equals(role, "Admin", StringComparison.OrdinalIgnoreCase);
            btnXoa.Visible = isAdmin;

            // Nếu không phải Admin thì chỉ cho xem, không cho sửa tài khoản/chức vụ
            if (!isAdmin)
            {
                txtTenDangNhap.ReadOnly = true;
                txtChucVu.Enabled = false;
                lblThongBaoQuyen.Text = "Chế độ: Nhân viên (Hạn chế quyền)";
                lblThongBaoQuyen.ForeColor = Color.OrangeRed;
            }
        }
        private void LoadData()
        {
            // Sử dụng Select để không lấy những trường thừa, tăng tốc độ
            dgvNhanVien.DataSource = db.NhanVien
                .Select(nv => new
                {
                    nv.MaNV,
                    nv.TenNV,
                    nv.SoDienThoai,
                    nv.TenDangNhap,
                    nv.MatKhau, // Vẫn lấy để đổ vào Textbox nhưng ẩn trên lưới
                    nv.ChucVu
                })
                .ToList();

            // Định dạng tiêu đề cột
            dgvNhanVien.Columns["MaNV"].HeaderText = "ID";
            dgvNhanVien.Columns["TenNV"].HeaderText = "Họ Tên";
            dgvNhanVien.Columns["SoDienThoai"].HeaderText = "SĐT";
            dgvNhanVien.Columns["TenDangNhap"].HeaderText = "Tài Khoản";
            dgvNhanVien.Columns["ChucVu"].HeaderText = "Chức Vụ";

            // XỊN: Tuyệt đối không hiện cột mật khẩu trên lưới
            if (dgvNhanVien.Columns["MatKhau"] != null)
                dgvNhanVien.Columns["MatKhau"].Visible = false;

            DinhDangLuoi();
        }

        private void DinhDangLuoi()
        {
            // Tô màu dòng được chọn cho chuyên nghiệp
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;
        }

        private void ClearForm()
        {
            txtHoVaTen.Clear();
            txtSoDienThoai.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            txtChucVu.Clear();
            maDangChon = null;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearForm();
            txtTenDangNhap.ReadOnly = false; // Mở khóa để nhập tài khoản mới
            txtHoVaTen.Focus();
        }
    


        private void btnLuu_Click(object sender, EventArgs e)
        {

            // Validate dữ liệu tập trung
            if (!ValidateInput()) return;

            try
            {
                if (maDangChon == null) // THÊM MỚI
                {
                    // Check trùng tài khoản
                    if (db.NhanVien.Any(x => x.TenDangNhap == txtTenDangNhap.Text.Trim()))
                    {
                        MessageBox.Show("Tên đăng nhập này đã được sử dụng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    NhanVien nv = new NhanVien()
                    {
                        TenNV = txtHoVaTen.Text.Trim(),
                        SoDienThoai = txtSoDienThoai.Text.Trim(),
                        TenDangNhap = txtTenDangNhap.Text.Trim(),
                        MatKhau = txtMatKhau.Text.Trim(),
                        ChucVu = txtChucVu.Text.Trim()
                    };
                    db.NhanVien.Add(nv);
                    MessageBox.Show("Thêm nhân viên mới thành công!");
                }
                else // CẬP NHẬT
                {
                    var nv = db.NhanVien.Find(maDangChon);
                    if (nv != null)
                    {
                        nv.TenNV = txtHoVaTen.Text.Trim();
                        nv.SoDienThoai = txtSoDienThoai.Text.Trim();
                        nv.MatKhau = txtMatKhau.Text.Trim();
                        if (role == "Admin") nv.ChucVu = txtChucVu.Text.Trim();

                        MessageBox.Show("Cập nhật thông tin thành công!");
                    }
                }

                db.SaveChanges();
                LoadData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtHoVaTen.Text) || string.IsNullOrWhiteSpace(txtTenDangNhap.Text) || string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng không để trống các trường bắt buộc!", "Thông báo");
                return false;
            }

            // Regex kiểm tra SĐT (Xịn hơn check length thông thường)
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtSoDienThoai.Text, @"^[0-9]{9,11}$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ (9-11 chữ số)!");
                return false;
            }
            return true;
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (maDangChon == null) return;

            // XỊN: Chỉ Admin mới có quyền xóa và phải nhập xác nhận
            var nv = db.NhanVien.Find(maDangChon);
            if (nv == null) return;

            if (nv.TenDangNhap.ToLower() == "admin")
            {
                MessageBox.Show("Không thể xóa tài khoản Admin hệ thống!");
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn xóa nhân viên {nv.TenNV}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.NhanVien.Remove(nv);
                db.SaveChanges();
                LoadData();
                ClearForm();
                MessageBox.Show("Đã xóa nhân viên.");
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadData();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvNhanVien.Rows[e.RowIndex];
            maDangChon = Convert.ToInt32(row.Cells["MaNV"].Value);

            txtHoVaTen.Text = row.Cells["TenNV"].Value?.ToString();
            txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value?.ToString();
            txtTenDangNhap.Text = row.Cells["TenDangNhap"].Value?.ToString();
            txtMatKhau.Text = row.Cells["MatKhau"].Value?.ToString();
            txtChucVu.Text = row.Cells["ChucVu"].Value?.ToString();

            // Khi chọn để sửa, khóa ô tài khoản lại (thường tài khoản không cho đổi)
            txtTenDangNhap.ReadOnly = true;
        }

       
    }
}