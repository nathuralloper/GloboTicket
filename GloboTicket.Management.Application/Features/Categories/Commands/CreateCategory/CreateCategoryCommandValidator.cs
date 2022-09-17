﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace GloboTicket.Management.Application.Features.Categories.Commands.CreateCategory
{
    public class CreateCategoryCommandValidator : AbstractValidator<CreateCategoryCommand>
    {
        public CreateCategoryCommandValidator()
        {
            RuleFor(p => p.Name)
               .NotEmpty().WithMessage("{PropertyName} is required")
               .NotNull()
               .MaximumLength(50).WithMessage("{PropertyName} is required");
        }
    }
}
