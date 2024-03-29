﻿using Amz.Domain.Primitives;

namespace Amz.Domain.Models
{
    public sealed class ProductStatus : Entity
    {
        public ProductStatus(Guid id, string name) : base(id)
        {
            Name = name;
        }
        public string Name { get; private set; }
    }
}
