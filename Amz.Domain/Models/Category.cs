using Amz.Domain.Primitives;

namespace Amz.Domain.Models
{
    public sealed class Category : Entity
    {
        private readonly List<SubCategory> _subCategories = new();
        public Category(Guid id, string name, int age) : base(id)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
        public IReadOnlyCollection<SubCategory> SubCategories => _subCategories;
    }
}