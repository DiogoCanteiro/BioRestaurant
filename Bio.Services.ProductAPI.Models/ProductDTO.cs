﻿namespace Bio.Services.ProductAPI.Models
{
    public class ProductDTO
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
     
    }
}
