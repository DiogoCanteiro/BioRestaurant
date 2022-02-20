using Bio.Web.Models;
using Bio.Web.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Bio.Web.Services
{
    public class CategoryService : BaseService, ICategoryService
    {
        public CategoryService(IHttpClientFactory clientFactory) : base(clientFactory) { }

        public async Task<T> CreateCategoryAsync<T>(CategoryDTO categoryDTO)
        {
            var apiRequest = new ApiRequest
            {
                APIType = Configurations.APIType.POST,
                Data = categoryDTO,
                Url = $"{Configurations.ProductApiBase}/api/categories",
                AccessToken = ""
            };

            return await SendAsync<T>(apiRequest);
        }

        public async Task<T> DeleteCategoryAsync<T>(int id)
        {
            var apiRequest = new ApiRequest
            {
                APIType = Configurations.APIType.DELETE,
                Url = $"{Configurations.ProductApiBase}/api/categories/{id}",
                AccessToken = ""
            };

            return await SendAsync<T>(apiRequest);
        }

        public async Task<T> GetAllCategoriesAsync<T>()
        {
            var apiRequest = new ApiRequest
            {
                APIType = Configurations.APIType.GET,
                Url = $"{Configurations.ProductApiBase}/api/categories",
                AccessToken = ""
            };

            return await SendAsync<T>(apiRequest);
        }

        public async Task<T> GetCategoryByIdAsync<T>(int id)
        {
            var apiRequest = new ApiRequest
            {
                APIType = Configurations.APIType.GET,
                Url = $"{Configurations.ProductApiBase}/api/categories/{id}",
                AccessToken = ""
            };

            return await SendAsync<T>(apiRequest);
        }

        public async Task<T> UpdateCategoryAsync<T>(CategoryDTO categoryDTO)
        {
            var apiRequest = new ApiRequest
            {
                APIType = Configurations.APIType.PUT,
                Data = categoryDTO,
                Url = $"{Configurations.ProductApiBase}/api/products",
                AccessToken = ""
            };

            return await SendAsync<T>(apiRequest);
        }
    }
}
