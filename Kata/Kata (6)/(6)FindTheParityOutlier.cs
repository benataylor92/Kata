using System.Collections.Generic;
using System.Linq;
using System;
using System.Runtime.CompilerServices;

namespace Kata
{
    public class FindTheParityOutlier
    {
        public static int Find(int[] integers)
        {
            int firstThreeParity = integers[0] % 2 + integers[1] % 2 + integers[2] % 2;

            int rem = firstThreeParity < 2 ? 1 : 0;

            for(int i = 0; i < integers.Length; i++)
            {
                if(integers[i] % 2 == rem)
                {
                    return integers[i];
                }
            }
            return -1;
        }
    }
}
