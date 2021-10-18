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
    public class MatchValidator : AbstractValidator<Match>
    {
        public MatchValidator(ValidationStates state = ValidationStates.Add)
        {
            RuleFor(x => x.HomeTeamId).NotEqual(x => x.AwayTeamId);

            if (state == ValidationStates.Update)
            {
                RuleFor(x => x.Id).NotEmpty().NotNull().GreaterThan(0);
                RuleFor(x => x.Score1).NotNull().When(x => x.MatchTime < DateTime.Now).WithMessage("Maç oynanmış, skor bilgisi girilmesi gereklidir.");
                RuleFor(x => x.Score2).NotNull().When(x => x.MatchTime < DateTime.Now).WithMessage("Maç oynanmış, skor bilgisi girlmesi gereklidir.");
                RuleFor(x => x.MatchTime).GreaterThan(DateTime.Now).When(x => x.Score1 == null && x.Score2 == null);
                RuleFor(x => x.MatchTime).LessThan(DateTime.Now).When(x => x.ResultId != null); // If match played, cant change match date to future.

            }
            else if (state == ValidationStates.Add)
            {
                RuleFor(x => x.MatchTime).GreaterThan(DateTime.Now);
                RuleFor(x => x.Score1).Null();
                RuleFor(x => x.Score2).Null();
                RuleFor(x => x.ResultId).Null();
            }

        }
    }
}
