using Microsoft.EntityFrameworkCore;
using CRUDApplication.Models;

namespace CRUDApplication.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Factory> Factories { get; set; }
    }
}
