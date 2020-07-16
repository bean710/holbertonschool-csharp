using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] arr2d = new int[5, 5];

        arr2d[2, 2] = 1;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (j == 4)
                {
                    Console.WriteLine(arr2d[i, j]);
                }
                else
                {
                    Console.Write($"{arr2d[i, j]} ");
                }
            }
        }
    }
}