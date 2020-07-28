using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> node = myLList.First;

        while (node != null)
        {
            if (n >= node.Value && n < node.Next.Value)
            {
                return myLList.addAfter(node, n);
            }
        }

        return null;
    }
}