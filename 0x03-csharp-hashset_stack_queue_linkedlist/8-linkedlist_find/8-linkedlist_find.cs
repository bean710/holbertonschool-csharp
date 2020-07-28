using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int onIndex = 0;

        foreach (int val in myLList)
        {
            if (val == value)
            {
                return onIndex;
            }

            onIndex++;
        }

        return -1;
    }
}