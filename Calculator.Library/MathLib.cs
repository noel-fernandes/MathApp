using System.Collections.Generic;
using System.Linq;

namespace Calculator.Library
{
    public class MathLib : IMathLib
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

        public int Factorial(int factorialFor, bool squareFactorial = false, DoubleFactorialType doubleFactorialType = DoubleFactorialType.All)
        {
            if (factorialFor <= 1)
                return 1;

            int result = 0;

            if (this._executionMethod is ExecutionMethod.Recursive)
            {
                result = CalculateFactorialRecursively(factorialFor, squareFactorial, doubleFactorialType);
            }
            else
            {
                result = CalculateFactorialNonRecursively(factorialFor, squareFactorial, doubleFactorialType);
            }

            return result;
        }

        private int CalculateFactorialRecursively(int factorialFor, bool squareFactorial, DoubleFactorialType doubleFactorialType)
        {
            if (doubleFactorialType is DoubleFactorialType.Odd)
            {
                factorialFor = factorialFor % 2 == 0 ? factorialFor - 1 : factorialFor;
                return CalculateDoubleFactorialUsingRecursive(factorialFor);
            }
            else if (doubleFactorialType is DoubleFactorialType.Even)
            {
                factorialFor = factorialFor % 2 != 0 ? factorialFor - 1 : factorialFor;
                return CalculateDoubleFactorialUsingRecursive(factorialFor);
            }
            else if (squareFactorial)
            {
                return CalculatesquareFactorialUsingRecursive(factorialFor);
            }
            else
            {
                return CalculateFactorialUsingRecursive(factorialFor);
            }
        }

        private int CalculateFactorialUsingRecursive(int factorialFor)
        {
            if (factorialFor <= 1)
            {
                return factorialFor;
            }

            return factorialFor * CalculateFactorialUsingRecursive(factorialFor - 1);
        }

        private int CalculateDoubleFactorialUsingRecursive(int factorialFor)
        {
            if (factorialFor <= 2)
            {
                return factorialFor;
            }

            return factorialFor * CalculateDoubleFactorialUsingRecursive(factorialFor - 2);
        }

        private int CalculatesquareFactorialUsingRecursive(int factorialFor)
        {
            if (factorialFor <= 1)
            {
                return factorialFor;
            }

            return (factorialFor * factorialFor) * CalculatesquareFactorialUsingRecursive(factorialFor - 1);
        }

        private int CalculateFactorialNonRecursively(int factorialFor, bool squareFactorial, DoubleFactorialType doubleFactorialType)
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

            if (squareFactorial)
            {
                numbersList = numbersList.Select(n => n * n);
            }

            return CalculateFactorialUsingNumberLists(numbersList);
        }

        private int CalculateFactorialUsingNumberLists(IEnumerable<int> numbersList)
        {
            int factorial = numbersList.Aggregate((aggregateValue, currentElement) => aggregateValue * currentElement);
            return factorial;
        }
    }
}