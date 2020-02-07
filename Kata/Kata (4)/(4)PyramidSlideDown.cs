using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Kata.Kata__4_
{
    public class PyramidSlideDown
    {
        public static int LongestSlideDown(int[][] pyramid)
        {
            for (var i = pyramid.Length - 1; i > 0; i--)
            for (var k = 0; k < pyramid[i].Length - 1; k++)
                pyramid[i - 1][k] += System.Math.Max(pyramid[i][k], pyramid[i][k + 1]);

            return pyramid[0][0];
        }
    }
}
