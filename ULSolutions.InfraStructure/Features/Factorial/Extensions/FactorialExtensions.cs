using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ULSolutions.InfraStructure.Features.Factorial.Extensions
{
    public static class FactorialExtensions
    {
        public static async Task<BigInteger> CalculateFactorial(this BigInteger n)
        {
            if (n == 0) return 1;

            return await Task.Run(() => Calculate(n));
        }

        private static BigInteger Calculate(BigInteger n)
        {
            BigInteger result = 1;
            for (BigInteger i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
