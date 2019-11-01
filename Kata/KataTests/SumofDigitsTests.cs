using System;
using System.Collections.Generic;
using System.Text;
using Kata;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace KataTests
{
    [TestFixture]
    public class SumofDigitsTests
    {
        private SumofDigits num;

        [SetUp]
        public void SettUp()
        {
            num = new SumofDigits();
        }

        [TearDown]
        public void TearDown()
        {
            num = null;
        }
        [Test]
        public void Tests()
        {
            Assert.AreEqual(7, num.DigitalRoot(16));
            Assert.AreEqual(6, num.DigitalRoot(456));
        }
    }
}
