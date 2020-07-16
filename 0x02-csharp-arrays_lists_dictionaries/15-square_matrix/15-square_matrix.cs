using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        for (int i = 0; i < myMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < myMatrix.GetLength(1); j++)
            {
                myMatrix[i, j] = (int)Math.Pow(myMatrix[i, j], 2);
            }
        }

        return myMatrix;
    }
}