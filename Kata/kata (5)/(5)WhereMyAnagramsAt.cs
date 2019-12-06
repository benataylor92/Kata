using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Kata.kata__5_
{
    public class WhereMyAnagramsAt
    {
        public static List<string> Anagrams(string word, List<string> words)
        {
            string word1 = String.Concat(word.OrderBy(c => c));

            List<string> test = new List<string>();

            for (int i = 0; i < words.Count; i++)
            {
                string words2 = String.Concat(words[i].OrderBy(c => c));

                if (word1 == words2)
                {
                    test.Add(words[i]);
                }

            }
            return test;
        }

        //return words?.Where(w => w.OrderBy(c => c).SequenceEqual(word.OrderBy(c => c))).ToList();
    }
}
