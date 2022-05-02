using AutoMapper;
using Bio.Services.ShoppingCartAPI.Data.DbModels;
using Bio.Services.ShoppingCartAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bio.Services.ShoppingCartAPI.Business.AutoMapper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<ProductDTO, Product>().ReverseMap();
            CreateMap<CartHeaderDTO, CartHeader>().ReverseMap();
            CreateMap<CartDetailsDTO, CartDetails>().ReverseMap();
            CreateMap<CartDTO, Cart>().ReverseMap();
        }
    }
}
