using System;

class Int
{
    public static void divide(int a, int b)
    {
        int answer = 0;
        try
        {
            answer = a / b;
        }
        catch
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine("{0} / {1} = {2}", a, b, answer);
        }
    }
}