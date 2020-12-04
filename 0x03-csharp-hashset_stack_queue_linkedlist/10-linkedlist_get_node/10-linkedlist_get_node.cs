using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int index = 0;

        foreach (int nodeValue in myLList)
        {
            if (index == n)
                return nodeValue;
            index++;
        }

        return 0;
    }
}
