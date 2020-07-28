using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> node = myLList.First;
        int index = 0;
        while (node != null)
        {
            if (n == index)
            {
                return myLList.AddBefore(node, n);
            }

            node = node.Next;
            index++;
        }

        return null;
    }
}