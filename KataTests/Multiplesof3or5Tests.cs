using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace KataTests
{
    [TestFixture()]
    public class Multiplesof3or5Tests
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(23, Kata.Multiplesof3or5.Solution(10));
        }
    }
}
