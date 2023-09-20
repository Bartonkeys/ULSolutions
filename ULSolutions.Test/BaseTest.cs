using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ULSolutions.InfraStructure.Features.Factorial.Commands;
using ULSolutions.InfraStructure.Features.Factorial.Validation;

namespace ULSolutions.Test
{
    [TestClass]
    public class BaseTest
    {
        protected IMediator Mediator;
        private readonly ServiceCollection _services = new();

        [TestInitialize]
        public async Task TestInitialize()
        {
            _services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<CalculateFactorialCommand>());
            _services.AddValidatorsFromAssemblyContaining<CalculateFactorialCommandValidator>(ServiceLifetime.Transient);

            var servicesProvider = _services.BuildServiceProvider();

            Mediator = servicesProvider.GetRequiredService<IMediator>();
        }
    }
}
