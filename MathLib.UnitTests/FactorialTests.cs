using System;
using Xunit;

namespace MathLib.UnitTests
{
    public class FactorialTests
    {
        [Fact]
        public void FactorialFor_0_ShouldReturn_1()
        {
            //Arrange
            int factorialFor = 0;
            int expected = 1;
            var systemUnderTest = new MathLib();

            //Act
            int result = systemUnderTest.Factorial(factorialFor);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void FactorialFor_1_ShouldReturn_1()
        {
            //Arrange
            int factorialFor = 1;
            int expected = 1;
            var systemUnderTest = new MathLib();

            //Act
            int result = systemUnderTest.Factorial(factorialFor);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void FactorialFor_2_ShouldReturn_2()
        {
            //Arrange
            int factorialFor = 2;
            int expected = 2;
            var systemUnderTest = new MathLib();

            //Act
            int result = systemUnderTest.Factorial(factorialFor);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void FactorialFor_3_ShouldReturn_6()
        {
            //Arrange
            int factorialFor = 3;
            int expected = 6;
            var systemUnderTest = new MathLib();

            //Act
            int result = systemUnderTest.Factorial(factorialFor);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void FactorialFor_6_ShouldReturn_720()
        {
            //Arrange
            int factorialFor = 6;
            int expected = 720;
            var systemUnderTest = new MathLib();

            //Act
            int result = systemUnderTest.Factorial(factorialFor);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void FactorialFor_10_ShouldReturn_3628800()
        {
            //Arrange
            int factorialFor = 10;
            int expected = 3628800;
            var systemUnderTest = new MathLib();

            //Act
            int result = systemUnderTest.Factorial(factorialFor);

            //Assert
            Assert.Equal(expected, result);
        }
    }

    public class MathLib
    {
        internal int Factorial(int factorialFor)
        {
            throw new NotImplementedException();
        }
    }
}
