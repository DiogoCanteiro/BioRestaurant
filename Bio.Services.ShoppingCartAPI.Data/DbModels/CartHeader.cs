using System.ComponentModel.DataAnnotations;

namespace Bio.Services.ShoppingCartAPI.Data.DbModels
{
    public class CartHeader
    {
        [Key]
        public int CartHeaderId { get; set; }
        public string UserId { get; set; }
        public string CouponCode { get; set; }
    }
}
