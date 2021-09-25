using Anthill.EulerProblems.Interfaces;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Anthill.EulerProblems
{
    public class MultiplesOfThreeOrFiveProblem : IProblemDescriber, IProblemInitialiser, IProblemCalculator, IProblemDigitAggregator, IProblemResultFormatter
    {
        private int Number { get; set; }
        private List<BigInteger> NaturalSequence { get; set; } = new List<BigInteger>();
        private List<BigInteger> ThreeFiveSequence { get; set; } = new List<BigInteger>();
        private BigInteger DigitSum { get; set; }

        public MultiplesOfThreeOrFiveProblem()
        {
        }

        public MultiplesOfThreeOrFiveProblem(int number)
        {
            this.Number = number;
        }

        public void Initialise(int number)
        {
            this.Number = number;
        }

        public void Calculate()
        {
            for(int i = 1; i < Number; i++)
            {
                NaturalSequence.Add(i);
            }
        }

        public string Describe()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("");
            builder.AppendLine("Multiples of Three or Five");
            builder.AppendLine("");
            builder.AppendLine("If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.The sum of these multiples is 23.");
            builder.AppendLine("");
            builder.AppendLine("Find the sum of all the multiples of 3 or 5 below 1000.");
            builder.AppendLine("");
            builder.AppendLine("Lets give it a try!");
            return builder.ToString();
        }

        public string FormatOutputResults()
        {
            var naturalSequence = string.Join(", ", NaturalSequence);
            var problemSequence = string.Join(", ", ThreeFiveSequence);

            StringBuilder builder = new StringBuilder();
            builder.AppendLine("");
            builder.AppendLine($"You supplied the number {Number}");
            builder.AppendLine("");
            builder.AppendLine($"The natural sequence of numbers is {naturalSequence}");
            builder.AppendLine("");
            builder.AppendLine($"The sequence of multiples of 3 or 5 is {problemSequence}");
            builder.AppendLine("");
            builder.AppendLine($"The sum of all the multples of 3 or 5 below {Number} is {DigitSum} ");
            return builder.ToString();
        }

        public void Sum()
        {
            DigitSum = 0;

            foreach (var number in NaturalSequence)
            {
                if(number % 3 == 0 ||
                    number % 5 == 0)
                {
                    ThreeFiveSequence.Add(number);
                    DigitSum += number;
                }

                if (number % 3 != 0 && number % 5 != 0)
                {
                    //Ignore
                }
            }
        }
    }
}
