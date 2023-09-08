using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.PaintHouseIII
{
    /*
     * Paint House III
     * 
     * Return the minimum cost of painting all the remaining houses in such a way that there are exactly target neighborhoods. If it is not possible, return -1
     * 
     * https://leetcode.com/problems/paint-house-iii/
     */
    public class Solution
    {
        public int MinCost(int[] houses, int[][] cost, int m, int n, int target)
        {
            var dp = new int[houses.Length, target + 1, cost[0].Length];

            for (var i = 0; i < houses.Length; ++i)
            {
                for(var j = 0; j < target + 1; ++j)
                {
                    for(var k = 0; k < cost[0].Length; ++k)
                    {
                        dp[i, j, k] = 1000001;
                    }
                }
            }

            for(var i = 0; i < cost[0].Length; ++i)
            {
                if (houses[0] == i + 1)
                {
                    dp[0, 1, i] = 0;
                }
                else if (houses[0] == 0)
                {
                    dp[0, 1, i] = cost[0][i];
                }
            }

            for (var h = 1; h < houses.Length; ++h)
            {
                for(var k = 1; k <= Math.Min(target, h+1); ++k)
                {
                    for(var c = 0; c < cost[0].Length; ++c)
                    {
                        if (houses[h] != 0 && c + 1 != houses[h])
                        {
                            continue;
                        }

                        var currCost = 1000001;

                        for (int prevColor = 0; prevColor < n; prevColor++)
                        {
                            if (prevColor != c)
                            {
                                // Decrement the neighborhood as adjacent houses has different color
                                currCost = Math.Min(currCost, dp[h - 1, k - 1, prevColor]);
                            }
                            else
                            {
                                // Previous house has the same color, no change in neighborhood count
                                currCost = Math.Min(currCost, dp[h - 1,k, c]);
                            }
                        }

                        int costToPaint = houses[h] != 0 ? 0 : cost[h][c];
                        dp[h,k,c] = currCost + costToPaint;
                    }
                }
            }

            var minCost = 1000001;

            for (int c = 0; c < cost[0].Length; ++c)
            {
                minCost = Math.Min(minCost, dp[m - 1, target, c]);
            }

            if(minCost == 1000001)
            {
                return -1;
            }
            else
            {
                return minCost;
            }
        }
    }
}
