using System;
using System.Collections.Generic;
using System.Linq;

namespace Euler.Solvers
{
    public class Problema14 : ISolver
    {
        private Dictionary<long, long> chainsAndCount;

        public object Solve()
        {
            chainsAndCount = new Dictionary<long, long>();
            chainsAndCount.Add(1,1);
            chainsAndCount.Add(2,2);
            var list = Enumerable.Range(1, 1000000).Select(x => GetChainCount(x)).ToList();
            var max = chainsAndCount.OrderBy(x => x.Value);
            return max.Last().Key;
        }

        private long GetChainCount(long actual)
        {
            Func<long, long> forEven = i => i / 2;
            Func<long, long> forOdd = i => 3 * i + 1;
            long chainStart = actual;
            long count = 0;
            if(!chainsAndCount.ContainsKey(actual))
                count += GetChainCount(actual % 2 == 0 ? forEven(actual) : forOdd(actual));
            else
                count += chainsAndCount[actual];
            
            if(!chainsAndCount.ContainsKey(chainStart))
                chainsAndCount.Add(chainStart, ++count);

            return count;
        }
    }
}