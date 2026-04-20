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

namespace QuanLyTienGioBBD.Forms
{
    public partial class FormTrangChu : Form
    {
        string role;

        public FormTrangChu(string role)
        {
            InitializeComponent();
            this.role = role;
        }

        private void FormTrangChu_Load(object sender, EventArgs e)
        {
          
            string currentRole = role?.Trim().ToLower();

            if (currentRole != "admin")
            {
                mnuNhanVien.Visible = false;   
                mnuDoanhThu.Visible = false;  
               

            }
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmDangNhap f = new frmDangNhap();
            if (f.ShowDialog() == DialogResult.OK)
            {
                FormTrangChu main = new FormTrangChu(f.Role);
                main.Show();
            }
            else
            {
                Application.Exit();
            }
        }

        private void mnuBanBida_Click(object sender, EventArgs e)
        {
            FrmQuanLyBan f = new FrmQuanLyBan((role));
            f.ShowDialog();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(role) || role.Trim().ToLower() != "admin")
            {
                MessageBox.Show("Không có quyền!");
                return;
            }

            
            FrmNhanVien f = new FrmNhanVien(role);
            f.ShowDialog();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            FrmKhachHang f = new FrmKhachHang(role);
            f.ShowDialog();
        }

        private void mnuHoaDon_Click(object sender, EventArgs e)
        {
            
            FrmQuanLyHoaDon f = new FrmQuanLyHoaDon(role);
            f.ShowDialog();
        }

        private void mnuDoanhThu_Click(object sender, EventArgs e)
        {
            if (role == null || role.Trim().ToLower() != "admin")
            {
                MessageBox.Show("Không có quyền!");
                return;
            }

            FrmThongKeDoanhThu f = new FrmThongKeDoanhThu();
            f.ShowDialog();
        }

        private void hươngDânSưDungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
               "HƯỚNG DẪN SỬ DỤNG:\n\n" +
               "1. Chọn bàn để bắt đầu chơi\n" +
               "2. Bấm 'Bắt đầu chơi' để tính giờ\n" +
               "3. Khi xong bấm 'Thanh toán'\n" +
               "4. Quản lý khách hàng tại menu Khách hàng\n" +
               "5. Admin có thể quản lý nhân viên và thống kê doanh thu",
               "Hướng dẫn",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information
           );
        }

      
    }
    }
