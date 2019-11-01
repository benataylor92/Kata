using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.Net;

namespace KataTests
{
    public class UnluckyDaysTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(1, Kata.Kata1.UnluckyDays(1586));
            Assert.AreEqual(3, Kata.Kata1.UnluckyDays(1001));
            Assert.AreEqual(2, Kata.Kata1.UnluckyDays(2819));
            Assert.AreEqual(2, Kata.Kata1.UnluckyDays(2792));
            Assert.AreEqual(2, Kata.Kata1.UnluckyDays(2723));
            Assert.AreEqual(1, Kata.Kata1.UnluckyDays(1909));
            Assert.AreEqual(2, Kata.Kata1.UnluckyDays(1812));
            Assert.AreEqual(2, Kata.Kata1.UnluckyDays(1618));
            Assert.AreEqual(1, Kata.Kata1.UnluckyDays(2132));
            Assert.AreEqual(3, Kata.Kata1.UnluckyDays(2065));
        }
    }
}

