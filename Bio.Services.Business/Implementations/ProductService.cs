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
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<ProductDTO> CreateUpdateProduct(ProductDTO productDTO)
        {
            Product product = _mapper.Map<Product>(productDTO);

            if (product.ProductId > 0)
            {
                product = await _productRepository.Update(product);
            }
            else
            {
                product = await _productRepository.Create(product);
            }

            return _mapper.Map<ProductDTO>(product);
        }

        public async Task<bool> DeleteProduct(int productId)
        {
            Product productToDelete = await _productRepository.GetProductById(productId);

            return await _productRepository.Delete(productToDelete);
        }

        public async Task<ProductDTO> GetProductById(int productId)
        {
            Product product = await _productRepository.GetProductById(productId);

            return _mapper.Map<ProductDTO>(product);
        }

        public async Task<IEnumerable<ProductDTO>> GetProducts()
        {
            IEnumerable<Product> products = await _productRepository.GetProducts();

            return _mapper.Map<List<ProductDTO>>(products);
        }
    }
}
