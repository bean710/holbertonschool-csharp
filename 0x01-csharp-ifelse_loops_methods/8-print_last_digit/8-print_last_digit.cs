using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        int lastDig = Math.Abs(number % 10);
        Console.Write(lastDig);
        return lastDig;
    }
}
