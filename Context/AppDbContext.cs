using MasterDetailAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MasterDetailAPI.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> orderDetails { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
