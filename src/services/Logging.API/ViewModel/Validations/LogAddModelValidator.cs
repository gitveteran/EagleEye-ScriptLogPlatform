﻿using EESLP.Services.Logging.API.Enums;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EESLP.Services.Logging.API.ViewModel.Validations
{
    public class LogAddModelValidator : AbstractValidator<LogAddModel>
    {
        public LogAddModelValidator()
        {
            RuleFor(l => l.LogDateTime).NotEmpty();
            RuleFor(l => l.LogLevel).NotEmpty();
            RuleFor(l => l.LogLevel).IsInEnum();
            RuleFor(l => l.LogText).NotEmpty();
        }
    }
}
