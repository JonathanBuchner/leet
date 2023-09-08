using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Modules.Arrays.ArrayPartitionI
{
    /*
     * Array Partition I
     * 
     * Given an integer array nums of 2n integers, group these integers into n pairs (a1, b1), (a2, b2), ..., (an, bn) such that the sum of min(ai, bi) for all i is maximized. Return the maximized sum.
     * 
     * https://leetcode.com/explore/learn/card/array-and-string/205/array-two-pointer-technique/1154/
     */
    public class Solution
    {
        public int ArrayPairSum(int[] nums)
        {
            Array.Sort(nums);
            var total = 0;
            var i = 0;

            while (i < nums.Length)
            {
                total += nums[i];

                i += 2;
            }

            return total; ;
        }
    }
}
