using Amz.Application.Queries;
using Amz.DAL.Context;
using Amz.Domain.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Amz.Application.QueryHandlers
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, List<Product>>
    {
        private readonly AmzDbContext _ctx;  // to use directly context or to use Repository pattern ? 
        public GetAllProductsQueryHandler(AmzDbContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<List<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            return await _ctx.Products.ToListAsync();
        }
    }
}
