using Microsoft.EntityFrameworkCore;

namespace SimpleCRUD.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) 
        {
                
        }
        public virtual DbSet<Customer> Customers { get; set; }
    }
}
