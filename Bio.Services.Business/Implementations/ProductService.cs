using Bio.Services.Business.Interfaces;
using Bio.Services.Data.Interfaces;
using Bio.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bio.Services.Business.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ProductDTO> CreateUpdateProduct(ProductDTO productDTO)
        {
            return await _productRepository.CreateUpdateProduct(productDTO);
        }

        public async Task<bool> DeleteProduct(int productId)
        {
            return await _productRepository.DeleteProduct(productId);
        }

        public async Task<ProductDTO> GetProductById(int productId)
        {
            return await _productRepository.GetProductById(productId);
        }

        public async Task<IEnumerable<ProductDTO>> GetProducts()
        {
            return await _productRepository.GetProducts();
        }
    }
}
