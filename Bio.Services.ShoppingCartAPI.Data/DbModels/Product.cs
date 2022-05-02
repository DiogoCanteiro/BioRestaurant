using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bio.Services.ShoppingCartAPI.Data.DbModels
{
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(1, 1000)]
        public double Price { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        //FIX this

        //[Required]
        //public int CategoryId { get; set; }

        //public virtual Category Category { get; set; }
    }
}
