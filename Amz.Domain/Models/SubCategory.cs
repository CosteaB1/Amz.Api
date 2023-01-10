using Amz.Domain.Primitives;

namespace Amz.Domain.Models
{
    public sealed class SubCategory : Entity
    {
        public SubCategory(Guid id) : base(id)
        {

        }
        public string Name { get; private set; }
        public Guid CategoryId { get; private set; }
        public ICollection<Product> Products { get; set; }
    }
}
