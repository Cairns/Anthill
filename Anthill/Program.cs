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

            Console.WriteLine($"The factorial sum of {number} is {factorial}");

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

