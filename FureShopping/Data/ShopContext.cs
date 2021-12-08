using FureShopping.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FureShopping.Data
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<ProductType> ProductType { get; set; }
    }
}
