using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Modules.Arrays.MaxConsecutiveOnes
{
    /*
     * Max Consecutive Ones
     * 
     * Given a binary array nums, return the maximum number of consecutive 1's in the array.
     * 
     * https://leetcode.com/explore/learn/card/array-and-string/205/array-two-pointer-technique/1301/
     */
    public class Solution
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            var highest = 0;
            var count = 0;

            for (var i = 0; i < nums.Length; ++i)
            {
                if (nums[i] == 1)
                {
                    ++count;
                    highest = Math.Max(highest, count);
                }
                else
                {
                    count = 0;
                }
            }

            return highest;
        }
    }
}
