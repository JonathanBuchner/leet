using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.LongestConsecutiveSequence
{
    /*
     * Longest Consecutive Sequence
     * 
     * Given an unsorted array of integers nums, return the length of the longest consecutive elements sequence. You must write an algorithm that runs in O(n) time.
     * 
     * https://leetcode.com/problems/longest-consecutive-sequence/
     */
    public class Solution
    {
        public int LongestConsecutive(int[] nums)
        {
            var set = new HashSet<int>();
            var longest = 0;

            for (var i = 0; i < nums.Length; ++i)
            {
                set.Add(nums[i]);
            }

            for (var i = 0; i < nums.Length; ++i)
            {
                if (!set.Contains(nums[i] - 1))
                {
                    var curr = 1;
                    var next = nums[i] + 1;

                    while (set.Contains(next))
                    {
                        ++next;
                        ++curr;
                    }

                    longest = Math.Max(longest, curr);
                }
            }

            return longest;
        }
    }
}

