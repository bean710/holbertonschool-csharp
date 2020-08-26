using System;

class VectorMath
{
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if (vector1.Length != vector2.Length || vector1.Length < 2 || vector1.Length > 3)
        {
            double[] ret = new double[vector1.Length];

            for (uint i = 0; i < vector1.Length; i++)
            {
                ret[i] = vector1[i] + vector2[i];
            }

            return ret;
        }
    }
}