using Amz.Domain.Primitives;

namespace Amz.Domain.Models
{
    public sealed class Supplier : Entity
    {
        private readonly List<Product> _products = new();

        public Supplier(Guid id, string name, string contact, string email, string phoneNumber, string otherDetails) : base(id)
        {
            Name = name;
            Contact = contact;
            Email = email;
            PhoneNumber = phoneNumber;
            OtherDetails = otherDetails;
        }

        public string Name { get; private set; }
        public string Contact { get; private set; }
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }
        public string OtherDetails { get; private set; }
        public IReadOnlyCollection<Product> Products => _products;
    }
}