using System.Linq;

namespace Euler.Solvers
{
    public class Problema21 : ISolver
    {
        private readonly int startValue;
        private readonly int maxValue;

        public Problema21(int startValue = 1, int maxValue = 2)
        {
            this.startValue = startValue;
            this.maxValue = maxValue;
        }

        public object Solve()
        {
            var enumerable = Enumerable.Range(startValue, maxValue - startValue + 1).Where(IsAmicable).ToList();
            return enumerable.Sum();
        }

        private static bool IsAmicable(int i)
        {
            var x = Enumerable.Range(1, i - 1).Where(i1 => i % i1 == 0).Sum();
            if (x - 1 <= 0)
                return false;
            var y = Enumerable.Range(1, x - 1).Where(i1 => x % i1 == 0).Sum();
            return i == y && x != i;
        }
    }
}