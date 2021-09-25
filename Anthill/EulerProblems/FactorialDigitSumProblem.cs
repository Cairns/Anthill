using Anthill.EulerProblems.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Anthill.EulerProblems
{
    public class FactorialDigitSumProblem : IProblemDescriber, IProblemCalculator, IProblemDigitAggregator, IProblemResultFormatter
    {
        private int Number { get; set; }
        private BigInteger Factorial { get; set; }
        private BigInteger FactorialSum { get; set; }

        public FactorialDigitSumProblem(int number)
        {
            this.Number = number;
        }

        public void Calculate()
        {
            Factorial = CalculateFactorial(Number);
        }

        public string Describe()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("");
            builder.AppendLine("Factorial digit sum");
            builder.AppendLine("");
            builder.AppendLine("n! means n × (n − 1) × ... × 3 × 2 × 1");
            builder.AppendLine("");
            builder.AppendLine("For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,");
            builder.AppendLine("and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.");
            builder.AppendLine("");
            builder.AppendLine("Lets give it a try!");
            return builder.ToString();
        }

        public string FormatOutputResults()
        {
            var factorialExpression = string.Join("*", Enumerable.Range(1, Number));
            var sequence = String.Format("{0}!={1}={2}", Number, factorialExpression, Factorial);

            StringBuilder builder = new StringBuilder();
            builder.AppendLine("");
            builder.AppendLine($"You supplied the number {Number}");
            builder.AppendLine("");
            builder.AppendLine(sequence.ToString());
            builder.AppendLine("");
            builder.AppendLine($"The sum of the digits for factorial {Number} is {FactorialSum}");
            return builder.ToString();
        }

        public void Sum()
        {
            FactorialSum = 0;
            var factorial = this.Factorial;
            while (factorial != 0)
            {
                FactorialSum += factorial % 10;
                factorial /= 10;
            }
        }

        private static BigInteger CalculateFactorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * CalculateFactorial(number - 1);
        }
    }
}
