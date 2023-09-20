using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ULSolutions.InfraStructure.Features.FizzBuzz.Commands;

namespace ULSolutions.Test
{
    [TestClass]
    public class CalculateFizzBuzzCommandShouldBeAbleTo: BaseTest
    {
        [TestMethod]
        public async Task CalculateFizzBuzzToOneHundred()
        {
            //Act
            var result = await Mediator.Send(new CalculateFizzBuzzCommand());

            //Assert
            Assert.IsTrue(result.IsSuccess);
            Assert.AreEqual("FizzBuzz", result.Value[44]);
            Assert.AreEqual("Fizz", result.Value[50]);
            Assert.AreEqual("Buzz", result.Value[49]);
        }
    }
}
