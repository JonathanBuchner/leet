using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Modules.Arrays
{
    /*
     * Minimum Size Subarray Sum
     * 
     * Given an array of positive integers nums and a positive integer target, return the minimal length of a contiguous subarray [numsl, numsl+1, ..., numsr-1, numsr] of which the sum is greater than or equal to target. If there is no such subarray, return 0 instead.
     * 
     * https://leetcode.com/explore/learn/card/array-and-string/205/array-two-pointer-technique/1299/
     */
    public class Solution
    {
        public int MinSubArrayLen(int target, int[] nums)
        {
            var l = 0;
            var total = 0;
            var least = Int32.MaxValue;

            for (var i = 0; i < nums.Length; ++i)
            {
                total += nums[i];

                while (total >= target)
                {
                    least = Math.Min(least, i - l + 1);

                    if (least == 1)
                    {
                        return 1;
                    }

                    total -= nums[l];
                    ++l;
                }
            }

            return least == Int32.MaxValue ? 0 : least;
        }
    }
}
