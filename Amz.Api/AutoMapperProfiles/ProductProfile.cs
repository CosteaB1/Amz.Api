using Amz.Api.ViewModels.Product;
using Amz.Application.Commands.Products;
using Amz.Application.Dto.Product;
using AutoMapper;

namespace Amz.Api.AutoMapperProfiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<CreateProductViewModel, CreateProductCommand>();
            CreateMap<ProductDto, CreateProductViewModel>();

            CreateMap<UpdateProductViewModel, UpdateProductCommand>();
            CreateMap<ProductDto, UpdateProductViewModel>();

        }
    }
}
