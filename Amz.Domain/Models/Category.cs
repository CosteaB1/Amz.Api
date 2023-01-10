using Amz.Domain.Primitives;

namespace Amz.Domain.Models
{
    public sealed class Category : Entity
    {
        public Category(Guid id) : base(id)
        {
        }

        public string Name { get; set; }
        public ICollection<SubCategory> SubCategories { get; set; }
    }
}
