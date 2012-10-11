using System;

namespace Euler.Solvers
{
    public class Problema19 : ISolver
    {
        public object Solve()
        {
            var count = 0;
            var initialDate = new DateTime(1901, 1, 1);
            var endDate = new DateTime(2000, 12, 31);

            while (initialDate <= endDate)
            {
                if (initialDate.DayOfWeek == DayOfWeek.Sunday && initialDate.Day == 1)
                {
                    count++;
                    initialDate = initialDate.AddDays(7);
                }
                else
                {
                    initialDate = initialDate.AddDays(1);
                }
            }

            return count;
        }
    }
}