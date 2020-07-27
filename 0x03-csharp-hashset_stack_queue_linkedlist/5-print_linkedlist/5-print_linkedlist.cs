using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        size = size < 0 ? 0 : size;
        LinkedList<int> newList = new LinkedList<int>(Enumerable.Range(0, size));

        foreach (int val in newList)
        {
            Console.WriteLine(val);
        }

        return newList;
    }
}