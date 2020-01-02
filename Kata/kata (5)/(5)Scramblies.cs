using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata.kata__5_
{
    public class Scramblies
    {
        public static bool Scramble(string str1, string str2)
        {
            foreach(var c1 in str2)
            {
                int index = 0;
                if((index = str1.IndexOf(c1)) > -1)
                {
                    str1 = str1.Remove(index, 1);
                }
                else
                {
                    return false;
                }
            }
            return true;

        }
    }
}
