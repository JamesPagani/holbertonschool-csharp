using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        if (myList == null || myList.Count == 0)
        {
            Console.WriteLine("List is empty");
            return -1;
        }
        else
        {
            // I love me some good Cheese
            myList.Sort();
            myList.Reverse();
        }
        return myList[0];
    }
}
