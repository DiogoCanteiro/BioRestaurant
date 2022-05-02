using Bio.Services.ShoppingCartAPI.Data.DbModels;
using Microsoft.EntityFrameworkCore;

namespace Bio.Services.ShoppingCartAPI.Data.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<CartHeader> CartHeader { get; set; }
        public DbSet<CartDetails> CartDetails { get; set; }
    }
}
