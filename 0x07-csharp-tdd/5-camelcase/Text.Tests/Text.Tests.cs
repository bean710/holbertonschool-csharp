using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1, "foo")]
        [TestCase(2, "fooBar")]
        [TestCase(3, "fooBarBaz")]
        [TestCase(0, "")]
        [TestCase(0, ".!123")]
        [TestCase(1, ".!123bar")]
        [TestCase(2, ".!123barBaz")]
        public void CamelCase_NormalString_ReturnsNumberOfWords(int expected, string s)
        {
            int result = Text.Str.CamelCase(s);

            Assert.AreEqual(expected, result);
        }
    }
}