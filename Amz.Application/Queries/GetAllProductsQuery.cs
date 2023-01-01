using Amz.Domain.Models;
using MediatR;

namespace Amz.Application.Queries
{
    public class GetAllProductsQuery : IRequest<List<Product>>
    {

    }
}
