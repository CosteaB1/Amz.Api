using Amz.Application.Commands.Products;
using Amz.Application.Dto.Product;
using Amz.Application.Exceptions;
using Amz.DAL.Context;
using Amz.Domain.Models;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Amz.Application.CommandHandlers.Products
{
    internal class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, ProductDto>
    {
        private readonly AmzDbContext _ctx;
        private readonly IMapper _mapper;

        public UpdateProductCommandHandler(AmzDbContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }

        public async Task<ProductDto> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var productToUpdate = await _ctx.Products.SingleOrDefaultAsync(x => x.Id == request.Id);

            if (productToUpdate is null)
            {
                throw EntityNotFoundException.OfType<Product>(request.Id);
            }
            _ctx.Entry(productToUpdate).CurrentValues.SetValues(request);
            await _ctx.SaveChangesAsync();

            var response = _mapper.Map<ProductDto>(productToUpdate);

            return response;
        }
    }
}
