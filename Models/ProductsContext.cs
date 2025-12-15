using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ProductAPI.Models
{
    public class ProductsContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public ProductsContext(DbContextOptions<ProductsContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, ProductName = "Laptop", Price = 999.99m, IsActive = true },
                new Product { ProductId = 2, ProductName = "Smartphone", Price = 499.99m, IsActive = true },
                new Product { ProductId = 3, ProductName = "Tablet", Price = 299.99m, IsActive = false },
                new Product { ProductId = 4, ProductName = "TV", Price = 759.99m, IsActive = false },
                new Product { ProductId = 5, ProductName = "PlayStation 5", Price = 910.99m, IsActive = false }
            );
        }

        public DbSet<Product> Products { get; set; }
    }
}
