using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.LongestIncreasingSubsequence
{
    /*
     * Longest Increasing Subsequence
     * 
     * Given an integer array nums, return the length of the longest strictly increasing subsequence.
     * 
     * https://leetcode.com/problems/longest-increasing-subsequence/
     */
    public class Solution
    {
        public int LengthOfLIS(int[] nums)
        {
            var list = new List<int>();
            list.Add(nums[0]);

            for(var i = 1; i < nums.Length; i++)
            {
                if (nums[i] > list[list.Count - 1])
                {
                    list.Add(nums[i]);
                }
                else
                {
                    ReplaceLowest(list, nums[i]);
                }
            }

            return list.Count;
        }

        public void ReplaceLowest(List<int> list, int num)
        {
            var left = 0;
            var right = list.Count - 1;

            while (left < right)
            {
                var mid = (left + right) / 2;

                if (list[mid] == num)
                {
                    return;
                }

                if (list[mid] > num)
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }

            }

            list[left] = num;
        }
    }
}
