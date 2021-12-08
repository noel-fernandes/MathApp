using System;
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

        public UInt64 Factorial(int factorialFor, bool squareFactorial = false, DoubleFactorialType doubleFactorialType = DoubleFactorialType.All)
        {

            UInt64 result = 1;
            if (factorialFor <= 1)
                return result;

            if (this._executionMethod is ExecutionMethod.Recursive)
            {
                result = Recursive.CalculateFactorial(factorialFor, doubleFactorialType, squareFactorial);
            }
            else
            {
                result = NonRecursive.CalculateFactorial(factorialFor, doubleFactorialType, squareFactorial);
            }

            return result;
        }
    }
}