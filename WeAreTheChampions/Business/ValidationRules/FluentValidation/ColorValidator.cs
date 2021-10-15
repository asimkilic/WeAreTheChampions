using Core.Enums;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ColorValidator : AbstractValidator<Color>
    {
        public ColorValidator(ValidationStates state)
        {
            // https://docs.fluentvalidation.net/en/latest/built-in-validators.html
            if (state == ValidationStates.Delete || state == ValidationStates.Update)
            {
                RuleFor(x => x.Id).GreaterThan(0);
            }
            RuleFor(x => x.ColorName).NotEmpty();
            RuleFor(x => x.ColorName).MinimumLength(2);
        }

    }
}
