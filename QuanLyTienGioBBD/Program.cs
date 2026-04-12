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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //  Application.Run(new frmKhachHang());
            // Application.Run(new FrmNhanVien());
            // Application.Run(new FrmBanBiDa());
            //  Application.Run(new FrmDichVu());
            // Application.Run(new FrmHoaDon(1));
            // Application.Run(new FrmHoaDon_ChiTiet());
            // Application.Run(new FrmQuanLyBan());
            //   Application.Run(new FormTrangChu());
             Application.Run(new FrmThongKeDoanhThu());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmDangNhap login = new frmDangNhap();

            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FormTrangChu(login.Role));
            }
        }
    }
    }
