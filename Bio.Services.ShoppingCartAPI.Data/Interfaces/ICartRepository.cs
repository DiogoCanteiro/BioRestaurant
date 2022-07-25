using Bio.Services.ShoppingCartAPI.Data.DbModels;
using System.Threading.Tasks;

namespace Bio.Services.ShoppingCartAPI.Data.Interfaces
{
    public interface ICartRepository
    {
        Task<Cart> GetCartByUserId(string userId);
        Task<Cart> CreateUpdateCart(Cart cart);
        Task<bool> RemoveFromCart(int cardDetailsId);
        Task<bool> ClearCart(string userId);
    }
}
