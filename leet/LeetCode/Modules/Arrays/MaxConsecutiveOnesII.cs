using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Modules.Arrays.MaxConsecutiveOnesII
{
    public class Solution
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            var right = 0;
            var left = 0;
            var highest = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if(nums[i] == 1)
                {
                    right++;
                }
                else
                {
                    left = 1 + right;
                    right = 0;
                }

                highest = Math.Max(highest, right + left);
            }

            return highest ;
        }
    }
}
