using Amz.Application.Commands.Products;
using Amz.Application.Dto.Product;
using Amz.DAL.Context;
using Amz.Domain.Models;
using AutoMapper;
using MediatR;

namespace Amz.Application.CommandHandlers.Products
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ProductDto>
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
            var newProduct = _mapper.Map<Product>(request); // I think we can insert into Db from DTO
            _ctx.Products.Add(newProduct);
            await _ctx.SaveChangesAsync();
            var response = _mapper.Map<ProductDto>(newProduct);
            return response;
        }
    }
}
