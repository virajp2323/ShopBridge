using Microsoft.EntityFrameworkCore;
using ShopBridgeApi.Models;

namespace ShopBridgeApi.Data
{
    public class ShopBridgeContext : DbContext
    {
        public ShopBridgeContext(DbContextOptions<ShopBridgeContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}
