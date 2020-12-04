using System;
using System.Collections.Generic;
class List
{
    public static int Sum(List<int> myList)
    {
        int uniqSum = 0;

        if (myList != null)
        {
            HashSet<int> uniqList = new HashSet<int>(myList);

            foreach (int num in uniqList)
            {
                uniqSum += num;
            }
        }

        return uniqSum;
    }
}
