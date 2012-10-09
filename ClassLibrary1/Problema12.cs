using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary1
{
    public class Problema12 : ISolver
    {
        public object Solve()
        {
            return Enumerable.Range(1, int.MaxValue).Select(i => i * (i + 1) / 2).First(x => Factor(x).Count() > 500);
        }

        public IEnumerable<int> Factor(int number)
        {
            var factors = new List<int>();
            var max = (int)Math.Sqrt(number);  //round down
            for (int factor = 1; factor <= max; ++factor)
            { //test from 1 to the square root, or the int below it, inclusive.
                if (number % factor == 0)
                {
                    yield return (factor);
                    if (factor != number / factor)
                    { // Don't add the square root twice!  Thanks Jon
                        yield return (number / factor);
                    }
                }
            }
        }
    }
}