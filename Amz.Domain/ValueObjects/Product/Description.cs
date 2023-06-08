using Amz.Domain.Errors;
using Amz.Domain.Primitives;
using Amz.Domain.Shared;

namespace Amz.Domain.ValueObjects.Product;

public class Description : ValueObject
{
    private const int MaxLength = 100;

    private Description(string value)
    {
        Value = value;
    }

    public string Value { get; }

    public static Result<Description> Create(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return Result.Failure<Description>(DomainErrors.Product.DescriptionIsEmpty);
        }

        if (name.Length > MaxLength)
        {
            return Result.Failure<Description>(DomainErrors.Product.DescriptionIsTooLong);
        }

        return new Description(name);
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
    }
}