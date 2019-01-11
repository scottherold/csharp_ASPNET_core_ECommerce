using Microsoft.EntityFrameworkCore;

// Context class for DB connections for the models

namespace ECommerce.Models
{
    public class ECommerceContext : DbContext
    {
        public ECommerceContext(DbContextOptions<ECommerceContext> options) : base(options) { }
        
        // DBQueries / Tables in DB
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}