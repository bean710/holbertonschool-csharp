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
                
                ret[i, j] = sum;
            }
        }

        return ret;
    }
}