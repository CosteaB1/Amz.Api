using Amz.Domain.Models;
using MediatR;

namespace Amz.Application.Commands
{
    public class CreateProductCommand : IRequest<Product>
    {
        public Product NewProduct { get; set; }
    }
}
