using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using FluentResults;
using FluentValidation;
using MediatR;
using ULSolutions.InfraStructure.Features.Factorial.Extensions;

namespace ULSolutions.InfraStructure.Features.Factorial.Commands
{
    public record CalculateFactorialCommand(BigInteger InputInteger) : IRequest<Result<BigInteger>>;

    public class CalculateFactorialCommandHandler : IRequestHandler<CalculateFactorialCommand, Result<BigInteger>>
    {
        private readonly IValidator<CalculateFactorialCommand> _validator;

        public CalculateFactorialCommandHandler(IValidator<CalculateFactorialCommand> validator)
        {
            _validator = validator;
        }

        public async Task<Result<BigInteger>> Handle(CalculateFactorialCommand request, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);
            return !validationResult.IsValid 
                ? Result.Fail<BigInteger>(validationResult.ToString()) 
                : await request.InputInteger.CalculateFactorial();
        }
    }
}
