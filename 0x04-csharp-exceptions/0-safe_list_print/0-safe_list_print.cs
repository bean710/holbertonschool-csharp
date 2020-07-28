using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int printed = 0;

        for (; printed < n; printed++)
        {
            try
            {
                Console.WriteLine(myList[printed]);
            }
            catch
            {
                return printed;
            }
        }

        return printed;
    }
}