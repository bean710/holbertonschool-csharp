using System;

/// <summary>
/// Contains vector math methods
/// </summary>
class VectorMath
{
    /// <summary>
    /// Gets the sum of two vectors
    /// </summary>
    /// <param name="vector1">First vector</param>
    /// <param name="vector2">Second vector</param>
    /// <returns>The sum of the vectors</returns>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if (vector1.Length != vector2.Length || vector1.Length < 2 || vector1.Length > 3)
        {
            return new double[1] {-1};
        }

        double[] ret = new double[vector1.Length];

        for (uint i = 0; i < vector1.Length; i++)
        {
            ret[i] = vector1[i] + vector2[i];
        }

        return ret;
    }
}