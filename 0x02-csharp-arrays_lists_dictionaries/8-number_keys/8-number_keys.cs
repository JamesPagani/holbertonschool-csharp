using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int keys = 0;
        foreach (KeyValuePair<string, string> item in myDict)
        {
            keys++;
        }
        return keys;
    }
}
