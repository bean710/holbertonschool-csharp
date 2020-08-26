using System;

class MatrixMath
{
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        if (matrix.Rank != 2 || matrix.GetLength(1) != 2 || (direction != 'x' && direction != 'y'))
            return new double[,] { {-1} };

        double x = 0, y = 0;

        if (direction == 'x')
            x = factor;
        else
            y = factor;

        double[,] result = new double[matrix.GetLength(0), 2];

        for (uint i = 0; i < matrix.GetLength(0); i++)
        {
            result[i, 0] = matrix[i, 0] + (x * matrix[i, 1]);
            result[i, 1] = (y * matrix[i, 0]) + matrix[i, 1];
        }

        return result;
    }
}