using Amz.Application.Commands.Products;
using Amz.Application.Dto.Product;
using Amz.Domain.Models;
using AutoMapper;

namespace Amz.Application.AutoMapperProfiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<CreateProductCommand, Product>();
            CreateMap<Product, ProductDto>();
        }
    }
}
