using System;
using System.Linq;

/// <summary>
/// Contains Vector Math methods
/// </summary>
class VectorMath
{
    /// <summary>
    /// Multiplies a vector by a scalar
    /// </summary>
    /// <param name="vector">A vector of doubles</param>
    /// <param name="scalar">The scalar to multiply the vector by</param>
    /// <returns>A new vector </returns>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length < 2 || vector.Length > 3)
            return new double[1] {-1};

        return (from num in vector select num * scalar);
    }
}