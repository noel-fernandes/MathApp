using System;

namespace Calculator.Library
{
    public interface IMathLib
    {
        UInt64 Factorial(int factorialFor, bool squareFactorial = false, DoubleFactorialType doubleFactorialType = DoubleFactorialType.All);
    }
}