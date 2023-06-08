using Amz.Application.Commands.Products;
using Amz.Application.Dto.Product;
using Amz.DAL.Context;
using Amz.Domain.Models;
using Amz.Domain.ValueObjects.Product;
using AutoMapper;
using MediatR;

namespace Amz.Application.CommandHandlers.Products
{
    public class
        CreateProductCommandHandler : IRequestHandler<CreateProductCommand,
            ProductDto> // to change to public sealed record
    {
        private readonly AmzDbContext _ctx;
        private readonly IMapper _mapper;

        public CreateProductCommandHandler(AmzDbContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }

        public async Task<ProductDto> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var nameResult = Name.Create(request.Name);

            if (nameResult.IsFailure)
            {
                // log error
                //return smth;
            }

            var priceResult = Money.Create(request.Price); // log error
            var descriptionResult = Description.Create(request.Description); // log error
            var otherDetailsResult = OtherDetails.Create(request.OtherDetails); // log error
            
            var product = Product.Create(nameResult.Value, descriptionResult.Value, request.CategoryId,
                request.SubCategoryId, otherDetailsResult.Value, request.SupplierId, request.Quantity,
                priceResult.Value);
            //var newProduct = _mapper.Map<Product>(request); // I think we can insert into Db from DTO
            var productResult = product;

            if (product.IsFailure)
            {
                //loggin
                // return smth;
            }

            _ctx.Products.Add(productResult.Value);
            await _ctx.SaveChangesAsync();
            var response = _mapper.Map<ProductDto>(product);
            return response;
        }
    }
}