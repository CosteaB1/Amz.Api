using Amz.Api.ViewModels.Product;
using Amz.Application.Commands;
using AutoMapper;

namespace Amz.Api.AutoMapperProfiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductCreateViewModel, CreateProductCommand>();
        }
    }
}
