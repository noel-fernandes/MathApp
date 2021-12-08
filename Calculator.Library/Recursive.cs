using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Library
{
    public static class Recursive
    {
        public static UInt64 CalculateFactorial(int factorialFor, DoubleFactorialType doubleFactorialType = DoubleFactorialType.All,
            bool squareFactorial = false)
        {
            UInt64 result = 0;
            int jumpFactor = 1;

            switch (doubleFactorialType)
            {
                case DoubleFactorialType.Even:
                    factorialFor = (factorialFor % 2 != 0) ? --factorialFor : factorialFor;
                    jumpFactor = 2;
                    break;
                case DoubleFactorialType.Odd:
                    factorialFor = (factorialFor % 2 == 0) ? --factorialFor : factorialFor;
                    jumpFactor = 2;
                    break;
            }

            var func = RecursiveFactorialFunction(squareFactorial);

            result = func(factorialFor, jumpFactor);
            return result;

        }

        private static Func<int, int, UInt64> RecursiveFactorialFunction(bool squareFactorial)
        {
            Func<int, int, UInt64> factorialFunction = null;

            if (squareFactorial)
                factorialFunction = (factorialFor, jumpFactor) => factorialFor <= 1 ? 1
                : Convert.ToUInt64(factorialFor * factorialFor) * factorialFunction(factorialFor - jumpFactor, jumpFactor);
            else
                factorialFunction = (factorialFor, jumpFactor) => factorialFor <= 1 ? 1
                : Convert.ToUInt64(factorialFor) * factorialFunction(factorialFor - jumpFactor, jumpFactor);

            return factorialFunction;
        }
    }
}
