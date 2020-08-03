using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("abcba")]
        [TestCase("BananasananaB")]
        [TestCase("fubaRabuf")]
        [TestCase("")]
        [TestCase("Beneb")]
        [TestCase("Ben!neB")]
        [TestCase("f o o oof")]
        [TestCase("A man, a plan, a canal: Panama.")]
        public void IsPalindrome_NormalString_ReturnsTrue(string input)
        {
            bool result = Text.Str.IsPalindrome(input);

            Assert.IsTrue(result);
        }

        [TestCase("Ben Keener")]
        [TestCase("AbCd")]
        public void IsPalindrome_NormalString_ReturnsFalse(string input)
        {
            bool result = Text.Str.IsPalindrome(input);

            Assert.IsFalse(result);
        }
    }
}