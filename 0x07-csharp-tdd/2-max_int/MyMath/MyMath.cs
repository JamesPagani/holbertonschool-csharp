using System;
using System.Collections.Generic;

namespace MyMath
{
    ///<summary>Operations that can be done on numbers.</summary>
    public class Operations
    {
        ///<summary>Finds the maximum integer in a list of integers.</summary>

        public static int Max(List<int> nums)
        {
            int maxNum;

            if (nums == null || nums.Count == 0)
                return 0;

            maxNum = nums[0];
            foreach (int num in nums)
            {
                if (num > maxNum)
                    maxNum = num;
            }

            return maxNum;
        }
    }
}
