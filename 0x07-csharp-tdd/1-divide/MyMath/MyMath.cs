using System;

namespace MyMath
{
    /// <summary>
    /// Class for matrix math functions
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// Divides each element in a matrix by a number.
        /// </summary>
        /// <param name="matrix">A matrix of integers.</param>
        /// <param name="num">The number to divide each element by.</param>
        /// <returns>A new matrix with the resulting quotients.</returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (num == 0)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }

            if (matrix == null)
            {
                return null;
            }

            int[,] newMat = (int[,])matrix.Clone();

            for (int i = 0; i < newMat.GetLength(0); i++)
            {
                for (int j = 0; j < newMat.GetLength(1); j++)
                {
                    newMat[i, j] /= num;
                }
            }

            return newMat;
        }
    }
}
