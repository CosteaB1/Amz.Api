﻿using Amz.Domain.Errors;
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
        public Guid SubCategoryId { get; private set; }
        public Category Category { get; private set; } // do I need it ? 
        public SubCategory SubCategory { get; private set; } // do I need it ? 
        public string OtherDetails { get; private set; }
        public Guid SupplierId { get; private set; }
        public Supplier Supplier { get; private set; } // do I need it ? 
        public int Quantity { get; private set; }
        public ProductStatus Status { get; set; }
        public DateTime CreatedOnUtc { get; private set; }

        // static factory method on entity

        // A static method in C# is a method that keeps only one copy of the method at the Type level,
        // not the object level. That means, all instances of the class share the same copy of the method
        // and its data. The last updated value of the method is shared among all objects of that Type. 
        public static Result<Product> Create(Name name, string description, Guid categoryId, Guid subCategoryId, string otherDetails, Guid supplierId, int quantity)
        {
            var product = new Product(Guid.NewGuid(), name, description, categoryId, subCategoryId, otherDetails, supplierId, quantity);
            // need to add validation 
            if (quantity == 0)
            {
                return Result.Failure<Product>(DomainErrors.Product.QuantityIsZero);
            }
            // can add more logic
            return product;
        }

        public static Guid Delete(Guid id)
        {

            return id;
        }

    }
}
