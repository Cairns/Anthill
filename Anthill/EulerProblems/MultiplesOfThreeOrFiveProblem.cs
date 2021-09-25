using Anthill.EulerProblems.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Anthill.EulerProblems
{
    public class MultiplesOfThreeOrFiveProblem : IProblemDescriber, IProblemInitialiser, IProblemCalculator, IProblemDigitAggregator, IProblemResultFormatter
    {
        private int Number { get; set; }

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
            throw new NotImplementedException();
        }

        public string Describe()
        {
            throw new NotImplementedException();
        }

        public string FormatOutputResults()
        {
            throw new NotImplementedException();
        }

        public void Sum()
        {
            throw new NotImplementedException();
        }
    }
}
