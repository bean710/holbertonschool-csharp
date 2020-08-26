using System;

class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        if (matrix.Rank != 2 || matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[1,1] { {-1} };

        double[,] ret = new double[2,2];

        double cos = Math.Cos(angle);
        double sin = Math.Sin(angle);

        ret[0, 0] = Math.Round(cos * matrix[0, 0], 2);
        ret[0, 1] = Math.Round(-sin * matrix[0, 1], 2);
        ret[1, 0] = Math.Round(sin * matrix[1, 0], 2);
        ret[1, 1] = Math.Round(cos * matrix[1, 1], 2);

        return ret;
    }
}