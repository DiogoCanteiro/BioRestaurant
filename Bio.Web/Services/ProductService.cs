using Bio.Web.Models;
using Bio.Web.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Bio.Web.Services
{
    public class ProductService : BaseService, IProductService
    {
        private readonly IHttpClientFactory _clientFactory;

        public ProductService(IHttpClientFactory clientFactory) : base(clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<T> CreateProductAsync<T>(ProductDTO productDTO)
        {
            var apiRequest = new ApiRequest
            {
                APIType = Configurations.APIType.POST,
                Data = productDTO,
                Url = $"{Configurations.ProductApiBase}/api/products",
                AccessToken = ""
            };

            return await SendAsync<T>(apiRequest);
        }

        public async Task<T> DeleteProductAsync<T>(int id)
        {
            var apiRequest = new ApiRequest
            {
                APIType = Configurations.APIType.DELETE,
                Url = $"{Configurations.ProductApiBase}/api/products/{id}",
                AccessToken = ""
            };

            return await SendAsync<T>(apiRequest);
        }

        public async Task<T> GetAllProductsAsync<T>()
        {
            var apiRequest = new ApiRequest
            {
                APIType = Configurations.APIType.GET,
                Url = $"{Configurations.ProductApiBase}/api/products",
                AccessToken = ""
            };

            return await SendAsync<T>(apiRequest);
        }

        public async Task<T> GetProductByIdAsync<T>(int id)
        {
            var apiRequest = new ApiRequest
            {
                APIType = Configurations.APIType.GET,
                Url = $"{Configurations.ProductApiBase}/api/products/{id}",
                AccessToken = ""
            };

            return await SendAsync<T>(apiRequest);
        }

        public async Task<T> UpdateProductAsync<T>(ProductDTO productDTO)
        {
            var apiRequest = new ApiRequest
            {
                APIType = Configurations.APIType.PUT,
                Data = productDTO,
                Url = $"{Configurations.ProductApiBase}/api/products",
                AccessToken = ""
            };

            return await SendAsync<T>(apiRequest);
        }
    }
}
