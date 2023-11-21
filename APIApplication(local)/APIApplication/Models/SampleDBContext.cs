using Microsoft.EntityFrameworkCore;
namespace APIApplication.Models
{
    public class SampleDBContext : DbContext
    {
        public SampleDBContext(DbContextOptions<SampleDBContext> options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
