using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ClassLibrary1
{
    public class Problema7 : ISolver
    {
        public object Solve()
        {
            return CrivoDeErat�stenes.PrimesList(200000).ElementAt(10000);
        }
    }
}