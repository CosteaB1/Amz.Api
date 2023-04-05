using Amz.Domain.Errors;
using Amz.Domain.Primitives;
using Amz.Domain.Shared;
using Amz.Domain.ValueObjects;

namespace Amz.Domain.Models
{
    public sealed class Product : Entity
    {
        private Product(Guid id,
            Name name,
            string description,
            Guid categoryId,
            Guid subCategoryId,
            string otherDetails,
            Guid supplierId,
            int quantity) : base(id)
        {
            Name = name;
            Description = description;
            CategoryId = categoryId;
            SubCategoryId = subCategoryId;
            OtherDetails = otherDetails;
            SupplierId = supplierId;
            Quantity = quantity;
            CreatedOnUtc = DateTime.UtcNow;
        }

        public Name Name { get; private set; }
        public string Description { get; private set; }
        public Guid CategoryId { get; private set; }
        //public Category Category { get; private set; } // do I need it ? 
        public Guid SubCategoryId { get; private set; }
        //public SubCategory SubCategory { get; private set; } // do I need it ? 
        public string OtherDetails { get; private set; }
        public Guid SupplierId { get; private set; }
        //public Supplier Supplier { get; private set; } // do I need it ? 
        public int Quantity { get; private set; }
        //public ProductStatus Status { get; private set; }
        public DateTime CreatedOnUtc { get; private set; }

        // static factory method on entity


        public static Result<Product> Create(Name name, string description, Guid categoryId, Guid subCategoryId,
            string otherDetails, Guid supplierId, int quantity)
        {
            var product = new Product(Guid.NewGuid(), name, description, categoryId, subCategoryId, otherDetails,
                supplierId, quantity);

            if (quantity == 0)
            {
                return Result.Failure<Product>(DomainErrors.Product.QuantityIsZero);
            }

            return product;
        }

        public static Result Update(Name name, string description, Guid categoryId, Guid subCategoryId,
            string otherDetails, Guid supplierId, int quantity)
        {
            return Result.Success();
        }

        public static Guid Delete(Guid id)
        {
            return id;
        }
    }
}