using System;
using System.Collections.Generic;

class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        int llistSum = 0;

        foreach (int item in myLList)
            llistSum += item;

        return llistSum;
    }
}
