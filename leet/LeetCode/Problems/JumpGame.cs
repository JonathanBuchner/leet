using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.JumpGame
{
    /*
     * Jump Game VI
     * 
     * Return the maximum score you can get.
     * 
     * https://leetcode.com/problems/jump-game-vi/
     */
    public class Solution
    {
        public int MaxResult(int[] nums, int k)
        {
            var dp = new int[nums.Length];
            dp[0] = nums[0];
            var skips = 0;

            for(var i = 1; i < nums.Length - 1; ++i)
            {
                if(nums[i] >= 0)
                {
                    dp[i] = dp[i - 1] + nums[i];
                    skips = 0;

                    continue;
                }

                if(skips < k - 1)
                {
                    ++skips;
                    dp[i] = dp[i - skips];
                }
                else
                {
                    var best = Math.Max(nums[i], nums[i - skips]);
                    dp[i] = dp[i - 1] + best;
                }
            }

            return dp[nums.Length - 2] + nums[nums.Length - 1];
        }
    }
}
