using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentResults;
using MediatR;

namespace ULSolutions.InfraStructure.Features.FizzBuzz.Commands
{
    public record CalculateFizzBuzzCommand(int destination = 100) : IRequest<Result<List<string>>>;

    public class CalculateFizzBuzzCommandHandler : IRequestHandler<CalculateFizzBuzzCommand, Result<List<string>>>
    {
        public async Task<Result<List<string>>> Handle(CalculateFizzBuzzCommand request, CancellationToken cancellationToken)
        {
            var results = new List<string>();
            for (var i = 1; i <= request.destination; i++)
            {
                if (i % 15 == 0)
                {
                   results.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    results.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    results.Add("Buzz");
                }
                else
                {
                    results.Add(i.ToString());
                }
            }

            return results;
        }
    }
}
