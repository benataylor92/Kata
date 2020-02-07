using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata.Kata__4_
{
    public class SudokuSolutionValidator
    {
        public static int[] snail(int[][] array)
        {
            int l = array[0].Length;
            int[] sorted = new int[l * l];
            Snail(array, -1, 0, 1, 0, l, 0, sorted);
            return sorted;
        }

        public static void Snail(int[][] array, int x, int y, int dx, int dy, int l, int i, int[] sorted)
        {
            if (l == 0)
                return;
            for (int j = 0; j < l; j++)
            {
                x += dx;
                y += dy;
                sorted[i++] = array[y][x];
            }
            Snail(array, x, y, -dy, dx, dy == 0 ? l - 1 : l, i, sorted);
        }
    }
}
//        {

//            int i = 0;
//            int j = 0;
//            int k = 1;

//            long[] f = new long[9];

//            long r = 0L, c = r, g = r, z = 45L, q = r;

//            for (f[0] = 1L; k < 9;)
//            {
//                f[k] = f[k - 1] * 45;
//                z += f[k++] * 45;
//            }

//            for (; i < 9; i++)
//            {
//                for (j = 0; j < 9;)
//                {
//                    k = board[i][j];
//                    r += k * f[i];
//                    c += k * f[j];
//                    g += k * f[j++ / 3 + 3 * (i / 3)];
//                    q += 5 * f[k - 1];
//                }
//            }

//            if (r == z && c == z && g == z && q == z)
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }
//    }
//}
