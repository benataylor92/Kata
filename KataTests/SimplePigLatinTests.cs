using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace KataTests
{
    [TestFixture]
    public class SimplePigLatinTests
    {
        [Test]
        public void KataTests()
        {
            Assert.AreEqual("igPay atinlay siay oolcay", Kata.kata__5_.SimplePigLatin.PigIt("Pig latin is cool"));
            Assert.AreEqual("hisTay siay ymay tringsay", Kata.kata__5_.SimplePigLatin.PigIt("This is my string"));
        }
    }
}
