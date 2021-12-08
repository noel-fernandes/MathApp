using Calculator.Library;
using System;
using Xunit;

namespace Calculator.UnitTests
{
    public class OddFactorialTests
    {
        [Theory]
        [InlineData(0, 1, false)]
        [InlineData(1, 1, false)]
        [InlineData(6, 15, false)]
        [InlineData(7, 105, false)]
        [InlineData(10, 945, false)]
        [InlineData(11, 10395, false)]
        public void Recursive_OddFactorialFor_ShouldReturnAFactorial(int factorialFor, UInt64 expected, bool squareFactorial)
        {
            //Arrange
            var systemUnderTest = new MathLib();

            //Act
            UInt64 result =systemUnderTest.Factorial(factorialFor, squareFactorial, DoubleFactorialType.Odd);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0, 1, false)]
        [InlineData(1, 1, false)]
        [InlineData(6, 15, false)]
        [InlineData(7, 105, false)]
        [InlineData(10, 945, false)]
        [InlineData(11, 10395, false)]
        public void NonRecursive_OddFactorialFor_ShouldReturnAFactorial(int factorialFor, UInt64 expected, bool squareFactorial)
        {
            //Arrange
            var systemUnderTest = new MathLib(ExecutionMethod.NonRecursive);

            //Act
            UInt64 result =systemUnderTest.Factorial(factorialFor, squareFactorial, DoubleFactorialType.Odd);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}