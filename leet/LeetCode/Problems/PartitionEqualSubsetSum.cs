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
        private int total;
        private int subtotal;
        private bool[][] dynamicProgrammingTable;
        public bool CanPartition(int[] nums)
        {
            Setup(nums);
            
            if (total == 0 || total % 2 != 0) return false;
            
            for(var i = 1; i < dynamicProgrammingTable.Length; i++)
            {
                var curr = nums[i - 1];
                for(int j = 0; j < dynamicProgrammingTable[i].Length; j++)
                {
                    dynamicProgrammingTable[i][j] = j < curr
                        ? dynamicProgrammingTable[i - 1][j]
                        : dynamicProgrammingTable[i - 1][j] || dynamicProgrammingTable[i - 1][j - curr];

                }
            }

            return dynamicProgrammingTable[nums.Length][subtotal];
        }
        private void Setup(int[] nums)
        {
            foreach (var num in nums)
            {
                total += num;
            }
            subtotal = total / 2;
            dynamicProgrammingTable = new bool[nums.Length + 1][];
            for (var i = 0; i < dynamicProgrammingTable.Length ; i++)
            {
                dynamicProgrammingTable[i] = new bool[subtotal + 1];
            }
            dynamicProgrammingTable[0][0] = true;
        }
    }
}
