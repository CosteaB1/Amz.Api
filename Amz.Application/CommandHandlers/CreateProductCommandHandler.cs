using Amz.Application.Commands;
using Amz.DAL.Context;
using Amz.Domain.Models;
using MediatR;

namespace Amz.Application.CommandHandlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Product>
    {
        private readonly AmzDbContext _ctx;
        public CreateProductCommandHandler(AmzDbContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<Product> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            _ctx.Products.Add(request.NewProduct);
            await _ctx.SaveChangesAsync();
            return request.NewProduct;
        }
    }
}
