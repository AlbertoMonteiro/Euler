using System.Linq;
using System.Text.RegularExpressions;

namespace Euler.Solvers
{
    public class Problema17 : ISolver
    {
        public object Solve()
        {
            return Enumerable.Range(1, 1000).Select(x => x.ByExtensive()).Select(RemoveEspacoEHifem).Sum();
        }

        private static int RemoveEspacoEHifem(string x)
        {
            var espacosEHifem = new Regex(@"[\s-]+");
            return espacosEHifem.Replace(x, "").Length;
        }
    }
}
