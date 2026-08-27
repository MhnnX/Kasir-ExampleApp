using Kasir_ExampleApp.Models;
using Microsoft.EntityFrameworkCore;

namespace Kasir_ExampleApp.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MSI\\SQLEXPRESS;Database=kasir_desktop_db;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}