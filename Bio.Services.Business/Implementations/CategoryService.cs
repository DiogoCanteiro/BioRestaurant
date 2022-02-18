using AutoMapper;
using Bio.Services.Business.Interfaces;
using Bio.Services.Data.DbModels;
using Bio.Services.Data.Interfaces;
using Bio.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bio.Services.Business.Implementations
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<CategoryDTO> CreateUpdateCategory(CategoryDTO categoryDTO)
        {
            Category category = _mapper.Map<Category>(categoryDTO);

            if (category.CategoryId > 0)
            {
                category = await _categoryRepository.Update(category);
            }
            else
            {
                category = await _categoryRepository.Create(category);
            }

            return _mapper.Map<CategoryDTO>(category);
        }

        public async Task<bool> DeleteCategory(int categoryId)
        {
            Category categoryToDelete = await _categoryRepository.GetCategoryById(categoryId);

            return await _categoryRepository.Delete(categoryToDelete);
        }

        public async Task<IEnumerable<CategoryDTO>> GetCategories()
        {
            IEnumerable<Category> categories = await _categoryRepository.GetCategories();

            return _mapper.Map<IEnumerable<CategoryDTO>>(categories);
        }

        public async Task<CategoryDTO> GetCategoryById(int categoryId)
        {
            Category category = await _categoryRepository.GetCategoryById(categoryId);

            return _mapper.Map<CategoryDTO>(category);
        }
    }
}
