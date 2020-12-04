using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> llNode;

        // Finding where to insert the node
        foreach (int nodeValue in myLList)
        {
            if (n <= nodeValue)
            {
                llNode = myLList.Find(nodeValue);
                myLList.AddBefore(llNode, n);
                return llNode;
            }
        }

        // Getting here means the new node will be placed at the end of the list
        llNode = new LinkedListNode<int>(n);
        myLList.AddLast(n);

        return llNode;
    }
}
