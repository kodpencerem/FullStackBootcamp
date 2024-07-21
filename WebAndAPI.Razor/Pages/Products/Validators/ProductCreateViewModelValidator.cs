﻿using FluentValidation;
using WebAndAPI.Razor.Pages.Products.ViewModels;

namespace WebAndAPI.Razor.Pages.Products.Validators
{
    public class ProductCreateViewModelValidator : AbstractValidator<ProductCreateOrUpdateViewModel>
    {
        public ProductCreateViewModelValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("isim alanı gereklidir");
            RuleFor(x => x.Price).GreaterThan(0).WithMessage("fiyat alanı 0'dan büyük olmalıdır");
            RuleFor(x => x.Stock).GreaterThan(0).WithMessage("stok alanı 0'dan büyük olmalıdır");
        }
    }
}