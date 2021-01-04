using System;

namespace Text
{
    ///<summary>Operations on strings.</summary>
    public class Str
    {
        ///<summary>Find if a given string is a palindomre.</summary>
        ///<remark>
        ///This function assumes the input contains only ASCII characters.
        ///</remark>
        public static bool IsPalindrome(string s)
        {
            int i, j;
            string lowerString;

            //Turn it to lowercase
            lowerString = s.ToLower();

            //Check if it is a palindrome
            i = 0;
            j = lowerString.Length - 1;

            while (i < j)
            {
                while ((int)lowerString[j] < 97 || (int)lowerString[j] > 122)    
                {
                    j--;
                }
                while ((int)lowerString[i] < 97 || (int)lowerString[i] > 122)
                {    
                    i++;
                }
                Console.WriteLine("{0} - {1}", lowerString[i], lowerString[j]);
                Console.WriteLine(lowerString[i] == lowerString[j]);
                if (lowerString[i] != lowerString[j])
                    return false;

                i++;
                j--;
            }
            return true;
        }
    }
}