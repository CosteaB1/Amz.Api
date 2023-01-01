using Amz.Application.Commands;
using Amz.Domain.Models;
using AutoMapper;

namespace Amz.Application.AutoMapperProfiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<CreateProductCommand, Product>();
        }
    }
}
