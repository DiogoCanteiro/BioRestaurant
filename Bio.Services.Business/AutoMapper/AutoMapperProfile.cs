using AutoMapper;
using Bio.Services.Data.DbModels;
using Bio.Services.Models;

namespace Bio.Services.Business.AutoMapper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<ProductDTO, Product>().ReverseMap();
        }
    }
}
