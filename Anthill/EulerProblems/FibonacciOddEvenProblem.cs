﻿using Anthill.EulerProblems.Interfaces;
using Anthill.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Anthill.EulerProblems
{
    public class FibonacciOddEvenProblem : IProblemDescriber, IProblemInitialiser, IProblemCalculator, IProblemDigitAggregator, IProblemResultFormatter
    {
        private int Number { get; set; }
        private List<BigInteger> FibonacciSequence { get; set; } = new List<BigInteger>();
        private BigInteger EvenDigitSum { get; set; }
        private BigInteger OddDigitSum { get; set; }

        public FibonacciOddEvenProblem()
        {

        }

        public FibonacciOddEvenProblem(int number)
        {
            this.Number = number;
        }

        public void Initialise(int number)
        {
            this.Number = number;
        }

        public void Calculate()
        {
            FibonacciSequence.Clear();
            CalculateFibonacci(Number);
        }

        public string Describe()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("");
            builder.AppendLine("Even fibonacci numbers");
            builder.AppendLine("");
            builder.AppendLine("Each new term in the Fibonacci sequence is generated by adding the previous two terms.By starting with 1 and 2, the first 10 terms will be:");
            builder.AppendLine("");
            builder.AppendLine("1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...");
            builder.AppendLine("");
            builder.AppendLine("By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.");
            builder.AppendLine("");
            builder.AppendLine("Lets give it a try!");
            return builder.ToString();
        }

        public string FormatOutputResults()
        {
            var sequence = string.Join(", ", FibonacciSequence);

            StringBuilder builder = new StringBuilder();
            builder.AppendLine("");
            builder.AppendLine($"You supplied the number {Number}");
            builder.AppendLine("");
            builder.AppendLine(sequence);
            builder.AppendLine("");
            builder.AppendLine($"The sum of the even digits for {Number} fibonacci is {EvenDigitSum} ");
            builder.AppendLine($"The sum of the odd digits for {Number} fibonacci is {OddDigitSum} ");
            return builder.ToString();
        }

        public void Sum()
        {
            EvenDigitSum = 0;
            OddDigitSum = 0;

            foreach(var number in FibonacciSequence)
            {
                if (number.IsEven)
                {
                    EvenDigitSum += number;
                }
                else
                {
                    OddDigitSum += number;
                }
            }
        }

        //TODO:Investigate matrix multiplcation version
        private void CalculateFibonacci(int number)
        {
            BigInteger a = 0;
            BigInteger b = 1;

            //Iterate through the fibonacci sequence so we can construct it and store for later use
            for (int i = 0; i < number; i++)
            {
                BigInteger temp = a;
                a = b;
                b = temp + a;

                FibonacciSequence.Add(temp);
            }

            FibonacciSequence.Add(a);
        }
    }
}
