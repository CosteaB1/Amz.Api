using Amz.Domain.Primitives;

namespace Amz.Domain.Models
{
    public sealed class SubCategory : Entity
    {
        private readonly List<Product> _products = new();

        public SubCategory(Guid id, string name, Guid categoryId) : base(id)
        {
            Name = name;
            CategoryId = categoryId;
        }

        public string Name { get; private set; }
        public Guid CategoryId { get; private set; }
        public IReadOnlyCollection<Product> Products => _products;
    }
}