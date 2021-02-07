using FluentValidation;
using Lab.FluentValidator.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab.FluentValidator.WebApp.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.Name)
                .NotNull()
                .MaximumLength(8);
        }
    }
}
