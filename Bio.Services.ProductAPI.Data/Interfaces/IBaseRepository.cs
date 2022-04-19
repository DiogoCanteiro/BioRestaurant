using System.Threading.Tasks;

namespace Bio.Services.ProductAPI.Data.Interfaces
{
    public interface IBaseRepository
    {
        Task<T> Create<T>(T entity) where T : class;

        Task<T> Update<T>(T entity) where T : class;

        Task<bool> Delete<T>(T entity) where T : class;
    }
}
