using Bio.Services.ProductAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bio.Services.ProductAPI.Business.Interfaces
{
    public interface IProductService
    {
        public Task<IEnumerable<ProductDTO>> GetProducts();
        public Task<ProductDTO> GetProductById(int productId);

        public Task<ProductDTO> CreateUpdateProduct(ProductDTO productDTO);

        public Task<bool> DeleteProduct(int productId);
    }
}
