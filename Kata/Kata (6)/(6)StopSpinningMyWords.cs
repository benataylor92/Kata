using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata.Kata__6_
{
    public class StopSpinningMyWords
    {
        public static string SpinWords(string sentence)
        {
            return String.Join(" ", sentence.Split(' ').Select(str => str.Length >= 5 ? new string(str.Reverse().ToArray()) : str));
        }
    }
}
