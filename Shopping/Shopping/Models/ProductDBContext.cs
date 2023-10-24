
using Microsoft.EntityFrameworkCore;
using Shopping.Models;

namespace Shopping.Models
{
    public class ProductDBContext : DbContext
    {
        public ProductDBContext()
        {
        }

        public ProductDBContext(DbContextOptions<ProductDBContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-7EGMHQLE\\SQLEXPRESS;Initial Catalog=T2208M_Shopping;Persist Security Info=True;User ID=sa;Password=123456;Encrypt=False");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Item> Items { get; set; }
    }
}
