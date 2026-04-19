using QuanLyTienGioBBD.Forms;

namespace QuanLyTienGioBBD
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 1. Thi?t l?p c?u h?nh h? th?ng (Luôn ð? ? ð?u)
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize();

            // 2. Kh?i t?o form ðãng nh?p
            frmDangNhap login = new frmDangNhap();

            // 3. Hi?n th? form ðãng nh?p dý?i d?ng Dialog
            // N?u ngý?i dùng ðãng nh?p thành công (DialogResult = OK)
            if (login.ShowDialog() == DialogResult.OK)
            {
                // 4. Ch?y Form chính và truy?n quy?n (Role) vào
                Application.Run(new FormTrangChu(login.Role));
            }
            else
            {
                // N?u ngý?i dùng nh?n thoát ho?c ðãng nh?p sai th? thoát h?n ?ng d?ng
                Application.Exit();
            }
        }
    }
    }
