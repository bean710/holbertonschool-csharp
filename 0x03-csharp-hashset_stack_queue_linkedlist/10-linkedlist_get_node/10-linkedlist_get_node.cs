using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int index = 0;

        foreach (int val in myLList)
        {
            if (index == n)
            {
                return val;
            }
            index++;
        }

        return 0;
    }
}