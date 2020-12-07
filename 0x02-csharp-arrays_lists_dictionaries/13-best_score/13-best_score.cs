using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        KeyValuePair<string, int> highestScore = new KeyValuePair<string, int>("None", -1);

        foreach (KeyValuePair<string, int> dictItem in myList)
        {
            if (dictItem.Value > highestScore.Value)
            {
                highestScore = dictItem;
            }
        }

        return highestScore.Key;
    }
}
