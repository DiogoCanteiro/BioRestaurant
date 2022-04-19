using Bio.Services.ProductAPI.Data.DbContexts;
using Bio.Services.ProductAPI.Data.DbModels;
using Bio.Services.ProductAPI.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bio.Services.ProductAPI.Data.Repositories
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(ApplicationDbContext db) : base(db) { }

        public async Task<Product> GetProductById(int productId)
        {
            return await _db.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(x => x.ProductId == productId);
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _db.Products
                .Include(p => p.Category)
                .ToListAsync();
        }
    }
}
