using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator.Library
{

    public enum ExecutionMethod
    {
        NonRecursive = 1,
        Recursive = 0
    }

    public enum DoubleFactorialType
    {
        All = 0,
        Even = 1,
        Odd = 2
    }

    public class MathLib
    {
        private readonly ExecutionMethod _executionMethod;

        /// <summary>
        /// Parameterless constructor to instantiate the MathLib class. The default execution method is set to ExecutionMethod.Recursive.
        /// </summary>
        public MathLib()
        {
            this._executionMethod = ExecutionMethod.Recursive;
        }

        /// <summary>
        /// Parametered constructor to instantiate the MathLib class
        /// </summary>
        /// <param name="executionMethod">Default is set to ExecutionMethod.Recursive</param>
        public MathLib(ExecutionMethod executionMethod)
        {
            this._executionMethod = executionMethod;
        }

        /// <summary>
        /// Calculates the factorial for a given number. Mathematically represented as 5! = 5*4*3*2*1
        /// </summary>
        /// <param name="factorialFor">The number for which the factorial is calculated</param>
        /// <param name="squared">Setting this to 'true' will calculate as follows: 3! = (3*3)*(2*2)*(1*1). Default is set to false.</param>
        /// <param name="doubleFactorialType">Set to 'Even' or 'Odd' to calculate the factorial for even or odd numbers respectively. Default is 'All'</param>
        /// <returns>An integer containing the factorial for a given number.</returns>
        public int Factorial(int factorialFor, bool squared = false, DoubleFactorialType doubleFactorialType = DoubleFactorialType.All)
        {
            int result = 0;

            // Anything below 0 will be defaulted to 1.
            // In case of factorial for 1, anything multiplied by 0 will be 0. Hence the check for factorial of 1
            if (factorialFor <= 1)
            {
                result = 1;
            }
            else
            {
                if (this._executionMethod == ExecutionMethod.Recursive)
                {
                    result = CalculateFactorialRecursively(factorialFor, squared, doubleFactorialType);
                }
                else
                {
                    result = CalculateFactorialNonRecursively(factorialFor, squared, doubleFactorialType);
                }

                //if (squared)
                //{
                //    result *= result;
                //}
            }

            return result;
        }

        /// <summary>
        /// A method that calculates the factorial using list functions
        /// </summary>
        /// <param name="factorialFor">Integer for which the factorial needs to be calculated for.</param>
        /// <returns>The factorial for the supplied number.</returns>
        private int CalculateFactorialNonRecursively(int factorialFor, bool squared, DoubleFactorialType doubleFactorialType = DoubleFactorialType.All)
        {
            IEnumerable<int> numbersList = Enumerable.Range(1, factorialFor);

            if (doubleFactorialType == DoubleFactorialType.Even)
            {
                numbersList = numbersList.Where(n => n % 2 == 0);
            }
            else if (doubleFactorialType == DoubleFactorialType.Odd)
            {
                numbersList = numbersList.Where(n => n % 2 != 0);
            }

            if (squared) 
            {
                numbersList = numbersList.Select(n => n * n);
            }

            int factorial = numbersList.Aggregate((aggregateValue, currentElement) => aggregateValue * currentElement);
            return factorial;
        }

        /// <summary>
        /// A method that calculates the factorial using recursive functions
        /// </summary>
        /// <param name="factorialFor">Integer for which the factorial needs to be calculated for.</param>
        /// <returns>The factorial for the supplied number.</returns>
        private int CalculateFactorialRecursively(int factorialFor, bool squared = false, DoubleFactorialType doubleFactorialType = DoubleFactorialType.All)
        {
            // Check to break recursivness
            if (factorialFor <= 1)
            {
                return factorialFor;
            }

            if (squared && doubleFactorialType is DoubleFactorialType.Odd)
            {
                if (factorialFor % 2 == 0)
                {
                    factorialFor -= 1;
                }

                return (factorialFor * factorialFor) * CalculateFactorialRecursively(factorialFor - 2, squared, doubleFactorialType);
            }
            else if (doubleFactorialType is DoubleFactorialType.Odd)
            {
                if (factorialFor % 2 == 0)
                {
                    factorialFor -= 1;
                }

                return factorialFor * CalculateFactorialRecursively(factorialFor - 2, squared, doubleFactorialType);
            }
            else if (squared)
            {
                return (factorialFor * factorialFor) * CalculateFactorialRecursively(factorialFor - 1, squared, doubleFactorialType);
            }

            return factorialFor * CalculateFactorialRecursively(factorialFor - 1, squared, doubleFactorialType);
        }
    }
}
