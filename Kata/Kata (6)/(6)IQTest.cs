using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata.Kata__6_
{
    public class IQTest
    {
        public static int Test(string numbers)
        {
            int[] Timmy = numbers.Split(' ').Select(int.Parse).ToArray();

            int firstThreeParity = Timmy[0] % 2 + Timmy[1] % 2 + Timmy[2] % 2;

            int rem = firstThreeParity < 2 ? 1 : 0;
            var value = 0;

            for (int i = 1; i < Timmy.Length; i++)
            {
                if(Timmy[i] % 2 == rem)
                {
                    value = i;
                }
            }
            return value + 1;
        }
    }
}
