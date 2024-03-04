using Microsoft.EntityFrameworkCore;
using ItProduct1.Models;

namespace ItProduct1.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Product { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}
