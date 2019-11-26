using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.kata__5_
{
    public class MovingZerosToTheEnd
    {
        public static int[] MoveZeroes(int[] arr)
        {
            int i = 0;

            for (int j = 0; j < arr.Length; j++)
                if (arr[j] != 0)
                    arr[i++] = arr[j];

            while (i < arr.Length)
                arr[i++] = 0;

            return arr;
        }
    }
}

