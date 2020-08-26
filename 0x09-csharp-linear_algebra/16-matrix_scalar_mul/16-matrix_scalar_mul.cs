using System;

class MatrixMath
{
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if (matrix.Rank != 2 || matrix.GetLength(0) != matrix.GetLength(1) ||
            matrix.GetLength(0) < 2 || matrix.GetLength(0) > 3)
            return new double[1,1] { {-1} };

        double[,] ret = new double[matrix.GetLength(0), matrix.GetLength(1)];

        for (uint i = 0; i < matrix.GetLength(0); i++)
        {
            for (uint j = 0; j < matrix.GetLength(1); j++)
                ret[i, j] = matrix[i, j] * scalar;
        }

        return ret;
    }
}