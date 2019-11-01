using System;
using System.Collections.Generic;
using System.Text;

namespace Kata
{
    public class Multiplesof3or5
    {
        public static int Solution(int value)
        {
            var hello = 0;

            for (int i = 3; i < value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    hello += i;
                }
            }
            return hello;

        }
    }
}
