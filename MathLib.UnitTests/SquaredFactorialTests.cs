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

        //[Theory]
        //[InlineData(0, 1)]
        //[InlineData(1, 1)]
        //[InlineData(6, 2304)]
        //[InlineData(7, 2304)]
        //public void Squared_Recursive_FactorialFor_EvenNumbers_ShouldReturn_AFactorial(int factorialFor, int expected)
        //{
        //    var systemUnderTest = new MathLib();

        //    //Act
        //    int result = systemUnderTest.Factorial(factorialFor, true, DoubleFactorialType.Even);

        //    //Assert
        //    Assert.Equal(expected, result);
        //}



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

        //[Theory]
        //[InlineData(0, 1)]
        //[InlineData(1, 1)]
        //[InlineData(6, 2304)]
        //[InlineData(7, 2304)]
        //public void Squared_NonRecursive_FactorialFor_EvenNumbers_ShouldReturn_AFactorial(int factorialFor, int expected)
        //{
        //    var systemUnderTest = new MathLib(ExecutionMethod.NonRecursive);

        //    //Act
        //    int result = systemUnderTest.Factorial(factorialFor, true, DoubleFactorialType.Even);

        //    //Assert
        //    Assert.Equal(expected, result);
        //}


        //[Fact]
        //public void Squared_Recursive_FactorialFor_6_ShouldReturn_518400()
        //{
        //    //Arrange
        //    int factorialFor = 6;
        //    int expected = 518400;
        //    var systemUnderTest = new MathLib(ExecutionMethod.Recursive);

        //    //Act
        //    int result = systemUnderTest.Factorial(factorialFor, true);

        //    //Assert
        //    Assert.Equal(expected, result);
        //}

        //[Fact]
        //public void Squared_Recursive_FactorialFor_7_ShouldReturn_25401600()
        //{
        //    //Arrange
        //    int factorialFor = 7;
        //    int expected = 25401600;
        //    var systemUnderTest = new MathLib(ExecutionMethod.Recursive);

        //    //Act
        //    int result = systemUnderTest.Factorial(factorialFor, true);

        //    //Assert
        //    Assert.Equal(expected, result);
        //}



        //[Fact]
        //public void Squared_Nonrecursive_FactorialFor_6_ShouldReturn_518400()
        //{
        //    //Arrange
        //    int factorialFor = 6;
        //    int expected = 518400;
        //    var systemUnderTest = new MathLib(ExecutionMethod.NonRecursive);

        //    //Act
        //    int result = systemUnderTest.Factorial(factorialFor, true);

        //    //Assert
        //    Assert.Equal(expected, result);
        //}

        //[Fact]
        //public void Squared_Nonrecursive_FactorialFor_7_ShouldReturn_25401600()
        //{
        //    //Arrange
        //    int factorialFor = 7;
        //    int expected = 25401600;
        //    var systemUnderTest = new MathLib(ExecutionMethod.NonRecursive);

        //    //Act
        //    int result = systemUnderTest.Factorial(factorialFor, true);

        //    //Assert
        //    Assert.Equal(expected, result);
        //}




        //[Fact]
        //public void Squared_Nonrecursive_Even_FactorialFor_6_ShouldReturn_2304()
        //{
        //    //Arrange
        //    int factorialFor = 6;
        //    int expected = 2304;
        //    var systemUnderTest = new MathLib(ExecutionMethod.NonRecursive);

        //    //Act
        //    int result = systemUnderTest.Factorial(factorialFor, true, DoubleFactorialType.Even);

        //    //Assert
        //    Assert.Equal(expected, result);
        //}

        //[Fact]
        //public void Squared_Nonrecursive_Odd_FactorialFor_6_ShouldReturn_225()
        //{
        //    //Arrange
        //    int factorialFor = 6;
        //    int expected = 225;
        //    var systemUnderTest = new MathLib(ExecutionMethod.NonRecursive);

        //    //Act
        //    int result = systemUnderTest.Factorial(factorialFor, true, DoubleFactorialType.Odd);

        //    //Assert
        //    Assert.Equal(expected, result);
        //}
    }
}
