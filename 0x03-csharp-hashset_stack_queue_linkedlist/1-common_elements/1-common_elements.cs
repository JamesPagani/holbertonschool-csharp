using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        HashSet<int> tmpSet = new HashSet<int>(list1);
        List<int> intersectList;

        tmpSet.IntersectWith(list2);
        intersectList = new List<int>(tmpSet);
        intersectList.Sort();
        return intersectList;
    }
}
