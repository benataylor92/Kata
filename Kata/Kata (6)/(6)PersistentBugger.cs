using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata.Kata__6_
{
    public class PersistentBugger
    {
        public static int Persistence(long n)
        {
            int count = 0;
            while (n > 9)
            {
                count++;
                n = n.ToString().Select(digit => int.Parse(digit.ToString())).Aggregate((x, y) => x * y);
            }
            return count;
        }
    }
}
