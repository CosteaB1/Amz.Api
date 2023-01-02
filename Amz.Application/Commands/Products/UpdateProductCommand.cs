using Amz.Application.Dto.Product;
using Amz.Domain.Models;
using MediatR;

namespace Amz.Application.Commands.Products
{
    public class UpdateProductCommand : IRequest<ProductDto>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
    }
}
