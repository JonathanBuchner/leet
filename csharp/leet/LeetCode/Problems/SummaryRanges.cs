using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.SummaryRanges
{
    /*
     * Summary Ranges
     * 
     * You are given a sorted unique integer array nums.
     * 
     * https://leetcode.com/problems/summary-ranges/
     */
    public class Solution
    {
        public IList<string> SummaryRanges(int[] nums)
        {
            var list = new List<string>();
            var i = 0;

            while (i < nums.Length)
            {
                var k = i + 1;
                var streak = nums[i] + 1;

                while (k < nums.Length && nums[k] == streak)
                {
                    ++streak;
                    ++k;
                }

                if (streak == nums[i] + 1)
                {
                    list.Add(nums[i].ToString());
                }
                else
                {
                    list.Add(String.Concat(nums[i], "->", nums[k - 1]));
                }

                i = k;
            }

            return list;
        }
    }
}
