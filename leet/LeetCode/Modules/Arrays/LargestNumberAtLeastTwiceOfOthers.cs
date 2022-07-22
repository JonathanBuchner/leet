using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Modules.Arrays.LargestNumberAtLeastTwiceOfOthers
{
    /*
     * Largest Number At Least Twice of Others
     * 
     * You are given an integer array nums where the largest integer is unique.  Determine whether the largest element in the array is at least twice as much as every other number in the array. If it is, return the index of the largest element, or return -1 otherwise.
     * 
     * https://leetcode.com/explore/learn/card/array-and-string/201/introduction-to-array/1147/
     */
    public class Solution
    {
        public int DominantIndex(int[] nums)
        {

            if (nums.Length < 1)
            {
                return -1;
            }

            var index = 0;
            var isDouble = true;

            for (var i = 1; i < nums.Length; ++i)
            {
                if (nums[index] < nums[i])
                {
                    isDouble = nums[i] >= nums[index] * 2;
                    index = i;
                }
                else if (nums[i] * 2 > nums[index])
                {
                    isDouble = false;
                }
            }

            return isDouble ? index : -1;
        }
    }
}
