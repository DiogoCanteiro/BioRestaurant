using System.ComponentModel.DataAnnotations;

namespace Bio.Services.ProductAPI.Data.DbModels
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
