namespace Amz.Domain.Models
{
    public class Product
    {
        public Guid Id { get; set; } // to check how to use guid
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
