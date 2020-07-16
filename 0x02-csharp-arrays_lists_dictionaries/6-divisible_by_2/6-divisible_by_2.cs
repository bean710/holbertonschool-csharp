using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> ret = new List<bool>();

        foreach (int val in myList)
        {
            ret.Add(val % 2 == 0);
        }

        return ret;
    }
}