using System;

class VectorMath
{
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length != vector2.Length || vector1.Length < 2 || vector2.Length >3)
            return -1;

        double ret = 0;

        for (uint i = 0; i < vector1.Length; i++)
            ret += vector1[i] * vector2[i];
        
        return ret;
    }
}