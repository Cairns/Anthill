using Anthill.EulerProblems;
using Anthill.UI;
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
            ShowMainMenu();

            Exit();
        }

        private static void ShowMainMenu()
        {
            bool showMenu = true;

            while (showMenu)
            {
                try
                {
                    showMenu = MainMenu();
                }
                catch(System.NotImplementedException ex)
                {
                    DisplayError(ex.Message);
                    Pause(2);
                    showMenu = true;
                }
                catch(System.Exception ex)
                {
                    DisplayError(ex.Message);
                    Pause(2);
                    showMenu = false;
                }
            }
        }

        public static bool MainMenu()
        {
            Menu.DisplayMainMenu();

            switch (CaptureInput())
            {
                case "1":
                    {
                        //Factorial digit sum
                        HandleFactorial();
                        return true;
                    }
                case "2":
                    {
                        //Even Fibonacci numbers
                        HandleFibonacci();
                        return true;
                    }
                case "3":
                    {
                        //Multiple of 3 or 5
                        HandleMultipleThreeFive();
                        return true;
                    }
                case "0":
                    {
                        //Exit
                        return false;
                    }
                default:
                    {
                        //Invalid option entered
                        Console.WriteLine("You entered an Invalid option.  Please try again");
                        Pause(1);
                        return true;
                    }
            }
        }

        private static void HandleFactorial()
        {
            //TODO:Refactor to not use a recursive function, as this will cause overflow with a relatively small integer 10000
            Console.WriteLine(FactorialDigitSum.Describe());

            int number = GetNumber();
            var problem = new FactorialDigitSum(number);
            problem.Calculate();
            problem.Sum();

            Console.WriteLine(problem.FormatOutputResults());

            ContinueOnInput();
        }

        private static void HandleFibonacci()
        {
            Console.WriteLine(FibonacciOddEvenDigitSum.Describe());

            int number = GetNumber();
            var problem = new FibonacciOddEvenDigitSum(number);
            var temp = problem.Calculate();
            Console.WriteLine(temp);
            problem.Sum();

            Console.WriteLine(problem.FormatOutputResults());

            ContinueOnInput();
        }

        private static void HandleMultipleThreeFive()
        {
            throw new NotImplementedException();
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

        private static void ContinueOnInput()
        {
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue");
            CaptureInput();
        }

        private static void DisplayError(string message)
        {
            Console.WriteLine(message);
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

