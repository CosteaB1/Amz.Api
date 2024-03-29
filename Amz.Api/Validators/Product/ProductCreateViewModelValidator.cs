﻿using Amz.Api.ViewModels.Product;
using FluentValidation;

namespace Amz.Api.Validators.Product
{
    public class CreateProductViewModelValidator : AbstractValidator<CreateProductViewModel>
    {
        public CreateProductViewModelValidator()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty().Length(1, 255);
            RuleFor(x => x.CategoryId).NotNull().NotEmpty().GreaterThan(0);
            RuleFor(x => x.Description).NotNull().NotEmpty().Length(1, 150);
        }
    }
}
