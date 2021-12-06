using Calculator.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculator.UnitTests
{
    public class EvenFactorialTests
    {
        [Theory]
        [InlineData(0, 1, false)]
        [InlineData(1, 1, false)]
        [InlineData(6, 48, false)]
        [InlineData(7, 48, false)]
        [InlineData(10, 3840, false)]
        [InlineData(11, 3840, false)]
        public void Recursive_EvenFactorialFor_ShouldReturnAFactorial(int factorialFor, int expected, bool squareFactorial)
        {
            //Arrange
            var systemUnderTest = new MathLib();

            //Act
            int result = systemUnderTest.Factorial(factorialFor, squareFactorial, DoubleFactorialType.Even);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0, 1, false)]
        [InlineData(1, 1, false)]
        [InlineData(6, 48, false)]
        [InlineData(7, 48, false)]
        [InlineData(10, 3840, false)]
        [InlineData(11, 3840, false)]
        public void NonRecursive_EvenFactorialFor_ShouldReturnAFactorial(int factorialFor, int expected, bool squareFactorial)
        {
            //Arrange
            var systemUnderTest = new MathLib(ExecutionMethod.NonRecursive);

            //Act
            int result = systemUnderTest.Factorial(factorialFor, squareFactorial, DoubleFactorialType.Even);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
