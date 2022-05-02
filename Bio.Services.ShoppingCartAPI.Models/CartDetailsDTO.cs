using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bio.Services.ShoppingCartAPI.Models
{
    public class CartDetailsDTO
    {
        public int CartDetailsId { get; set; }
        public virtual CartHeaderDTO CartHeader { get; set; }
        public virtual ProductDTO Product { get; set; }
        public int Count { get; set; }
    }
}
