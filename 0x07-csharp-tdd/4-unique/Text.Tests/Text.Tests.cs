using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(0, "abbbbb")]
        [TestCase(1, "babbbb")]
        [TestCase(3, "abcdabc")]
        public void UniqueChar_NormalString_ReturnsIndex(int expected, string input)
        {
            int output = Text.Str.UniqueChar(input);

            Assert.AreEqual(expected, output);
        }

        [TestCase("aabbccdd")]
        [TestCase("")]
        [TestCase(null)]
        public void UniquChar_NoUnique_ReturnsNegativeOne(string input)
        {
            int output = Text.Str.UniqueChar(input);

            Assert.AreEqual(-1, output);
        }
    }
}