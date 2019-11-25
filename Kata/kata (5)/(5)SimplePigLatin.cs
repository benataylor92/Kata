using EO.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata.kata__5_
{
    public class SimplePigLatin
    {
        public static string PigIt(string str)
        {
            string[] arrayOfString = str.Split(' ');

            List<string> finish = new List<string>();

            foreach (string word in arrayOfString)
            {
                var result = word.Skip(1).Concat(word.Take(1));

                string start = string.Join("", result);

                start += @"ay";

                finish.Add(start);
            }

            var expected = string.Join(" ", finish);


            return expected;
        }
    }
}
