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
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = 1,
                Name = "Fruit",
                Description = "A fruit is a mature ovary and its associated parts.",
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = 2,
                Name = "Dessert",
                Description = "Dessert is a course that concludes a meal.",
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = 3,
                Name = "Entree",
                Description = "Dish served before the main course of a meal.",
            });


            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Mango",
                Price = 0.79,
                Description = "A mango is an edible stone fruit produced by the tropical tree Mangifera indica.",
                ImageUrl = "",
                CategoryId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Cheese Ball",
                Price = 2.59,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec consectetur erat in tristique molestie. Mauris consectetur nulla sed sem mattis pulvinar.<br/>Aliquam posuere, lorem a lobortis malesuada, odio dui vestibulum nisl, vel suscipit leo augue in ante",
                ImageUrl = "",
                CategoryId = 3
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Cupcake",
                Price = 5,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec consectetur erat in tristique molestie. Mauris consectetur nulla sed sem mattis pulvinar.<br/>Aliquam posuere, lorem a lobortis malesuada, odio dui vestibulum nisl, vel suscipit leo augue in ante",
                ImageUrl = "",
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Hibachi Chicken",
                Price = 15,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec consectetur erat in tristique molestie. Mauris consectetur nulla sed sem mattis pulvinar.<br/>Aliquam posuere, lorem a lobortis malesuada, odio dui vestibulum nisl, vel suscipit leo augue in ante",
                ImageUrl = "",
                CategoryId = 3
            });
        }
    }
}
