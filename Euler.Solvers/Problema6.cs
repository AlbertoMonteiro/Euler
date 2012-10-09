using System;
using System.Linq;

namespace Euler.Solvers
{
    public class Problema6 : ISolver
    {
        public object Solve()
        {
            var range = Enumerable.Range(1, 100);
            var sumOfSquare = range.Aggregate(0, (i, i1) => (int) (i + (Math.Pow(i1,2))));
            var squareOfSum = Math.Pow(range.Sum(), 2);

            return squareOfSum - sumOfSquare;
        }
    }
}