using Bio.Services.ProductAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bio.Services.ProductAPI.Business.Interfaces
{
    public interface ICategoryService
    {
        public Task<IEnumerable<CategoryDTO>> GetCategories();
        public Task<CategoryDTO> GetCategoryById(int categoryId);

        public Task<CategoryDTO> CreateUpdateCategory(CategoryDTO categoryDTO);

        public Task<bool> DeleteCategory(int categoryId);
    }
}
