using Customer.Entities;
using Microsoft.EntityFrameworkCore;

namespace Customer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        public DbSet<Customertbl> Customertbl { get; set; }
    }
}
