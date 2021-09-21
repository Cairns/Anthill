using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Anthill
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = GetNumber();

            BigInteger factorial = Factorial(number);

            BigInteger sum = Sum(factorial);

            PrintFactorialSum(number, factorial, sum);

            Exit();
        }

        private static int GetNumber()
        {
            int number;
            Console.WriteLine("Please enter a number");
            string input = CaptureInput();

            if (!int.TryParse(input, out number))
            {
                Console.WriteLine($"Invalid Input: {input}");
                return 0;
            }
            {
                return number;
            }
        }

        private static string CaptureInput()
        {
            return Console.ReadLine();
        }

        private static BigInteger Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * Factorial(number - 1);
        }

        private static BigInteger Sum(BigInteger factorial)
        {
            BigInteger sum = 0;
            while (factorial != 0)
            {
                sum += factorial % 10;
                factorial /= 10;
            }

            return sum;
        }

        private static void PrintFactorialSum(int number, BigInteger factorial, BigInteger sum)
        {
            var factorialExpression = string.Join("*", Enumerable.Range(1, number));
            Console.WriteLine("{0}!={1}={2}", number, factorialExpression, factorial);

            Console.WriteLine($"The sum of the digits for factorial {number} is {sum}");
        }

        private static void Pause(int seconds)
        {
            TimeSpan timeSpan = new TimeSpan(0, 0, seconds);
            Thread.Sleep(timeSpan);
        }

        private static void Exit()
        {
            Console.WriteLine("");
            Console.WriteLine("Exiting the program");
            Pause(2);
            Environment.Exit(0);
        }
    }
}

