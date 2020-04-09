using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObslugaTPay.Models.Validators
{
    public class CreateValidator: AbstractValidator<Create>
    {
        public CreateValidator()
        {
            RuleFor(v => v.Id).NotEmpty().WithMessage("'{PropertyName}' can not be empty.");
        }
    }
}
