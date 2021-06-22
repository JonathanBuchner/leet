using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leet.LeetCode.TwoSum
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
            var dictionary = new Dictionary<int, int>();
            
            for (var i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];

                if (dictionary.ContainsKey(diff))
                {
                    return new int[] { dictionary[diff], i };
                }
                else
                {
                    dictionary.Add(nums[i], i);
                }
            }

            throw new Exception("No answer");
        }
    }
}
