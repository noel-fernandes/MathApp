namespace Calculator.Library
{
    public interface IMathLib
    {
        int Factorial(int factorialFor, bool squareFactorial = false, DoubleFactorialType doubleFactorialType = DoubleFactorialType.All);
    }
}