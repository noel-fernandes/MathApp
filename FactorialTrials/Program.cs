using System;
using System.Collections.Generic;
using System.Linq;

namespace FactorialTrials
{
    internal static class Program
    {
        enum DoubleFactorial
        {
            All = 0,
            Even = 1,
            Odd = 2
        }

        static void Main(string[] args)
        {
            //Func<int, int, int> add = (i, j) => i + j;
            //var integers = new[] { 1, 2, 3, 5 };
            //var sum = RecursiveFunction(add, integers, 0);
            //Console.WriteLine(sum);


            int factorialFor = 100;
            DoubleFactorial doubleFactorial = DoubleFactorial.All;

            int result = 0;
            try
            {
                CalculateFactorial(factorialFor, doubleFactorial);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Too large to compute");
            }
                
            Console.WriteLine($"Single Factorial for {factorialFor} = {result}");
            Console.WriteLine("");
            Console.WriteLine("");


            //// Request ODD, Provide Odd number
            //factorialFor = 7;
            //doubleFactorial = DoubleFactorial.Odd;

            //result = CalculateFactorial(factorialFor, doubleFactorial);
            //Console.WriteLine($"Odd Double Factorial for {factorialFor} = {result}");
            //Console.WriteLine("");
            //Console.WriteLine("");


            //// Request Even, Provide Odd number
            //factorialFor = 7;
            //doubleFactorial = DoubleFactorial.Even;

            //result = CalculateFactorial(factorialFor, doubleFactorial);
            //Console.WriteLine($"Even Double Factorial for {factorialFor} = {result}");
            //Console.WriteLine("");
            //Console.WriteLine("");


            //// SQUARE
            //factorialFor = 5;
            //doubleFactorial = DoubleFactorial.All;
            //bool squareFactorial = true;

            //result = CalculateFactorial(factorialFor, doubleFactorial, squareFactorial);
            //Console.WriteLine($"SQUARE Factorial for {factorialFor} = {result}");
            //Console.WriteLine("");
            //Console.WriteLine("");


            //// SQUARE Request ODD, Provide Odd number
            //factorialFor = 7;
            //doubleFactorial = DoubleFactorial.Odd;
            //squareFactorial = true;

            //result = CalculateFactorial(factorialFor, doubleFactorial, squareFactorial);
            //Console.WriteLine($"SQUARE Odd Factorial for {factorialFor} = {result}");
            //Console.WriteLine("");
            //Console.WriteLine("");


            //// SQUARE Request Even, Provide Odd number
            //factorialFor = 7;
            //doubleFactorial = DoubleFactorial.Even;
            //squareFactorial = true;

            //result = CalculateFactorial(factorialFor, doubleFactorial, squareFactorial);
            //Console.WriteLine($"SQUARE Even Factorial for {factorialFor} = {result}");
            //Console.WriteLine("");
            //Console.WriteLine("");

            Console.Read();
        }

        static int CalculateFactorial(int factorialFor, DoubleFactorial doubleFactorial = DoubleFactorial.All, bool squareFactorial = false)
        {
            int jumpFactor = 0;

            if (doubleFactorial is DoubleFactorial.Even)
            {
                factorialFor = (factorialFor % 2 != 0) ? --factorialFor : factorialFor;
                jumpFactor = 2;
            }
            else if (doubleFactorial is DoubleFactorial.Odd)
            {
                factorialFor = (factorialFor % 2 == 0) ? --factorialFor : factorialFor;
                jumpFactor = 2;
            }

            var func = RecursiveFactorialFunction(squareFactorial);
            int result = func(factorialFor, jumpFactor);
            return result;
        }


        static Func<int, int, int> RecursiveFactorialFunction(bool squareFactorial)
        {
            Func<int, int, int> factorialFunction = null;
            if (squareFactorial)
                factorialFunction = (num, jf) => num <= 1 ? 1
                : (num * num) * factorialFunction(num - jf, jf);
            else
            {
                factorialFunction = (num, jf) => num <= 1 ? 1
                : num * factorialFunction(num - jf, jf);
            }

            return factorialFunction;
        }
    }
}