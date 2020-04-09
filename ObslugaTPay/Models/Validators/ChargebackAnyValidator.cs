using FluentValidation;
using System;

namespace ObslugaTPay.Models.Validators
{
    public class ChargebackAnyValidator : AbstractValidator<ChargebackAny>
    {
        private float _transactionAmount;
        public ChargebackAnyValidator(float amount)
        {
            _transactionAmount = amount;

            RuleFor(v => v.ApiPassword).NotEmpty().WithMessage("{PropertyName} can not be empty.");
            RuleFor(v => v.Title).NotEmpty().WithMessage("{PropertyName} can not be empty.");
            RuleFor(v => v.Amount)
                .NotEmpty().WithMessage("{PropertyName} can not be empty.")
                .Must(BeSmallerThanTransactionValue).WithMessage("{PropertyName} must be smaller than transaction value");

        }
        private bool BeSmallerThanTransactionValue(float amount)
        {
            if (amount<= _transactionAmount)
            {
                return true;
            }

            return false;
        }
    }
}
