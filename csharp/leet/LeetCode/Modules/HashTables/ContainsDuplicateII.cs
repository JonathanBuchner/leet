using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Modules.HashTables.ContainsDuplicateII
{
    /*
     * Contains Duplicate II
     * 
     * Given an integer array nums and an integer k, return true if there are two distinct indices i and j in the array such that nums[i] == nums[j] and abs(i - j) <= k.
     * 
     * https://leetcode.com/explore/learn/card/hash-table/184/comparison-with-other-data-structures/1121/
     */
    public class Solution
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var dict = new Dictionary<int, int>(); // Key is number, Value is indice.

            for (var i = 0; i < nums.Length; i++)
            {
                if(dict.ContainsKey(nums[i]))
                {

                    if(i - dict[nums[i]] <= k)
                    {
                        return true;
                    }
                    else
                    {
                        dict[nums[i]] = i;
                    }
                }
                else
                {
                    dict.Add(nums[i], i);
                }
            }

            return false;
        }
    }
}
