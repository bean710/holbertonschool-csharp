using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aQueue.Count);

        if (aQueue.Count == 0)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            Console.WriteLine("First item: {0}", aQueue.Peek());
        }

        bool foundSearch = aQueue.Contains(search);
        Console.WriteLine("Stack contains \"{0}\": {1}", search, foundSearch);

        if (foundSearch)
        {
            string val;
            do { 
                val = aQueue.Dequeue();
            }
            while (val != search);
        }

        aQueue.Enqueue(newItem);

        return aQueue;
    }
}