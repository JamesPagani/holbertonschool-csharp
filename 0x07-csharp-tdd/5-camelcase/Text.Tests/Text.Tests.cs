using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void EmtpyString()
        {
            Assert.AreEqual(0, Str.CamelCase(""));
        }

        [TestCase("juice")]
        [TestCase("nice")]
        [TestCase("responsible")]
        public void OneWord(string word)
        {
            Assert.AreEqual(1, Str.CamelCase(word));
        }

        [Test]
        public void MultipleWords()
        {
            Assert.AreEqual(5, Str.CamelCase("batmanReturnOfTheJoker"));
            Assert.AreEqual(4, Str.CamelCase("cSharpIsCool"));
            Assert.AreEqual(3, Str.CamelCase("elBananeroSapeeeeeeeee"));
            Assert.AreEqual(2, Str.CamelCase("cammelCase"));
        }
    }
}