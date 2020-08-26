using System;

class MatrixMath
{
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1.Rank != 2 || matrix2.Rank != 2 ||
            matrix1.GetLength(1) != matrix2.GetLength(0))
            return new double[1,1] { {-1} };
        
        double[,] ret = new double[matrix1.GetLength(0), matrix2.GetLength(1)];

        for (uint i = 0; i < ret.GetLength(0); i++)
        {
            for (uint j = 0; j < ret.GetLength(1); j++)
            {
                double sum = 0;

                for (uint k = 0; k < matrix2.GetLength(0); k++)
                    sum += matrix1[i, k] * matrix2[k, j];
                
                ret[i, j] = Math.Round(sum, 2);
            }
        }

        return ret;
    }

    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        if (matrix.Rank != 2 || matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[1,1] { {-1} };

        double cos = Math.Cos(angle);
        double sin = Math.Sin(angle);

        double[,] rotMat = new double[2,2] {
            {cos, -sin},
            {sin, cos}
        };

        return Multiply(rotMat, matrix);
    }
}