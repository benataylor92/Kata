using System.Collections.Generic;
using System.Linq;

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
        //return string.Join(" ", str.Split(' ').Select(w => w.Substring(1) + w[0] + "ay"));
    }
}
