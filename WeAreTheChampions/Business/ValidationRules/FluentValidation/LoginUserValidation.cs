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
   public class LoginUserValidation:AbstractValidator<UserForLoginDto>
    {
        public LoginUserValidation(ValidationStates state = ValidationStates.Add)
        {
            RuleFor(x => x.Email).EmailAddress().NotEmpty();
            RuleFor(x => x.Password).NotEmpty().Must(HaveWhiteSpace);
        }

        private bool HaveWhiteSpace(string arg)
        {
            return !arg.Contains(" ");
        }
    }
}
