using AutoMapper;
using Mango.Servrces.ProductAPI.Models;
using Mango.Servrces.ProductAPI.Models.Dto;

namespace Mango.Servrces.ProductAPI
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<ProductDTO, Product>();
            CreateMap<Product, ProductDTO>();
        }
    }
}
