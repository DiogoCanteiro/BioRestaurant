using Bio.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bio.Services.Business.Interfaces
{
    public interface ICategoryService
    {
        public Task<IEnumerable<CategoryDTO>> GetCategories();
        public Task<CategoryDTO> GetCategoryById(int categoryId);

        public Task<CategoryDTO> CreateUpdateCategory(CategoryDTO categoryDTO);

        public Task<bool> DeleteCategory(int categoryId);
    }
}
