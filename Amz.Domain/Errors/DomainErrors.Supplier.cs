using Amz.Domain.Shared;

namespace Amz.Domain.Errors
{
    public static partial class DomainErrors
    {
        public static class Suplier
        {
            public static readonly Error TestError = new Error(
                    "TestError",
                    "TestError");
        }
    }
}
