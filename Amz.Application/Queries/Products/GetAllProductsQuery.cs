using Amz.Domain.Models;
using MediatR;

namespace Amz.Application.Queries.Products
{
    public class GetAllProductsQuery : IRequest<List<Product>>
    {

    }
}
