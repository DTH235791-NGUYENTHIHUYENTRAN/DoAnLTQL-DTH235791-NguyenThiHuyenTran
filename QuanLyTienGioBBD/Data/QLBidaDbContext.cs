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
        
        public DbSet<Ban> Ban { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<LoaiKhach> LoaiKhach { get; set; }

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
