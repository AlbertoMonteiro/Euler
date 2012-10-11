using System;
using System.Collections.Generic;

namespace Euler.Solvers
{
    public class Problema15 : ISolver
    {
        private readonly int gridLength;
        private Dictionary<Tuple<int, int>, int> dic;

        public Problema15(int gridLength)
        {
            this.gridLength = gridLength;
            dic = new Dictionary<Tuple<int, int>, int>();
        }

        public object Solve()
        {
            var startPosition = Tuple.Create(0, 0);

            return 2+GetRoutesToTheEnd(startPosition);
        }

        private int GetRoutesToTheEnd(Tuple<int, int> startPosition)
        {
            if (dic.ContainsKey(startPosition))
                return dic[startPosition];

            var routes = 0;
            if (startPosition.Item1 + 1 < gridLength)
                routes++;
            if (startPosition.Item2 + 1 < gridLength)
                routes++;

            if (startPosition.Item1 + 1 < gridLength)
                routes += GetRoutesToTheEnd(new Tuple<int, int>(startPosition.Item1 + 1, startPosition.Item2));
            if (startPosition.Item2 + 1 < gridLength)
                routes += GetRoutesToTheEnd(new Tuple<int, int>(startPosition.Item1, startPosition.Item2 + 1));

            dic.Add(startPosition,routes);

            return routes;
        }
    }
}