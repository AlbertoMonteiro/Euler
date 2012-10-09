using System.Collections.Generic;
using System.Linq;

namespace Euler.Solvers
{
    public class Problema20 : ISolver
    {
        public object Solve()
        {
            var valores = new List<int> { 1 };

            for (int i = 2; i <= 100; i++)
            {
                int novoValor = 0;

                for (int j = valores.Count - 1; j >= 0; j--)
                {
                    var valorDaMultiplicacao = valores[j] * i + novoValor;
                    var resto = valorDaMultiplicacao % 10;
                    novoValor = valorDaMultiplicacao / 10;
                    valores[j] = resto;
                }
                if (novoValor > 0)
                    valores.Insert(0, novoValor);
                Fix(valores);
            }
            return valores.Sum();
        }

        private static void Fix(List<int> valores)
        {
            for (int i = valores.Count - 1; i >= 0; i--)
            {
                var valor = valores[i];
                if (valor / 10 > 0)
                {
                    valores[i] = valor % 10;
                    valores.Insert(0, valor / 10);
                    i++;
                }
            }
        }
    }
}
