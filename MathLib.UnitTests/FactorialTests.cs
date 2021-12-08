using Calculator.Library;
using System;
using Xunit;

namespace Calculator.UnitTests
{
    public class FactorialTests
    {

        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(3, 6)]
        [InlineData(6, 720)]
        [InlineData(10, 3628800)]
        [InlineData(50, 15188249005818642432)]
        public void RecursiveFactorial_ShouldReturnAFactorial(int factorialFor, UInt64 expected)
        {
            //Arrange
            var systemUnderTest = new MathLib();

            //Act
            UInt64 result = systemUnderTest.Factorial(factorialFor);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(3, 6)]
        [InlineData(6, 720)]
        [InlineData(10, 3628800)]
        [InlineData(50, 15188249005818642432)]
        public void NonRecursiveFactorial_ShouldReturnAFactorial(int factorialFor, UInt64 expected)
        {
            //Arrange
            var systemUnderTest = new MathLib(ExecutionMethod.NonRecursive);

            //Act
            UInt64 result =systemUnderTest.Factorial(factorialFor);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}