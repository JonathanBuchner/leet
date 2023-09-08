using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Modules.HashTables.SingleNumber
{
    /*
     * Single Number
     * 
     * Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
     * 
     * https://leetcode.com/explore/learn/card/hash-table/183/combination-with-other-algorithms/1176/
     */
    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            int result = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                var number = nums[i];
                result = result ^ number;
            }

            return result;
        }
    }
}
