using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary1
{
    public class CrivoDeEratóstenes
    {
        public static IEnumerable<int> PrimesList(int N = 1)
        {
            int i, j;
            var vet = new int[N + 1];

            for (vet[1] = 0, i = 2; i < N; i++)
                vet[i] = 1;

            for (i = 2; i <= N; i++)
                for (j = 2; j < N / i; j++)
                    vet[i * j] = 0;

            for (i = 1; i <= N; i++)
                if (vet[i] != 0)
                    yield return i;
        }
    }
}