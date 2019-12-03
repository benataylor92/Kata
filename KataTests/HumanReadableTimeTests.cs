using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace KataTests
{
    [TestFixture]
    public class HumanReadableTimeTest
    {
        [Test]
        public void HumanReadableTest()
        {
            Assert.AreEqual("00:00:00", Kata.kata__5_.HumanReadableTime.GetReadableTime(0));
            Assert.AreEqual("00:00:05", Kata.kata__5_.HumanReadableTime.GetReadableTime(5));
            Assert.AreEqual("00:01:00", Kata.kata__5_.HumanReadableTime.GetReadableTime(60));
            Assert.AreEqual("23:59:59", Kata.kata__5_.HumanReadableTime.GetReadableTime(86399));
            Assert.AreEqual("99:59:59", Kata.kata__5_.HumanReadableTime.GetReadableTime(359999));
        }
    }
}
