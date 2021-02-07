using FluentValidation;
using Lab.FluentValidator.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab.FluentValidator.WebApp.Validators
{
    public class OrderValidator : AbstractValidator<Order>
    {
        public OrderValidator()
        {
            RuleFor(model => model.Name)
                .NotNull()
                .NotEmpty()
                .MaximumLength(10);
            RuleFor(model => model.CustomerEmail).NotEmpty();
            RuleFor(model => model.OrderStatus).IsInEnum();

            RuleFor(model => model.Products).Must(ContaintProducts).WithMessage("No Products found");
            RuleForEach(model => model.Products)
                .SetValidator(new ProductValidator());
        }

        private bool ContaintProducts(IEnumerable<Product> products)
        {
            return products.Any();
        }
    }
}