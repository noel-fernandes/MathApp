using Calculator.Library;
using Xunit;

namespace Calculator.UnitTests
{
    public class FactorialTests
    {
        #region Recursive function Tests

        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(3, 6)]
        [InlineData(6, 720)]
        [InlineData(10, 3628800)]
        public void RecursiveFactorial_ShouldReturnAFactorial(int factorialFor, int expected)
        {
            //Arrange
            var systemUnderTest = new MathLib();

            //Act
            int result = systemUnderTest.Factorial(factorialFor);

            //Assert
            Assert.Equal(expected, result);
        }

        #endregion Recursive function Tests

        #region Non-recursive function tests

        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(3, 6)]
        [InlineData(6, 720)]
        [InlineData(10, 3628800)]
        public void NonRecursiveFactorial_ShouldReturnAFactorial(int factorialFor, int expected)
        {
            //Arrange
            var systemUnderTest = new MathLib(ExecutionMethod.NonRecursive);

            //Act
            int result = systemUnderTest.Factorial(factorialFor);

            //Assert
            Assert.Equal(expected, result);
        }

        #endregion Non-recursive function tests
    }
}