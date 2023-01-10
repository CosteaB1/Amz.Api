using Amz.Application.Dto.Product;
using Amz.Domain.Models;
using MediatR;

namespace Amz.Application.Commands.Products
{
    public class CreateProductCommand : IRequest<ProductDto>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid CategoryId { get; set; }
        public Guid SubCategoryId { get; set; }
        public string OtherDetails { get; set; }
        public Guid SupplierId { get; set; }
        public int Quantity { get; set; }
    }
}
