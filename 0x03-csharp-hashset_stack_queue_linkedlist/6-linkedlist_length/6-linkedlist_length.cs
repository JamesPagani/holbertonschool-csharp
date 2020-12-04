using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int nodeCount = 0;

        foreach (int item in myLList)
            nodeCount++;

        return nodeCount;
    }
}
