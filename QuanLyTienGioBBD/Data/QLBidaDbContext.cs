using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace QuanLyTienGioBBD.Data
{
    public class QLBidaDbContext : DbContext
    {
        public QLBidaDbContext(DbContextOptions<QLBidaDbContext> options)
            : base(options)

        {
        }
        public QLBidaDbContext()
        {
        }
        public DbSet<LoaiBan> LoaiBan { get; set; }
        public DbSet<BanBiDa> BanBida { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<HoaDonChiTiet> HoaDonChiTiet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    ConfigurationManager
                        .ConnectionStrings["QLBidaConnection"]
                        .ConnectionString);
            }
        }
    }
}
