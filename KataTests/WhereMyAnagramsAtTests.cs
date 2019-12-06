using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace KataTests
{
    [TestFixture]
    public class WhereMyAnagramsAtTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(new List<string> { "a" }, Kata.kata__5_.WhereMyAnagramsAt.Anagrams("a", new List<string> { "a", "b", "c", "d" }));
            Assert.AreEqual(new List<string> { "carer", "arcre", "carre" }, Kata.kata__5_.WhereMyAnagramsAt.Anagrams("racer", new List<string> { "carer", "arcre", "carre", "racrs", "racers", "arceer", "raccer", "carrer", "cerarr" }));
        }
    }
}
