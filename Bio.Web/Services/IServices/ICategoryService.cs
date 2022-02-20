using Bio.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bio.Web.Services.IServices
{
    public interface ICategoryService : IBaseService
    {
        Task<T> GetAllCategoriesAsync<T>();
        Task<T> GetCategoryByIdAsync<T>(int id);
        Task<T> CreateCategoryAsync<T>(CategoryDTO categoryDTO);
        Task<T> UpdateCategoryAsync<T>(CategoryDTO categoryDTO);
        Task<T> DeleteCategoryAsync<T>(int id);
    }
}
