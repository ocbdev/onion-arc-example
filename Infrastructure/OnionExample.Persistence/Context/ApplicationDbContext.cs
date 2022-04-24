using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using OnionExample.Domain.Entities;

namespace OnionExample.Persistence.Context;

public class ApplicationDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
            new Product()
            {
                Id = Guid.NewGuid(),
                ProductName = "Pen",
                Price = 10,
                Quantity = 100
            },
            new Product()
            {
                Id = Guid.NewGuid(),
                ProductName = "Book",
                Price = 100,
                Quantity = 300
            },
            new Product()
            {
                Id = Guid.NewGuid(),
                ProductName = "Paper",
                Price = 30,
                Quantity = 500
            }
        );
        base.OnModelCreating(modelBuilder);
    }
}