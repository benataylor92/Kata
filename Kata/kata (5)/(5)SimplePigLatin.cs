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
            //string[] arrOfString = str.Split(' ');
            //string start = " ";
            //foreach (string a in arrOfString)
            //{
            //    start += a.Substring(0, a.Length - 1) + " ";
            //    start += "ay";
            //}
            //return start;

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

            //string[] arrayOfString = str.Split(' ');

            //char[] firstword = arrayOfString[0].ToCharArray();

            //var result = firstword.Skip(1).Concat(firstword.Take(1));

            //string s1 = string.Join("", result);

            //s1 += @"ay";
        }
    }
}
