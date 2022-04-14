using AutoMapper;
using Bio.Services.ProductAPI.Data.DbModels;
using Bio.Services.ProductAPI.Models;

namespace Bio.Services.ProductAPI.Business.AutoMapper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            //Products
            CreateMap<ProductDTO, Product>();
            CreateMap<Product, ProductDTO>()
                .ForMember(p => p.CategoryName, p => p.MapFrom(src => src.Category.Name));

            //// Categories
            CreateMap<CategoryDTO, Category>().ReverseMap();
        }
    }
}
