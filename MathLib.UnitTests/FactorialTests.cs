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

        //[Fact]
        //public void RecursiveFactorialFor_0_ShouldReturn_1()
        //{
        //    //Arrange
        //    int factorialFor = 0;
        //    int expected = 1;
        //    var systemUnderTest = new MathLib(ExecutionMethod.Recursive);

        //    //Act
        //    int result = systemUnderTest.Factorial(factorialFor);

        //    //Assert
        //    Assert.Equal(expected, result);
        //}

        //[Fact]
        //public void RecursiveFactorialFor_1_ShouldReturn_1()
        //{
        //    //Arrange
        //    int factorialFor = 1;
        //    int expected = 1;
        //    var systemUnderTest = new MathLib(ExecutionMethod.Recursive);

        //    //Act
        //    int result = systemUnderTest.Factorial(factorialFor);

        //    //Assert
        //    Assert.Equal(expected, result);
        //}

        //[Fact]
        //public void RecursiveFactorialFor_2_ShouldReturn_2()
        //{
        //    //Arrange
        //    int factorialFor = 2;
        //    int expected = 2;
        //    var systemUnderTest = new MathLib();

        //    //Act
        //    int result = systemUnderTest.Factorial(factorialFor);

        //    //Assert
        //    Assert.Equal(expected, result);
        //}

        //[Fact]
        //public void RecursiveFactorialFor_3_ShouldReturn_6()
        //{
        //    //Arrange
        //    int factorialFor = 3;
        //    int expected = 6;
        //    var systemUnderTest = new MathLib();

        //    //Act
        //    int result = systemUnderTest.Factorial(factorialFor);

        //    //Assert
        //    Assert.Equal(expected, result);
        //}

        //[Fact]
        //public void RecursiveFactorialFor_6_ShouldReturn_720()
        //{
        //    //Arrange
        //    int factorialFor = 6;
        //    int expected = 720;
        //    var systemUnderTest = new MathLib(ExecutionMethod.Recursive);

        //    //Act
        //    int result = systemUnderTest.Factorial(factorialFor);

        //    //Assert
        //    Assert.Equal(expected, result);
        //}

        //[Fact]
        //public void RecursiveFactorialFor_10_ShouldReturn_3628800()
        //{
        //    //Arrange
        //    int factorialFor = 10;
        //    int expected = 3628800;
        //    var systemUnderTest = new MathLib(ExecutionMethod.Recursive);

        //    //Act
        //    int result = systemUnderTest.Factorial(factorialFor);

        //    //Assert
        //    Assert.Equal(expected, result);
        //}

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

        //[Fact]
        //public void NonRecursiveFactorialFor_0_ShouldReturn_1()
        //{
        //    //Arrange
        //    int factorialFor = 0;
        //    int expected = 1;
        //    var systemUnderTest = new MathLib(ExecutionMethod.NonRecursive);

        //    //Act
        //    int result = systemUnderTest.Factorial(factorialFor);

        //    //Assert
        //    Assert.Equal(expected, result);
        //}

        //[Fact]
        //public void NonRecursiveFactorialFor_1_ShouldReturn_1()
        //{
        //    //Arrange
        //    int factorialFor = 1;
        //    int expected = 1;
        //    var systemUnderTest = new MathLib(ExecutionMethod.NonRecursive);

        //    //Act
        //    int result = systemUnderTest.Factorial(factorialFor);

        //    //Assert
        //    Assert.Equal(expected, result);
        //}

        //[Fact]
        //public void NonRecursiveFactorialFor_2_ShouldReturn_2()
        //{
        //    //Arrange
        //    int factorialFor = 2;
        //    int expected = 2;
        //    var systemUnderTest = new MathLib(ExecutionMethod.NonRecursive);

        //    //Act
        //    int result = systemUnderTest.Factorial(factorialFor);

        //    //Assert
        //    Assert.Equal(expected, result);
        //}

        //[Fact]
        //public void NonRecursiveFactorialFor_3_ShouldReturn_6()
        //{
        //    //Arrange
        //    int factorialFor = 3;
        //    int expected = 6;
        //    var systemUnderTest = new MathLib(ExecutionMethod.NonRecursive);

        //    //Act
        //    int result = systemUnderTest.Factorial(factorialFor);

        //    //Assert
        //    Assert.Equal(expected, result);
        //}

        //[Fact]
        //public void NonRecursiveFactorialFor_6_ShouldReturn_720()
        //{
        //    //Arrange
        //    int factorialFor = 6;
        //    int expected = 720;
        //    var systemUnderTest = new MathLib(ExecutionMethod.NonRecursive);

        //    //Act
        //    int result = systemUnderTest.Factorial(factorialFor);

        //    //Assert
        //    Assert.Equal(expected, result);
        //}

        //[Fact]
        //public void NonRecursiveFactorialFor_10_ShouldReturn_3628800()
        //{
        //    //Arrange
        //    int factorialFor = 10;
        //    int expected = 3628800;
        //    var systemUnderTest = new MathLib(ExecutionMethod.NonRecursive);

        //    //Act
        //    int result = systemUnderTest.Factorial(factorialFor);

        //    //Assert
        //    Assert.Equal(expected, result);
        //}

        #endregion Non-recursive function tests
    }
}