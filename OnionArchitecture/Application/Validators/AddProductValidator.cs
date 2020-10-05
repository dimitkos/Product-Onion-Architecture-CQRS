using Application.Commands;
using FluentValidation;
using System;
using System.Linq;

namespace Application.Validators
{
    public class AddProductValidator : AbstractValidator<AddProduct>
    {
        public AddProductValidator()
        {
            RuleFor(c => c.Name)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage("Please fill the Name")
                .Length(2, 25);
            RuleFor(c => c.Barcode)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage("Please fill the Barcode")
                .Length(2, 25);
            RuleFor(c => c.Description)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage("Please fill the Description")
                .Length(2, 25)
                .Must(IsValidName)
                .WithMessage("{PropertyName} should be all letters.");
            RuleFor(c => c.Rate)
                .NotEmpty()
                .WithMessage("Please fill the Rate");
        }

        private bool IsValidName(string description)
        {
            return description.All(Char.IsLetter);
        }
    }
}
