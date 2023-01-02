using Amz.Application.Dto.Product;
using MediatR;

namespace Amz.Application.Commands.Products
{
    public class CreateProductCommand : IRequest<ProductDto>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
    }
}
