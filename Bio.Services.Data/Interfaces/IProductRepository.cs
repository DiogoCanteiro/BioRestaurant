using Bio.Services.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bio.Services.Data.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDTO>> GetProducts();

        Task<ProductDTO> GetProductById(int productId);

        Task<ProductDTO> CreateUpdateProduct(ProductDTO productDTO);

        Task<bool> DeleteProduct(int productId);
    }
}
