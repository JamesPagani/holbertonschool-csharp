using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        HashSet<int> tmpSet = new HashSet<int>(list1);
        List<int> symDiffList;

        tmpSet.SymmetricExceptWith(list2);
        symDiffList = new List<int>(tmpSet);
        symDiffList.Sort();
        return symDiffList;
    }
}
