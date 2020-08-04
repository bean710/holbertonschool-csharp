using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Max_PositiveInts_ReturnsMax()
        {
            List<int> input = new List<int> {1, 2, 3, 4, 5};

            int output = MyMath.Operations.Max(input);

            Assert.AreEqual(5, output);
        }

        [Test]
        public void Max_NegativeInts_ReturnsMax()
        {
            List<int> input = new List<int> {-1, -2, -3, -4, -5};

            int output = MyMath.Operations.Max(input);

            Assert.AreEqual(-1, output);
        }

        [Test]
        public void Max_EmptyList_ReturnsZero()
        {
            List<int> input = new List<int>();

            int output = MyMath.Operations.Max(input);

            Assert.AreEqual(0, output);
        }

        [Test]
        public void Max_NullList_ReturnsZero()
        {
            List<int> input = null;

            int output = MyMath.Operations.Max(input);

            Assert.AreEqual(0, output);
        }
    }
}