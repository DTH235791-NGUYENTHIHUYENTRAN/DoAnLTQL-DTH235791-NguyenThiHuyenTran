using Microsoft.EntityFrameworkCore;
using QuanLyTienGioBBD.Data;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;


namespace QuanLyTienGioBBD.Forms
{
    public partial class frmDangNhap : Form
    {
        public string Role = "";

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '*';
        }

        private void btndn_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text.Trim();
            string password = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            try
            {
                using (QLBidaDbContext db = new QLBidaDbContext())
                {
                    // THAY ĐỔI TẠI ĐÂY: 
                    // 1. Kiểm tra TrangThai == true (Chỉ cho người đang làm đăng nhập)
                    // 2. Thêm kiểm tra null cho TenDangNhap để tránh lỗi hệ thống
                    var nhanVien = db.NhanVien
                                     .FirstOrDefault(x => x.TrangThai == true &&
                                                         x.TenDangNhap != null &&
                                                         x.TenDangNhap.Trim() == username);

                    if (nhanVien != null)
                    {
                        // Kiểm tra mật khẩu (Sử dụng Equals để an toàn hơn Trim)
                        if (nhanVien.MatKhau != null && nhanVien.MatKhau.Trim() == password)
                        {
                            MessageBox.Show($"Chào mừng {nhanVien.TenNV} trở lại!");
                            this.Role = nhanVien.ChucVu;
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không chính xác!");
                        }
                    }
                    else
                    {
                        // Nếu không tìm thấy, có thể là sai tên DN hoặc tài khoản đã bị "Xóa" (TrangThai = false)
                        MessageBox.Show("Tài khoản không tồn tại hoặc đã bị khóa!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            
            }
        }

            private void btnHuybo_Click(object sender, EventArgs e)
                {
                    this.DialogResult = DialogResult.Cancel;
                }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btndn_Click(sender, e);
            }
        }
    }
}
