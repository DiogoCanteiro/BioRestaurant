using Bio.Services.Data.DbContexts;
using Bio.Services.Data.DbModels;
using Bio.Services.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bio.Services.Data.Repositories
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
