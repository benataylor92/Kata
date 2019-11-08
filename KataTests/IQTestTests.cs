using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace KataTests
{
    [TestFixture]
    public class IQTestTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(3, Kata.Kata__6_.IQTest.Test("2 4 7 8 10"));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(1, Kata.Kata__6_.IQTest.Test("1 2 2"));
        }
    }
}
