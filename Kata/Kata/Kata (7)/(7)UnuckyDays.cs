using System;
using System.Linq;
using System.Net;

namespace Kata
{
    public static class Kata1
    {
        public static int UnluckyDays(int year)
        {
            return Enumerable.Range(1, 12).Select(x => new DateTime(year, x, 13))
                .Count(x => x.DayOfWeek == DayOfWeek.Friday);
        }
    }
}