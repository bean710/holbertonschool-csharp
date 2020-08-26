using System;

class MatrixMath
{
    public static double[,] Transpose(double[,] matrix)
    {
        double[,] result = new double[matrix.GetLength(1), matrix.GetLength(0)];

        for (uint i = 0; i < matrix.GetLength(0); i++)
        {
            for (uint j = 0; j < matrix.GetLength(1); j++)
                result[j, i] = matrix[i, j];
        }

        return result;
    }
}