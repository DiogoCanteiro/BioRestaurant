using Bio.Services.Data.DbModels;
using Microsoft.EntityFrameworkCore;

namespace Bio.Services.Data.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Mango",
                Price = 0.79,
                Description = "A mango is an edible stone fruit produced by the tropical tree Mangifera indica.",
                ImageUrl = "",
                CategoryName = "Fruit"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Cheese Ball",
                Price = 2.59,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec consectetur erat in tristique molestie. Mauris consectetur nulla sed sem mattis pulvinar.<br/>Aliquam posuere, lorem a lobortis malesuada, odio dui vestibulum nisl, vel suscipit leo augue in ante",
                ImageUrl = "",
                CategoryName = "Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Cupcake",
                Price = 5,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec consectetur erat in tristique molestie. Mauris consectetur nulla sed sem mattis pulvinar.<br/>Aliquam posuere, lorem a lobortis malesuada, odio dui vestibulum nisl, vel suscipit leo augue in ante",
                ImageUrl = "",
                CategoryName = "Dessert"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Hibachi Chicken",
                Price = 15,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec consectetur erat in tristique molestie. Mauris consectetur nulla sed sem mattis pulvinar.<br/>Aliquam posuere, lorem a lobortis malesuada, odio dui vestibulum nisl, vel suscipit leo augue in ante",
                ImageUrl = "",
                CategoryName = "Entree"
            });
        }
    }
}
