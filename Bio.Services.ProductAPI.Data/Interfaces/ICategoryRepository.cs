using Bio.Services.ProductAPI.Data.DbModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bio.Services.ProductAPI.Data.Interfaces
{
    public interface ICategoryRepository : IBaseRepository
    {
        Task<Category> GetCategoryById(int categoryId);

        Task<IEnumerable<Category>> GetCategories();     
    }
}
