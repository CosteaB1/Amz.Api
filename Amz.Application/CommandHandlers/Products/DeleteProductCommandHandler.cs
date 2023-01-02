using Amz.Application.Commands.Products;
using Amz.Application.Exceptions;
using Amz.DAL.Context;
using Amz.Domain.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Amz.Application.CommandHandlers.Products
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, Guid>
    {
        private readonly AmzDbContext _ctx;
        public DeleteProductCommandHandler(AmzDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<Guid> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var productToDelete = await _ctx.Products.SingleOrDefaultAsync(x => x.Id == request.Id);
            if (productToDelete is null)
            {
                throw EntityNotFoundException.OfType<Product>(request.Id);
            }
            _ctx.Products.Remove(productToDelete);
            await _ctx.SaveChangesAsync();
            return request.Id;
        }
    }
}
