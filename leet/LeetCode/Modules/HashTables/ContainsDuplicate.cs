using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Modules.HashTables.ContainsDuplicate
{
    /*
     *  Contains Duplicate
     * 
     * Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
     * 
     * https://leetcode.com/explore/learn/card/hash-table/183/combination-with-other-algorithms/1112/
     */
    public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            var set = new HashSet<int>();

            for(var i = 0; i < nums.Length; i++)
            {
                if (!set.Add(nums[i])) return true;
            }

            return false;
        }
    }
}
