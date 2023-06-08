using Amz.Domain.Errors;
using Amz.Domain.Primitives;
using Amz.Domain.Shared;

namespace Amz.Domain.ValueObjects.Product
{
    public sealed class Name : ValueObject
    {
        public const int MaxLength = 50;

        private Name(string value)
        {
            Value = value;
        }

        public string Value { get; }

        public static Result<Name> Create(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return Result.Failure<Name>(DomainErrors.Product.NameIsEmpty);
            }
            if (name.Length > MaxLength)
            {
                return Result.Failure<Name>(DomainErrors.Product.NameIsTooLong);
            }
            return new Name(name);
        }
        public override IEnumerable<object> GetAtomicValues()
        {
            yield return Value;
        }
    }
}
