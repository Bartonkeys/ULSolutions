using System.Numerics;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ULSolutions.InfraStructure.Features.Factorial.Commands;
using ULSolutions.InfraStructure.Features.FizzBuzz.Commands;

namespace ULSolutions.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChallengeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ChallengeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("Factorial/{inputInteger:int}")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetFactorial(int inputInteger)
        {
            var results = await _mediator.Send(new CalculateFactorialCommand(new BigInteger(inputInteger)));

            if (results.IsFailed)
                return BadRequest(results.Errors.FirstOrDefault()?.Message);

            return Ok(results.Value.ToString());
        }

        [HttpGet]
        [Route("FizzBuzz")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetFizzBuzz()
        {
            var results = await _mediator.Send(new CalculateFizzBuzzCommand());

            if (results.IsFailed)
                return BadRequest(results.Errors.FirstOrDefault()?.Message);

            return Ok(string.Join('\n', results.Value));
        }

    }
}
