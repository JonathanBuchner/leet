using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.LongestBalancedSubarray
{
    /// <summary>
    /// Longest Balanced Subarray I
    /// 
    /// https://leetcode.com/problems/longest-balanced-subarray-i/description/?envType=daily-question&envId=2026-02-10
    /// </summary>
    public class Solution
    {
        public int LongestBalanced(int[] nums)
        {
            for (var i = nums.Length - 1; i > 0; i--)
            { 
                for (var k = 0; k + i < nums.Length; k++)
                {
                    if (HasBalancedSubarrary(nums, k, k + i))
                    {
                        return i + 1;
                    }
                }
            }

            return 0;
        }

        private bool HasBalancedSubarrary(int[] nums, int start, int end)
        {
            var set = new HashSet<int>();
            var count = 0;

            for (var i = start; i <= end; i++)
            {
                if (set.Contains(nums[i]))
                    continue;

                count = nums[i] % 2 == 0 ? count + 1 : count - 1;

                set.Add(nums[i]);
            }

            return count == 0;
        }
    }
}
