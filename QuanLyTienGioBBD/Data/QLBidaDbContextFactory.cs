using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Configuration;

namespace QuanLyTienGioBBD.Data
{
    public class QLBidaDbContextFactory
        : IDesignTimeDbContextFactory<QLBidaDbContext>
    {
        public QLBidaDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<QLBidaDbContext>();

            string conn = ConfigurationManager
                .ConnectionStrings["QLBidaConnection"]
                .ConnectionString;

            optionsBuilder.UseSqlServer(conn);

            return new QLBidaDbContext(optionsBuilder.Options);
        }
    }
}
