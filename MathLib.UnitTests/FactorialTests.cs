using System;
using System.Collections.Generic;
using System.Linq;
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
            var systemUnderTest = new MathLib(ExecutionMethod.NonRecursive);

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
            var systemUnderTest = new MathLib(ExecutionMethod.Recursive);

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
            var systemUnderTest = new MathLib(ExecutionMethod.NonRecursive);

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
            var systemUnderTest = new MathLib(ExecutionMethod.Recursive);

            //Act
            int result = systemUnderTest.Factorial(factorialFor);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void OddFactorialFor_6_ShouldReturn_15()
        {
            //Arrange
            int factorialFor = 6;
            int expected = 15;
            var systemUnderTest = new MathLib(ExecutionMethod.NonRecursive);

            //Act
            int result = systemUnderTest.OddFactorialNonRecursively(factorialFor);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void OddFactorialFor_7_ShouldReturn_105()
        {
            //Arrange
            int factorialFor = 7;
            int expected = 105;
            var systemUnderTest = new MathLib(ExecutionMethod.NonRecursive);

            //Act
            int result = systemUnderTest.OddFactorialRecursively(factorialFor);

            //Assert
            Assert.Equal(expected, result);
        }
    }

    public enum ExecutionMethod 
    { 
        NonRecursive = 1,
        Recursive = 0
    }

    public class MathLib
    {
        private readonly ExecutionMethod _executionMethod;

        public MathLib()
        {
            this._executionMethod = ExecutionMethod.Recursive;
        }

        public MathLib(ExecutionMethod executionMethod)
        {
            this._executionMethod = executionMethod;
        }


        internal int Factorial(int factorialFor)
        {
            int result = 0;

            // Anything below 0 will be defaulted to 1.
            // In case of factorial for 1, anything multiplied by 0 will be 0. Hence the check for factorial of 1
            if (factorialFor <= 1)
            {
                result = 1;
            }
            else 
            {
                result = this._executionMethod == ExecutionMethod.Recursive ?
                    CalculateFactorialRecursively(factorialFor) :
                    CalculateFactorialNonRecursively(factorialFor);
            }

            return result;
        }

        /// <summary>
        /// A method that calculates the factorial using list functions
        /// </summary>
        /// <param name="factorialFor">Integer for which the factorial needs to be calculated for.</param>
        /// <returns>The factorial for the supplied number.</returns>
        private int CalculateFactorialNonRecursively(int factorialFor)
        {
            int factorial = 0;

            IEnumerable<int> numbersList = Enumerable.Range(1, factorialFor);
            factorial = numbersList.Aggregate((aggregateValue, currentElement) => aggregateValue * currentElement);

            return factorial;
        }

        /// <summary>
        /// A method that calculates the factorial using recursive functions
        /// </summary>
        /// <param name="factorialFor">Integer for which the factorial needs to be calculated for.</param>
        /// <returns>The factorial for the supplied number.</returns>
        private int CalculateFactorialRecursively(int factorialFor)
        {
            // Check to break recursivness
            if (factorialFor <= 1)
            {
                return factorialFor;
            }

            return factorialFor * CalculateFactorialRecursively(factorialFor - 1);
        }

        internal int OddFactorialNonRecursively(int factorialFor)
        {
            int factorial = 0;

            IEnumerable<int> numbersList = Enumerable.Range(1, factorialFor).Where(n => n % 2 != 0);
            factorial = numbersList.Aggregate((aggregateValue, currentElement) => aggregateValue * currentElement);

            return factorial;
        }

        internal int OddFactorialRecursively(int factorialFor)
        {
            // Check to break recursivness
            if (factorialFor <= 1)
            {
                return factorialFor;
            }

            return factorialFor * OddFactorialRecursively(factorialFor - 2);
        }
    }
}
