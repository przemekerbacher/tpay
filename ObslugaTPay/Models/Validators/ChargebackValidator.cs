using FluentValidation;
using System;

namespace ObslugaTPay.Models.Validators
{
    public class ChargebackValidator : AbstractValidator<Chargeback>
    {
        public ChargebackValidator()
        {
            RuleFor(v => v.ApiPassword).NotEmpty().WithMessage("{PropertyName} can not be empty.");
            RuleFor(v => v.Title).NotEmpty().WithMessage("{PropertyName} can not be empty.");
        }

    }
}
