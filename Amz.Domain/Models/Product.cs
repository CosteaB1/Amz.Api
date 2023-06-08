using Amz.Domain.Errors;
using Amz.Domain.Primitives;
using Amz.Domain.Shared;
using Amz.Domain.ValueObjects.Product;

namespace Amz.Domain.Models
{
    public sealed class Product : Entity
    {
        private Product(Guid id,
            Name name,
            Description description,
            Guid categoryId,
            Guid subCategoryId,
            OtherDetails otherDetails,
            Guid supplierId,
            int quantity,
            Money price) : base(id)
        {
            Name = name;
            Description = description;
            CategoryId = categoryId;
            SubCategoryId = subCategoryId;
            OtherDetails = otherDetails;
            SupplierId = supplierId;
            Quantity = quantity;
            Price = price;
            CreatedOnUtc = DateTime.UtcNow;
        }

        public Name Name { get; private set; }
        public Description Description { get; private set; }

        public Guid CategoryId { get; private set; }

        //public Category Category { get; private set; } // do I need it ? 
        public Guid SubCategoryId { get; private set; }

        //public SubCategory SubCategory { get; private set; } // do I need it ? 
        public OtherDetails OtherDetails { get; private set; }

        public Guid SupplierId { get; private set; }

        //public Supplier Supplier { get; private set; } // do I need it ? 
        public int Quantity { get; private set; }

        //public ProductStatus Status { get; private set; }
        public DateTime CreatedOnUtc { get; private set; }

        public Money Price { get; private set; }
        // static factory method on entity


        public static Result<Product> Create(Name name, Description description, Guid categoryId, Guid subCategoryId,
            OtherDetails otherDetails, Guid supplierId, int quantity, Money price)
        {
            var product = new Product(Guid.NewGuid(), name, description, categoryId, subCategoryId, otherDetails,
                supplierId, quantity, price);

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