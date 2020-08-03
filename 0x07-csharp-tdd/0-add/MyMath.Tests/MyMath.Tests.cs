using NUnit.Framework;

namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(-2, -2)]
        [TestCase(-47, 12)]
        public void Add_Values_ReturnsSum(int a, int b)
        {
            int result = MyMath.Operations.Add(a, b);

            Assert.AreEqual(result, a + b);
        }
    }
}