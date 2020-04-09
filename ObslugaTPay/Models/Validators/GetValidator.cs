﻿using FluentValidation;
using System.Data;

namespace ObslugaTPay.Models.Validators
{
    public class GetValidator : AbstractValidator<Get>
    {
        public GetValidator()
        {
            RuleFor(v => v.Title).NotEmpty().WithMessage("{PropertyName} can not be empty.");
            RuleFor(v => v.ApiPassword).NotEmpty().WithMessage("{PropertyName} can not be empty.");
        }
    }
}
