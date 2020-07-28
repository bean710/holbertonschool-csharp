using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> node = myLList.First;
        int i = 0;

        while (node != null)
        {
            if (i == index)
            {
                myLList.Remove(node);
            }

            node = node.Next;
            i++;
        }
    }
}