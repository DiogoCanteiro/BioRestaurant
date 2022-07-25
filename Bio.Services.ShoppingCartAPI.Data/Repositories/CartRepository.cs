using Bio.Services.ShoppingCartAPI.Data.DbContexts;
using Bio.Services.ShoppingCartAPI.Data.DbModels;
using Bio.Services.ShoppingCartAPI.Data.Interfaces;
using System.Threading.Tasks;

namespace Bio.Services.ShoppingCartAPI.Data.Repositories
{
    public class CartRepository : ICartRepository
    {
        private readonly ApplicationDbContext _db;

        public CartRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<bool> ClearCart(string userId)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Cart> CreateUpdateCart(Cart cart)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Cart> GetCartByUserId(string userId)
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> RemoveFromCart(int cardDetailsId)
        {
            throw new System.NotImplementedException();
        }
    }
}
