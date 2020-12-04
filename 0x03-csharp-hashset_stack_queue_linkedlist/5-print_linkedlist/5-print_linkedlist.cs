using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> newLList = new LinkedList<int>();

        if (size > 0)
        {
            for (int i = 0; i < size; i++)
                newLList.AddLast(i);
            foreach(int item in newLList)
                Console.WriteLine(item);
        }

        return newLList;
    }
}
