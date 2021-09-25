using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Anthill.Extensions
{
    public static class BigIntegerExtensions
    {
        public static bool IsOdd(this BigInteger number)
        {
            return !number.IsEven;
        }
    }
}
