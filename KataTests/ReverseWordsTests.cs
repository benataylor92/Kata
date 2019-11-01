using Kata;
using NUnit.Framework;

namespace KataTests
{

    [TestFixture]
    public class ReverseWord
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual("sihT si na !elpmaxe", Kata.Kata.ReverseWords("This is an example!"));
        }
    }
}