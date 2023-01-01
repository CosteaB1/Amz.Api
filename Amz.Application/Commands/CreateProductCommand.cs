using Amz.Domain.Models;
using MediatR;

namespace Amz.Application.Commands
{
    public class CreateProductCommand : IRequest<Product>
    {
        public string Name { get; set; }
    }
}
