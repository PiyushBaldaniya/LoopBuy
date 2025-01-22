using Microsoft.EntityFrameworkCore;
using OrderService.Models;

namespace OrderService.Data
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options) { }

        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed initial data
            modelBuilder.Entity<Order>().HasData(
                new Order { OrderId = 1, ProductId = 1, Quantity = 2, TotalPrice = 3000, OrderStatus = "Pending" },
                new Order { OrderId = 2, ProductId = 2, Quantity = 1, TotalPrice = 800, OrderStatus = "Completed" }
            );
        }
    }
}
