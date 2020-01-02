using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace KataTests
{
    [TestFixture]
    public class ScrambliesTests
    {

        private static void testing(bool actual, bool expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void test1()
        {
            testing(Kata.kata__5_.Scramblies.Scramble("rkqodlw", "world"), true);
            testing(Kata.kata__5_.Scramblies.Scramble("cedewaraaossoqqyt", "codewars"), true);
            testing(Kata.kata__5_.Scramblies.Scramble("katas", "steak"), false);
            testing(Kata.kata__5_.Scramblies.Scramble("scriptjavx", "javascript"), false);
            testing(Kata.kata__5_.Scramblies.Scramble("scriptingjava", "javascript"), true);
            testing(Kata.kata__5_.Scramblies.Scramble("scriptsjava", "javascripts"), true);
            testing(Kata.kata__5_.Scramblies.Scramble("javscripts", "javascript"), false);
            testing(Kata.kata__5_.Scramblies.Scramble("aabbcamaomsccdd", "commas"), true);
            testing(Kata.kata__5_.Scramblies.Scramble("commas", "commas"), true);
            testing(Kata.kata__5_.Scramblies.Scramble("sammoc", "commas"), true);
        }
    }
}
