using Calculator.Library;
using Xunit;

namespace Calculator.UnitTests
{
    public class SquaredFactorialTests
    {

        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(6, 518400)]
        [InlineData(7, 25401600)]
        public void Squared_Recursive_FactorialFor_ShouldReturn_AFactorial(int factorialFor, int expected)
        {
            var systemUnderTest = new MathLib();

            //Act
            int result = systemUnderTest.Factorial(factorialFor, true);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(6, 225)]
        [InlineData(7, 11025)]
        public void Squared_Recursive_FactorialFor_OddNumbers_ShouldReturn_AFactorial(int factorialFor, int expected)
        {
            var systemUnderTest = new MathLib();

            //Act
            int result = systemUnderTest.Factorial(factorialFor, true, DoubleFactorialType.Odd);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(6, 518400)]
        [InlineData(7, 25401600)]
        public void Squared_NonRecursive_FactorialFor_ShouldReturn_AFactorial(int factorialFor, int expected)
        {
            var systemUnderTest = new MathLib(ExecutionMethod.NonRecursive);

            //Act
            int result = systemUnderTest.Factorial(factorialFor, true);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(6, 225)]
        [InlineData(7, 11025)]
        public void Squared_NonRecursive_FactorialFor_OddNumbers_ShouldReturn_AFactorial(int factorialFor, int expected)
        {
            var systemUnderTest = new MathLib(ExecutionMethod.NonRecursive);

            //Act
            int result = systemUnderTest.Factorial(factorialFor, true, DoubleFactorialType.Odd);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
