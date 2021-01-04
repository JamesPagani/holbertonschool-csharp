using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        public void NormalUnique(string word)
        {
            Assert.AreEqual(1, Str.UniqueChar("kiosk"));
        }


        [TestCase("make")]
        [TestCase("parlament")]
        [TestCase("potato")]
        public void UniqueAtBeginning(string word)
        {
            Assert.AreEqual(0, Str.UniqueChar(word));
        }

        [TestCase("eessrrt")]
        [TestCase("uunniiqqe")]
        [TestCase("idsoftwareidsoftwarex")]
        public void UniqueAtEnd(string word)
        {
            Assert.AreEqual(word.Length - 1, Str.UniqueChar(word));
        }

        [Test]
        public void EmptyString()
        {
            Assert.AreEqual(-1, Str.UniqueChar(""));
        }

        [TestCase("trapesosepart")]
        public void NoUnique(string word)
        {
            Assert.AreEqual(-1, Str.UniqueChar(word));
        }
    }
}