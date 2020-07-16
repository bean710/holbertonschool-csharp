using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        int[] ret = new int[size];

        for (int i = 0; i < ret.Length; i++)
        {
            ret[i] = i;

            if (i == ret.Length - 1)
            {
                Console.Write(ret[i]);
            }
            else
            {
                Console.Write($"{ret[i]} ");
            }
        }
        Console.WriteLine("");

        return ret;
    }
}
