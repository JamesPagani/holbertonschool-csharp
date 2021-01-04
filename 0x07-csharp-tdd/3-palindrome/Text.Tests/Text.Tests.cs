using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [TestCase("racecar")]
        [TestCase("Civic")]
        [TestCase("lEveL")]
        public void SimplePalindromeWord(string input)
        {
            Assert.AreEqual(true, Str.IsPalindrome(input));
        }


        [TestCase("once")]
        [TestCase("Eraser")]
        [TestCase("Yo-Yo")]
        public void SimpleNonPalindromeWord(string input)
        {
            Assert.AreEqual(false, Str.IsPalindrome(input));
        }

        [Test]
        public void EmptyStringPalindrome()
        {
            Assert.AreEqual(true, Str.IsPalindrome(""));
        }

        [TestCase("A nut for a jar of tuna.")]
        [TestCase("Amore, Roma.")]
        public void PalindromeSentence(string sentence)
        {
            Assert.AreEqual(true, Str.IsPalindrome(sentence));
        }

        [TestCase("Al lets Della call Ed \"Stella.\"")]
        [TestCase("Was it a car or a cat I saw?")]
        public void PalindromeSentenceWithPunctuation(string sentence)
        {
            Assert.AreEqual(true, Str.IsPalindrome(sentence));
        }
    }
}