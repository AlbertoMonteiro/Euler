using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary1
{
    public class Problema2 : ISolver
    {
        public object Solve()
        {
            return Fibonnaci().Where(i => i % 2 == 0).Sum();
        }

        private static IEnumerable<int> Fibonnaci()
        {
            int a = 1, b = 2;
            yield return a;
            yield return b;

            while (b < 4000000)
            {
                var aux = b;
                b += a;
                a = aux;
                yield return b;
            }
        }
    }
}