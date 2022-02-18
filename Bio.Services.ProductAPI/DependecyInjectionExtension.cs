using Bio.Services.Business.Implementations;
using Bio.Services.Business.Interfaces;
using Bio.Services.Data.Interfaces;
using Bio.Services.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bio.Services.ProductAPI
{
    public static class DependecyInjectionExtension
    {
        public static void RegisterDI(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICategoryService, CategoryService>();
        }
    }
}
