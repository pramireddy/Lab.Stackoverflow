using FluentValidation.TestHelper;
using Lab.FluentValidator.WebApp.Models;
using Lab.FluentValidator.WebApp.Validators;
using System;
using Xunit;

namespace Lab.UnitTests
{
    public class UnitTest1
    {
        private readonly OrderValidator _orderValidator;
        public UnitTest1()
        {
            _orderValidator = new OrderValidator();
        }

        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(null)]
        public void Show_Have_Error_When_Name_Is_Null(string name)
        {
            var model = new Order
            {
                Name = name
            };
            var result = _orderValidator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(order => order.Name);
        }

        [Fact]
        public void Show_Not_Have_Error_When_Name_Is_Null()
        {
            var model = new Order {Name  = "Test Order fwefefwef" };
            var result = _orderValidator.TestValidate(model);
            result.ShouldNotHaveValidationErrorFor(order => order.Name);
        }
    }
}
