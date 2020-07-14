using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 100; i++)
        {
            string text = "";

            if (i % 3 == 0)
                text += "Fizz";
            if (i % 5 == 0)
                text += "Buzz";

            if (text == "")
                text = i.ToString();

            if (i == 0)
                Console.Write(text);
            else
                Console.Write(" " + text);
        }
        Console.WriteLine("");
    }
}
