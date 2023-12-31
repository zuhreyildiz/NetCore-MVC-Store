using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repositories;

public class RepositoryContext : DbContext
{
    // Dependency Injection
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>()
        .HasData(
            new Product() { ProductId = 1, ProductName = "Computer", Price = 30_000 },
            new Product() { ProductId = 2, ProductName = "Keyboard", Price = 2_000 },
            new Product() { ProductId = 3, ProductName = "Mouse", Price = 1_500 },
            new Product() { ProductId = 4, ProductName = "Monitör", Price = 12_000 },
            new Product() { ProductId = 5, ProductName = "Deck", Price = 3_000 }
        );
        modelBuilder.Entity<Category>()
        .HasData(
            new Category() { CategoryId = 1, CategoryName = "Book" },
            new Category() { CategoryId = 2, CategoryName = "Electronic" }
        );

    }
}