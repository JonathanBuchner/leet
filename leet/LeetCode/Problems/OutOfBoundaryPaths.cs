using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.OutOfBoundaryPaths
{
    /*
     * Out of Boundary Paths
     * 
     * There is an m x n grid with a ball. The ball is initially at the position [startRow, startColumn]. You are allowed to move the ball to one of the four adjacent cells in the grid (possibly out of the grid crossing the grid boundary). You can apply at most maxMove moves to the ball. Given the five integers m, n, maxMove, startRow, startColumn, return the number of paths to move the ball out of the grid boundary. Since the answer can be very large, return it modulo 109 + 7.
     * 
     * https://leetcode.com/problems/out-of-boundary-paths/
     */
    public class Solution
    {
        public int FindPaths(int m, int n, int maxMove, int startRow, int startColumn)
        {
            int mod = 1000000000 + 7;

            var score = 0;
            var memo = new int[m, n];
            memo[startRow, startColumn] = 1;

            for (var i = 0; i < maxMove; i++)
            {
                var temp = new int[m, n];
                for (var x = 0; x < m; ++x)
                {
                    for (var y = 0; y < n; ++y)
                    {
                        var balls = memo[x, y];

                        if (x == 0)
                        {
                            score = (score + balls) % mod;
                        }
                        else
                        {
                            temp[x - 1, y] = (temp[x - 1, y] + balls) % mod;
                        }

                        if (y == 0)
                        {
                            score = (score + balls) % mod;
                        }
                        else
                        {
                            temp[x, y - 1] = (temp[x, y - 1] + balls) % mod;
                        }

                        if (x == m - 1)
                        {
                            score = (score + balls) % mod;
                        }
                        else
                        {
                            temp[x + 1, y] = (temp[x + 1, y] + balls) % mod;
                        }

                        if (y == n - 1)
                        {
                            score = (score + balls) % mod;
                        }
                        else
                        {
                            temp[x, y + 1] = (temp[x, y + 1] + balls) % mod;
                        }

                    }
                }
                memo = temp;
            }

            return score;
        }
    }
}
