using Bio.Services.Data.DbContexts;
using Bio.Services.Data.DbModels;
using Bio.Services.Data.Interfaces;
using Bio.Services.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bio.Services.Data.Repositories
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(ApplicationDbContext db) : base(db) { }

        public async Task<Product> GetProductById(int productId)
        {
            return await _db.Products.FirstOrDefaultAsync(x => x.ProductId == productId);
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _db.Products.ToListAsync();
        }
    }
}
