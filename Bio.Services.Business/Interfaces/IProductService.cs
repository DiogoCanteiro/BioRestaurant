using Bio.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bio.Services.Business.Interfaces
{
    public interface IProductService
    {
        public Task<IEnumerable<ProductDTO>> GetProducts();
        public Task<ProductDTO> GetProductById(int productId);

        public Task<ProductDTO> CreateUpdateProduct(ProductDTO productDTO);

        public Task<bool> DeleteProduct(int productId);
    }
}
