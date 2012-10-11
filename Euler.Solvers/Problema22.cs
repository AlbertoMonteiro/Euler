using System.Net;
using System.Linq;

namespace Euler.Solvers
{
    public class Problema22 : ISolver
    {
        public object Solve()
        {

            string allNames;
            using (var v = new WebClient())
                allNames = v.DownloadString(@"http://projecteuler.net/project/names.txt");

            var names = allNames.Split(',').Select(s => s.Replace("\"", "")).OrderBy(x => x);
            var namesSorted = names.OrderBy(x => x);

            return namesSorted.Select((name, i) => (i+1) * ScoreName(name)).Sum();
        }

        private static int ScoreName(string name)
        {
            const string alphabetic = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var sum = name.Sum(letter => alphabetic.IndexOf(letter)+1);
            return sum;
        }
    }
}