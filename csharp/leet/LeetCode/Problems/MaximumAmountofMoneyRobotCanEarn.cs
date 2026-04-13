using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.MaximumAmountofMoneyRobotCanEarn
{
    public class Solution
    {
        public int MaximumAmount(int[][] coins)
        {
            int n = coins[0].Length;
            int[,] dp = new int[n + 1, 3];
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dp[i, j] = int.MinValue / 2;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                dp[1, i] = 0;
            }
            foreach (int[] row in coins)
            {
                for (int j = 1; j <= n; j++)
                {
                    int x = row[j - 1];
                    dp[j, 2] = Math.Max(Math.Max(dp[j - 1, 2] + x, dp[j, 2] + x),
                                        Math.Max(dp[j - 1, 1], dp[j, 1]));
                    dp[j, 1] = Math.Max(Math.Max(dp[j - 1, 1] + x, dp[j, 1] + x),
                                        Math.Max(dp[j - 1, 0], dp[j, 0]));
                    dp[j, 0] = Math.Max(dp[j - 1, 0], dp[j, 0]) + x;
                }
            }

            return dp[n, 2];
        }
    }
}
