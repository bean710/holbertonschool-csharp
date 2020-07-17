using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[][] jaggedArray = new int[3][];

        jaggedArray[0] = Enumerable.Range(0, 4).ToArray();
        jaggedArray[1] = Enumerable.Range(0, 7).ToArray();
        jaggedArray[2] = Enumerable.Range(0, 2).ToArray();

        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                if (j == 0)
                {
                    Console.Write(jaggedArray[i][j]);
                }
                else
                {
                    Console.Write($" {jaggedArray[i][j]}");
                }
            }
            Console.WriteLine("");
        }
    }
}