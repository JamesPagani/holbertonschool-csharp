using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        if (aQueue == null)
            return aQueue;

        // Print the number of items in the queue
        Console.WriteLine("Number of items: {0}", aQueue.Count);

        // Print the item at the top of the queue without removing it
        Console.WriteLine("First item: {0}", aQueue.Peek());

        // Add the new item to the queue
        aQueue.Enqueue(newItem);

        // Print if the queue has the element in search
        Console.WriteLine("Queue contains \"{0}\": {1}", search, aQueue.Contains(search));

        // If the item is there, dequeue items up to (and including) the item
        while (aQueue.Dequeue() != search);

        return aQueue;
    }
}
