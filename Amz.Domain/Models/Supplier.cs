using Amz.Domain.Primitives;

namespace Amz.Domain.Models
{
    public sealed class Supplier : Entity
    {
        public Supplier(Guid id) : base(id)
        {
        }

        public string Name { get; private set; }
        public string Contact { get; private set; }
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }
        public string OtherDetails { get; private set; }
        public ICollection<Product> Products { get; set; }

    }
}
