using NUnit.Framework;
using System;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Divide_PositiveMatrixAndDivisor_ReturnsQuotient()
        {
            int[,] input = new int[,] {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            int [,] output = MyMath.Matrix.Divide(input, 2);

            int[,] expectedOutput = new int[,] {
                {0, 1, 1},
                {2, 2, 3},
                {3, 4, 4}
            };

            Assert.AreEqual(output, expectedOutput);
        }

        [Test]
        public void Divide_PositiveMatrixZeroDivisor_ReturnsNull()
        {
            int[,] input = new int[,] {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };
           
            int [,] output = MyMath.Matrix.Divide(input, 0);

            Assert.IsNull(output);
        }

        [Test]
        public void Divide_NullMatrixPositiveDivisor_ReturnsNull()
        {
            int [,] output = MyMath.Matrix.Divide(null, 2);

            Assert.IsNull(output);
        }

        [Test]
        public void Divide_NullMatrixAndZeroDivisor_ReturnsNull()
        {
            int [,] output = MyMath.Matrix.Divide(null, 0);

            Assert.IsNull(output);
        }
    }
}