using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        // Can only perform these operations if we have a stack
        if (aStack == null)
            return aStack;

        // Print the number of items in aStack
        Console.WriteLine("Number of items: {0}", aStack.Count);

        // Print the item at the top of aStack without removing it
        if (aStack.Count > 0)
            Console.WriteLine("Top item: {0}", aStack.Peek());
        else
            Console.WriteLine("Stack is empty");

        // Print if aStack contains the item given in search
        Console.WriteLine("Stack contains {0}: {1}", search, aStack.Contains(search));

        // If aStack contains the item in search, remove all items up to (and including) search
        if (aStack.Contains(search))
            while(aStack.Pop() != search);

        // Add newItem to aStack
        aStack.Push(newItem);

        return aStack;
    }
}
