﻿using Bio.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bio.Web.Services.IServices
{
    public interface IProductService : IBaseService
    {
        Task<T> GetAllProductsAsync<T>();
        Task<T> GetProductByIdAsync<T>(int id);
        Task<T> CreateProductAsync<T>(ProductDTO productDTO, string token);
        Task<T> UpdateProductAsync<T>(ProductDTO productDTO, string token);
        Task<T> DeleteProductAsync<T>(int id, string token);

    }
}
