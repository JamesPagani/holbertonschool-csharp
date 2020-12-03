using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> divisibleByTwo = new List<bool>();

        if (myList != null)
        {
            foreach(int num in myList)
                divisibleByTwo.Add(num % 2 == 0 ? true : false);
        }
        return divisibleByTwo;
    }
}
