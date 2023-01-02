using Amz.Domain.Models;
using MediatR;

namespace Amz.Application.Commands.Products
{
    public class DeleteProductCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
    }
}
