using Bio.Services.ProductAPI.Data.DbContexts;
using Bio.Services.ProductAPI.Data.DbModels;
using Bio.Services.ProductAPI.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bio.Services.ProductAPI.Data.Repositories
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext db) : base(db) { }

        public async Task<Category> GetCategoryById(int categoryId)
        {
            return await _db.Categories.FirstOrDefaultAsync(x => x.CategoryId == categoryId);
        }
        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await _db.Categories.ToListAsync();
        }
    }
}
