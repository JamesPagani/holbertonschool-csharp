using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        if (myLList != null)
        {
            LinkedListNode<int> llNode = myLList.First;
            int indexTracker = 0;

            while (llNode != null)
            {
                if (indexTracker == index)
                {
                    myLList.Remove(llNode);
                    return;
                }
                indexTracker++;
                llNode = llNode.Next;
            }       
        }
    }
}
