using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace KataTests
{
    [TestFixture]
    public class PersistentBuggerTests
    {
        [Test]
        public void Test1()
        {
            Console.WriteLine("****** Basic Tests");
            Assert.AreEqual(3, Kata.Kata__6_.PersistentBugger.Persistence(39));
            Assert.AreEqual(0, Kata.Kata__6_.PersistentBugger.Persistence(4));
            Assert.AreEqual(2, Kata.Kata__6_.PersistentBugger.Persistence(25));
            Assert.AreEqual(4, Kata.Kata__6_.PersistentBugger.Persistence(999));
        }
    }
}
