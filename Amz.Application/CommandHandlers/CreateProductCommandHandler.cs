using Amz.Application.Commands;
using Amz.DAL.Context;
using Amz.Domain.Models;
using AutoMapper;
using MediatR;

namespace Amz.Application.CommandHandlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Product>
    {
        private readonly AmzDbContext _ctx;
        private readonly IMapper _mapper;
        public CreateProductCommandHandler(AmzDbContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }
        public async Task<Product> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var newProduct = _mapper.Map<Product>(request);
            _ctx.Products.Add(newProduct);
            await _ctx.SaveChangesAsync();
            return newProduct;
        }
    }
}
