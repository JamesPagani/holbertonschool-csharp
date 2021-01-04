using System;
using System.Collections.Generic;

namespace Text
{
    ///<summary>Operations that can be done to strings.</summary>
    public class Str
    {
        ///<summary>Return the index of the first unique character found.</summary>
        public static int UniqueChar(string s)
        {
            HashSet<char> letterSet = new HashSet<char>();
            int uniqueIndex = -1;

            for (int i = 0; i < s.Length; i++)
            {
                try
                {
                    if (letterSet.Contains(s[i]) && s[uniqueIndex] == s[i])
                    {
                        uniqueIndex = -1;
                    }
                    else
                    {
                        letterSet.Add(s[i]);
                        if (uniqueIndex < 0)
                        {
                            uniqueIndex = i;
                        }
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    continue;
                }
            }

            return uniqueIndex;
        }
    }
}
