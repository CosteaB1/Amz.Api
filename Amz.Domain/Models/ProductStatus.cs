using Amz.Domain.Primitives;

namespace Amz.Domain.Models
{
    public sealed class ProductStatus : Entity
    {
        public ProductStatus(Guid id) : base(id)
        {

        }
        public string Name { get; set; }
    }
}
