using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata
{
    public class SumofDigits
    {
        public int DigitalRoot(long n)
        {
            var hello = n.ToString().Select(x => int.Parse(x.ToString()));

            var end = hello.Sum();

            if (end > 10)
            {
                var start = end.ToString().Select(x => int.Parse(x.ToString()));
                return start.Sum();
            }

            return end;
        }
    }
}
