using Amz.Api.ViewModels.Product;
using FluentValidation;

namespace Amz.Api.Validators.Product
{
    public class ProductCreateViewModelValidator : AbstractValidator<ProductCreateViewModel>
    {
        public ProductCreateViewModelValidator()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty().Length(5, 10);
        }
    }
}
