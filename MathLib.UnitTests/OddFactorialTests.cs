using Calculator.Library;
using Xunit;

namespace Calculator.UnitTests
{
    public class OddFactorialTests
    {

        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(6, 15)]
        [InlineData(7, 105)]
        [InlineData(10, 945)]
        [InlineData(11, 10395)]
        public void Recursive_OddFactorialFor_ShouldReturnAFactorial(int factorialFor, int expected)
        {
            //Arrange
            var systemUnderTest = new MathLib();

            //Act
            int result = systemUnderTest.Factorial(factorialFor, false, DoubleFactorialType.Odd);

            //Assert
            Assert.Equal(expected, result);
        }


        //[Fact]
        //public void Recursive_OddFactorialFor_6_ShouldReturn_15()
        //{
        //    //Arrange
        //    int factorialFor = 6;
        //    int expected = 15;
        //    var systemUnderTest = new MathLib(ExecutionMethod.Recursive);

        //    //Act
        //    int result = systemUnderTest.Factorial(factorialFor, false, DoubleFactorialType.Odd);

        //    //Assert
        //    Assert.Equal(expected, result);
        //}

        //[Fact]
        //public void Recursive_OddFactorialFor_7_ShouldReturn_105()
        //{
        //    //Arrange
        //    int factorialFor = 7;
        //    int expected = 105;
        //    var systemUnderTest = new MathLib(ExecutionMethod.Recursive);

        //    //Act
        //    int result = systemUnderTest.Factorial(factorialFor, false, DoubleFactorialType.Odd);

        //    //Assert
        //    Assert.Equal(expected, result);
        //}


        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(6, 15)]
        [InlineData(7, 105)]
        [InlineData(10, 945)]
        [InlineData(11, 10395)]
        public void NonRecursive_OddFactorialFor_ShouldReturnAFactorial(int factorialFor, int expected)
        {
            //Arrange
            var systemUnderTest = new MathLib(ExecutionMethod.NonRecursive);

            //Act
            int result = systemUnderTest.Factorial(factorialFor, false, DoubleFactorialType.Odd);

            //Assert
            Assert.Equal(expected, result);
        }


        //[Fact]
        //public void NonRecursive_OddFactorialFor_6_ShouldReturn_15()
        //{
        //    //Arrange
        //    int factorialFor = 6;
        //    int expected = 15;
        //    var systemUnderTest = new MathLib(ExecutionMethod.NonRecursive);

        //    //Act
        //    int result = systemUnderTest.Factorial(factorialFor, false, DoubleFactorialType.Odd);

        //    //Assert
        //    Assert.Equal(expected, result);
        //}

        //[Fact]
        //public void NonRecursive_OddFactorialFor_7_ShouldReturn_105()
        //{
        //    //Arrange
        //    int factorialFor = 7;
        //    int expected = 105;
        //    var systemUnderTest = new MathLib(ExecutionMethod.NonRecursive);

        //    //Act
        //    int result = systemUnderTest.Factorial(factorialFor, false, DoubleFactorialType.Odd);

        //    //Assert
        //    Assert.Equal(expected, result);
        //}

    }
}
