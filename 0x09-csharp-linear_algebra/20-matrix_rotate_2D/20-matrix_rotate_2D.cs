using System;

class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        if (matrix.Rank != 2 || matrix.GetLength(1) != 2)
            return new double[1,1] { {-1} };

        double cos = Math.Cos(angle);
        double sin = Math.Sin(angle);

        double[,] rotMat = new double[2,2] {
            {cos, -sin},
            {sin, cos}
        };

        double[,] res = new double[matrix.GetLength(0), 2];

        for (uint i = 0; i < matrix.GetLength(0); i++)
        {
            res[i, 0] = Math.Round(matrix[i, 0] * cos - matrix[i, 1] * sin, 2);
            res[i, 1] = Math.Round(matrix[i, 0] * sin + matrix[i, 1] * cos, 2);
        }

        return res;
    }
}