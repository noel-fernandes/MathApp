using Calculator.Library;
using Xunit;

namespace Calculator.UnitTests
{
    public class OddFactorialTests
    {

        [Fact]
        public void NonRecursive_OddFactorialFor_6_ShouldReturn_15()
        {
            //Arrange
            int factorialFor = 6;
            int expected = 15;
            var systemUnderTest = new MathLib(ExecutionMethod.NonRecursive);

            //Act
            int result = systemUnderTest.Factorial(factorialFor, false, DoubleFactorialType.Odd);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void NonRecursive_OddFactorialFor_7_ShouldReturn_105()
        {
            //Arrange
            int factorialFor = 7;
            int expected = 105;
            var systemUnderTest = new MathLib(ExecutionMethod.NonRecursive);

            //Act
            int result = systemUnderTest.Factorial(factorialFor, false, DoubleFactorialType.Odd);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Recursive_OddFactorialFor_6_ShouldReturn_15()
        {
            //Arrange
            int factorialFor = 6;
            int expected = 15;
            var systemUnderTest = new MathLib(ExecutionMethod.Recursive);

            //Act
            int result = systemUnderTest.Factorial(factorialFor, false, DoubleFactorialType.Odd);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Recursive_OddFactorialFor_7_ShouldReturn_105()
        {
            //Arrange
            int factorialFor = 7;
            int expected = 105;
            var systemUnderTest = new MathLib(ExecutionMethod.Recursive);

            //Act
            int result = systemUnderTest.Factorial(factorialFor, false, DoubleFactorialType.Odd);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
