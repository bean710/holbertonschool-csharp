using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 100; i++)
        {
            if (i == 99)
                Console.WriteLine(i);
            else
                Console.Write("{0:D2}, ", i);
        }
    }
}