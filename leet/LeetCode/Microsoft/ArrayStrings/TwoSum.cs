using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leet.LeetCode.Microsoft.ArrayStrings.TwoSum
{
    /* Two Sum
    * Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    * You may assume that each input would have exactly one solution, and you may not use the same element twice.
    * You can return the answer in any order.
    * 
    * https://leetcode.com/explore/interview/card/microsoft/30/array-and-strings/173/
    */
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            return SolutionTwo(nums, target);
        }

        private int SolutionOne(int[] nums, int target)
        {
            throw new NotImplementedException();
        }

        private int[] SolutionTwo(int[] nums, int target)
        {
            var result = new int[2];
            var dict = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    result[0] = dict[nums[i]];
                    result[1] = i;

                    return result;
                }

                var answer = target - nums[i];
                dict.TryAdd(answer, i);
            }

            // This should never be hit based on problem parameters, but added to make sure project builds.    
            return result;
        }
    }
}