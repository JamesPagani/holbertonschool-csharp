using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        int popValue = 0;

        if (myLList.Count == 0 || myLList == null)
            return popValue;

        foreach(int item in myLList)
        {
            popValue = item;
            break;
        }
        myLList.RemoveFirst();
        return popValue;
    }
}
