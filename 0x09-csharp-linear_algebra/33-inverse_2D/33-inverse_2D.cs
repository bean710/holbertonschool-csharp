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
                ret[i, j] = Math.Round(matrix[i, j] * scalar, 2);
        }

        return ret;
    }

    public static double Determinant(double[,] matrix)
    {
        if (matrix.Rank != 2 || matrix.GetLength(0) != matrix.GetLength(1) ||
            matrix.GetLength(0) < 2 || matrix.GetLength(0) > 3)
            return -1;

        if (matrix.GetLength(0) == 2)
        {
            return Math.Round(matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0], 2);
        }
        else
        {
            double sum = 0;
            sum += matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[2, 1] * matrix[1, 2]);
            sum -= matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[2, 0] * matrix[1, 2]);
            sum += matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[2, 0] * matrix[1, 1]);
            return Math.Round(sum, 2);
        }
    }

    public static double[,] Inverse2D(double[,] matrix)
    {
        if (matrix.Rank != 2 || matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[1, 1] { {-1} };
    
        double det = Determinant(matrix);
        if (det == 0 || det == -1)
            return new double[1, 1] { {-1} };

        double detInv = 1 / det;

        return MultiplyScalar(new double[,] {
            { matrix[1, 1], -matrix[0, 1] },
            { -matrix[1, 0], matrix[0, 0] }
        }, detInv);
    }
}