using Microsoft.EntityFrameworkCore;
using System;

public class ProductDbContext : DbContext
{
    public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) { }

    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Seed some initial data
        modelBuilder.Entity<Product>().HasData(
            new Product { ProductId = 1, Name = "Laptop", Price = 1500, Category = "Electronics" },
            new Product { ProductId = 2, Name = "Phone", Price = 800, Category = "Electronics" }
        );
    }
}
