using Core.Entities.Concrete;
using Core.Enums;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class RegisterUserValidation:AbstractValidator<UserForRegisterDto>
    {
        public RegisterUserValidation(ValidationStates state = ValidationStates.Add)
        {
            RuleFor(x => x.Email).EmailAddress().NotEmpty();
            RuleFor(x => x.LastName).NotEmpty().MinimumLength(3);
            RuleFor(X => X.LastName).NotEmpty().MinimumLength(3);
            RuleFor(x => x.Password).NotEmpty().MinimumLength(3).MaximumLength(15).Must(HaveWhiteSpace);
        }

        private bool HaveWhiteSpace(string arg)
        {
            return !arg.Contains(" ");
        }
    }
}
