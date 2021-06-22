using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.TwoSum
{
    public class Solution
    {
        /* Two Sum
         * Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
         * You may assume that each input would have exactly one solution, and you may not use the same element twice.
         * You can return the answer in any order.
         * 
         * https://leetcode.com/explore/interview/card/microsoft/30/array-and-strings/173/
         */
        public int[] TwoSum(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > target) continue;

                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target) return new int[] { i, j };
                }
            }

            throw new Exception("No answer");
        }
    }
}
