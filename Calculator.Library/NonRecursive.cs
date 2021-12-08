using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator.Library
{
    public static class NonRecursive
    {
        public static UInt64 CalculateFactorial(int factorialFor, DoubleFactorialType doubleFactorialType,
            bool squareFactorial)
        {
            IEnumerable<UInt64> numbersList = Enumerable.Range(1, factorialFor).Select(n => Convert.ToUInt64(n));

            switch (doubleFactorialType)
            {
                case DoubleFactorialType.Even:
                    numbersList = numbersList.Where(n => n % 2 == 0);
                    break;

                case DoubleFactorialType.Odd:
                    numbersList = numbersList.Where(n => n % 2 != 0);
                    break;
            }

            if (squareFactorial)
            {
                numbersList = numbersList.Select(n => n * n);
            }

            return CalculateFactorialUsingNumberLists(numbersList);
        }

        private static UInt64 CalculateFactorialUsingNumberLists(IEnumerable<UInt64> numbersList)
        {
            UInt64 factorial = numbersList.Aggregate((aggregateValue, currentElement) => aggregateValue * currentElement);
            return factorial;
        }
    }
}