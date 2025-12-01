using Microsoft.EntityFrameworkCore;
using UrunStokTakip.Models;

namespace UrunStokTakip.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
