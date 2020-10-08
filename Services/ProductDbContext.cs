using Microsoft.EntityFrameworkCore;
using ProductAPI.Entities;
namespace ProductAPI.Services
{
     public class ProductDbContext : DbContext
     {
          public DbSet<ProductAPI.Entities.Product> Products { get; set; }
          public ProductDbContext(
               DbContextOptions<ProductDbContext> options)
               : base(options)
          {
               Database.EnsureCreated();
          }
     }
}