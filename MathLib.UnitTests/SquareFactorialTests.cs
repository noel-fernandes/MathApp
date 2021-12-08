using Calculator.Library;
using System;
using Xunit;

namespace Calculator.UnitTests
{
    public class SquareFactorialTests
    {

        [Theory]
        [InlineData(0, 1, true)]
        [InlineData(1, 1, true)]
        [InlineData(6, 518400, true)]
        [InlineData(7, 25401600, true)]
        public void Square_Recursive_FactorialFor_ShouldReturn_AFactorial(int factorialFor, UInt64 expected, bool squareFactorial)
        {
            //Arrange
            var systemUnderTest = new MathLib();

            //Act
            UInt64 result =systemUnderTest.Factorial(factorialFor, squareFactorial);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0, 1, true)]
        [InlineData(1, 1, true)]
        [InlineData(6, 518400, true)]
        [InlineData(7, 25401600, true)]
        public void Square_NonRecursive_FactorialFor_ShouldReturn_AFactorial(int factorialFor, UInt64 expected, bool squareFactorial)
        {
            // Arrange
            var systemUnderTest = new MathLib(ExecutionMethod.NonRecursive);

            //Act
            UInt64 result =systemUnderTest.Factorial(factorialFor, squareFactorial);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0, 1, true)]
        [InlineData(1, 1, true)]
        [InlineData(6, 225, true)]
        [InlineData(7, 11025, true)]
        public void Square_NonRecursive_FactorialFor_OddNumbers_ShouldReturn_AFactorial(int factorialFor, UInt64 expected, bool squareFactorial)
        {
            var systemUnderTest = new MathLib(ExecutionMethod.NonRecursive);

            //Act
            UInt64 result =systemUnderTest.Factorial(factorialFor, squareFactorial, DoubleFactorialType.Odd);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
