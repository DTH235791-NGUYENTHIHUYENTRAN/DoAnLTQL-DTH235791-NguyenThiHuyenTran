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

            if (username == "" || password == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            using (QLBidaDbContext db = new QLBidaDbContext())
            {
                var user = db.Users
                             .FirstOrDefault(x => x.Username == username && x.Password == password);

                if (user != null)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    this.Role = user.Role;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                }
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
