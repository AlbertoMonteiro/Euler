using System.Linq;

namespace Euler.Solvers
{
    public class Problema7 : ISolver
    {
        public object Solve()
        {
            return CrivoDeEratóstenes.PrimesList(200000).ElementAt(10000);
        }
    }
}