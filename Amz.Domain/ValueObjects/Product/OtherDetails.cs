using Amz.Domain.Errors;
using Amz.Domain.Primitives;
using Amz.Domain.Shared;

namespace Amz.Domain.ValueObjects.Product;

public class OtherDetails : ValueObject
{
    private const int MaxLength = 100;

    private OtherDetails(string value)
    {
        Value = value;
    }

    private string Value { get; }

    public static Result<OtherDetails> Create(string name)
    {
        return name.Length > MaxLength
            ? Result.Failure<OtherDetails>(DomainErrors.Product.OtherDetailsIsTooLong)
            : new OtherDetails(name);
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
    }
}