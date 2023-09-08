using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.WiggleSequence
{
    /*
     * Wiggle Subsequence
     * 
     * A wiggle sequence is a sequence where the differences between successive numbers strictly alternate between positive and negative. The first difference (if one exists) may be either positive or negative. A sequence with one element and a sequence with two non-equal elements are trivially wiggle sequences.
     * 
     * Given an integer array nums, return the length of the longest wiggle subsequence of nums.
     * 
     * https://leetcode.com/problems/wiggle-subsequence/
     */
    public class Solution
    {
        public int WiggleMaxLength(int[] nums)
        {
            if (nums.Length < 2)
            {
                return nums.Length;
            }

            var prevDiff = nums[1] - nums[0];
            var longest = prevDiff == 0 ? 1 : 2;

            for (var i = 1; i < nums.Length -1; ++i)
            {
                var diff = nums[i+1] - nums[i];
                
                if((diff > 0 && prevDiff <= 0) || (diff < 0 && prevDiff >= 0))
                {
                    longest++;
                    prevDiff = diff;
                }
                
            }

            return longest;
        }
    }
}
