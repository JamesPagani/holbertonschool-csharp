using System;

namespace Text
{
    ///<summary>Operations that can be done to strings.</summary>
    public class Str
    {
        ///<summary>Find the amount of words in camel case style are in a string.</summary>
        ///<remark>In camel case, every word begins with a capital letter except the first one.</remark>
        public static int CamelCase(string s)
        {
            //Determines if there if the string isn't empty.
            int wordsFound = s.Length > 0 ? 1 : 0;

            foreach (char letter in s)
            {
                if ((int)letter >= 65 && (int)letter <= 90)
                {
                    wordsFound++;
                }
            }

            return wordsFound;
        }
    }
}
