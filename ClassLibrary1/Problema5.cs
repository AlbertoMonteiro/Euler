using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ClassLibrary1
{
    public class Problema5 : ISolver
    {
        public object Solve()
        {
            var primesList = CrivoDeEratóstenes.PrimesList(20).ToList();
            var divisores = Enumerable.Range(1, 20).ToList();
            var indexPrime = 0;
            var count = 0;
            var lista = new List<int>();
            do
            {
                var actualPrime = primesList[indexPrime];
                if (divisores.Any(i => i % actualPrime == 0))
                {
                    for (int i = 0; i < divisores.Count; i++)
                    {
                        var numero = divisores[i];
                        var remainsSomething = numero % actualPrime == 0;
                        if (remainsSomething)
                            divisores[i] = numero / actualPrime;
                    }
                    lista.Add(actualPrime);
                }
                else
                {
                    indexPrime++;
                }
                Debug.WriteLine(++count);
            } while (divisores.Any(i => i != 1));

            return lista.Aggregate(1, (i, i1) => i * i1);
        }
    }
}
