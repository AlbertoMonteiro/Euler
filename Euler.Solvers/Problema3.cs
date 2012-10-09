using System;
using System.Linq;

namespace Euler.Solvers
{
    public class Problema3 : ISolver
    {
        public object Solve()
        {
            return CrivoDeEratóstenes.PrimesList((int)Math.Sqrt(600851475143)).AsParallel().Last(x => 600851475143 % x == 0);
        }
    }
}