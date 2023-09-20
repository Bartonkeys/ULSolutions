using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using ULSolutions.InfraStructure.Features.Factorial.Commands;

namespace ULSolutions.InfraStructure.Features.Factorial.Validation
{
    public class CalculateFactorialCommandValidator: AbstractValidator<CalculateFactorialCommand>
    {
        public CalculateFactorialCommandValidator()
        {
            RuleFor(x => x.InputInteger).GreaterThan(0);
            RuleFor(x => x.InputInteger).LessThanOrEqualTo(10000);
        }
    }
}
