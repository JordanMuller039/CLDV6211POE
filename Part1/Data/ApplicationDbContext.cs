using Microsoft.EntityFrameworkCore;
using Part1.Models;
namespace Part1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Transactions> Transactions { get; set; }
    }
}
