using Amz.Domain.Shared;

namespace Amz.Domain.Errors
{
    public static class DomainErrors
    {
        public static class Product
        {
            public static readonly Error QuantityIsZero = new Error(
                    "Product.Create",
                    "Quantity can't be zero");
        }
    }
}
