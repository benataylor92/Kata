using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace KataTests
{
    [TestFixture]
    public class StopSpinningMyWordsTests
    {
        [Test]
        public static void Test1()
        {
            Assert.AreEqual("emocleW", Kata.Kata__6_.StopSpinningMyWords.SpinWords("Welcome"));
        }

        [Test]
        public static void Test2()
        {
            Assert.AreEqual("Hey wollef sroirraw", Kata.Kata__6_.StopSpinningMyWords.SpinWords("Hey fellow warriors"));
        }

        [Test]
        public static void Test3()
        {
            Assert.AreEqual("This is a test", Kata.Kata__6_.StopSpinningMyWords.SpinWords("This is a test"));
        }

        [Test]
        public static void Test4()
        {
            Assert.AreEqual("This is rehtona test", Kata.Kata__6_.StopSpinningMyWords.SpinWords("This is another test"));
        }

        [Test]
        public static void Test5()
        {
            Assert.AreEqual("You are tsomla to the last test", Kata.Kata__6_.StopSpinningMyWords.SpinWords("You are almost to the last test"));
        }

        [Test]
        public static void Test6()
        {
            Assert.AreEqual("Just gniddik ereht is llits one more", Kata.Kata__6_.StopSpinningMyWords.SpinWords("Just kidding there is still one more"));
        }
    }
}
