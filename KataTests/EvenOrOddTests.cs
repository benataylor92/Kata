using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    [TestFixture]
    public class EvenOrOddTests
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual("Even", Kata.Test.EvenOrOdd(2));
            Assert.AreEqual("Odd", Kata.Test.EvenOrOdd(1));
            Assert.AreEqual("Even", Kata.Test.EvenOrOdd(0));
            Assert.AreEqual("Odd", Kata.Test.EvenOrOdd(7));
            Assert.AreEqual("Odd", Kata.Test.EvenOrOdd(-1));
        }
    }
}
