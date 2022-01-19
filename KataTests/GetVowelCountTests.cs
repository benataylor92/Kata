using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    [TestFixture]
    public class GetVowelCountTests
    {
        [Test]
        public void TestCase1()
        {
            Assert.AreEqual(5, Kata.Test1.GetVowelCount("abracadabra"), "Nope!");
            Assert.AreEqual(8, Kata.Test1.GetVowelCount("aewreioewerujkhdsfjkshfjk"), "Nope!");
        }
    }
}
