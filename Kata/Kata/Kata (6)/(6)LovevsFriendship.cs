using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata
{
    public class Love_vs_Friendship
    {
        public static int WordsToMarks(string str) => str.Sum(x => x - 96);
    }
}
