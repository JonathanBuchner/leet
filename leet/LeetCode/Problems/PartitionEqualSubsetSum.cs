using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Problems.PartitionEqualSubsetSum
{
    /*
     * Partition Equal Subset Sum
     * 
     * Given a non-empty array nums containing only positive integers, find if the array can be partitioned into two subsets such that the sum of elements in both subsets is equal.
     * 
     * https://leetcode.com/problems/partition-equal-subset-sum/
     */
    public class Solution
    {
        private int[] nums;
        public bool CanPartition(int[] nums)
        {
            if (nums.Length == 0) return false;

            this.nums = nums;

            return Partition(0, 0);
        }

        private bool Partition(int index, int total)
        {
            if(nums.Length == index)
            {
                return total == 0;
            }

            var add = total + nums[index];
            var sub = total - nums[index];
            index++;

            return Partition(index, add) || Partition(index, sub); 
        }
    }
}
