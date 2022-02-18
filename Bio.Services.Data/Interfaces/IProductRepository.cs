using Bio.Services.Data.DbModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bio.Services.Data.Interfaces
{
    public interface IProductRepository : IBaseRepository
    {
        Task<IEnumerable<Product>> GetProducts();

        Task<Product> GetProductById(int productId);

    }
}
