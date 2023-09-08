using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Modules.Arrays.FindPivotIndex
{
    /*
     * Find Pivot Index
     * 
     * Given an array of integers nums, calculate the pivot index of this array.
     * 
     * https://leetcode.com/explore/learn/card/array-and-string/201/introduction-to-array/1144/
     */
    public class Solution
    {
        public int PivotIndex(int[] nums)
        {

            var left = 0;
            var right = nums.Sum();

            for (var i = 0; i < nums.Length; i++)
            {
                if (i > 0)
                {
                    left += nums[i - 1];
                }

                right -= nums[i];

                if (left == right)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
