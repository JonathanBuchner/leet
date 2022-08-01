using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.UniquePaths
{
    /*
     * Unique Paths
     * 
     * Given the two integers m and n, return the number of possible unique paths that the robot can take to reach the bottom-right corner. The robot can only move either down or right at any point in time.
     * 
     * https://leetcode.com/problems/unique-paths/
     */
    public class Solution
    {
        public int UniquePaths(int m, int n)
        {
            var dp = new int[m, n];

            for (var i = 0; i < m; ++i)
            {
                dp[i, 0] = 1;
            }

            for (var i = 0; i < n; ++i)
            {
                dp[0, i] = 1;
            }

            for (var i = 1; i < m; ++i)
            {
                for (var k = 1; k < n; ++k)
                {
                    dp[i, k] = dp[i - 1, k] + dp[i, k - 1];
                }
            }

            return dp[m - 1, n - 1];
        }
    }
}
