using System;

/// <summary>
/// A Queue class
/// </summary>
/// <typeparam name="T">The type the Queue contains</typeparam>
class Queue<T>
{
    /// <summary>
    /// The first node (head) in the Queue
    /// </summary>
    /// <value>gets/sets the head Node</value>
    public Node head { get; set; }

    /// <summary>
    /// The last node (tail) in the Queue
    /// </summary>
    /// <value>gets/sets the tail Node</value>
    public Node tail { get; set; }

    /// <summary>
    /// The number of nodes in the Queue
    /// </summary>
    /// <value>gets/sets the count int</value>
    public int count { get; set; }

    /// <summary>
    /// Get the type that the Queue contains
    /// </summary>
    /// <returns>The type of the Queue</returns>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary>
    /// Adds a value to the end of the Queue
    /// </summary>
    /// <param name="value">The value to append, of type T</param>
    public void Enqueue(T value)
    {
        count++;

        if (head == null)
        {
            head = new Node(value);
            tail = head;
            return;
        }

        tail.next = new Node(value);
        tail = tail.next;
        return;
    }

    /// <summary>
    /// Gets the number of items in the Queue
    /// </summary>
    /// <returns>The number of items in the Queue, as an int</returns>
    public int Count()
    {
        return this.count;
    }

    /// <summary>
    /// A node to store data for the Queue
    /// </summary>
    public class Node
    {
        /// <summary>
        /// The value that the node contains
        /// </summary>
        /// <value>The value property gets/sets the value property of type T</value>
        public T value { get; set; }

        /// <summary>
        /// The next node in the linked list
        /// </summary>
        /// <value>The next property gets/sets the next property of type Node</value>
        public Node next { get; set; }

        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
    }
}