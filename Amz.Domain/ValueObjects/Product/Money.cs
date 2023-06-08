using Amz.Domain.Errors;
using Amz.Domain.Primitives;
using Amz.Domain.Shared;

namespace Amz.Domain.ValueObjects.Product;

public sealed class Money : ValueObject
{
    public decimal Value { get; }

    private Money(decimal value)
    {
        Value = value;
    }

    public static Result<Money> Create(decimal price)
    {
        return price <= 0 ? Result.Failure<Money>(DomainErrors.Product.PriceIsZeroOrLess) : new Money(price);
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
    }
}