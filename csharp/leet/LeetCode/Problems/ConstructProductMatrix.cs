using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.ConstructProductMatrix
{
    public class Solution
    {
        public int[][] ConstructProductMatrix(int[][] grid)
        {
            const int MOD = 12345;
            int[][] p = new int[grid.Length][];

            for (int i = 0; i < grid.Length; i++)
            {
                p[i] = new int[grid[i].Length];
            }

            long suffix = 1;
            for (int n = grid.Length - 1; n >= 0; n--)
            {
                for (int m = grid[n].Length - 1; m >= 0; m--)
                {
                    p[n][m] = (int)suffix;
                    suffix = suffix * grid[n][m] % MOD;
                }
            }

            long prefix = 1;
            for (int n = 0; n < grid.Length; n++)
            {
                for (int m = 0; m < grid[n].Length; m++)
                {
                    p[n][m] = (int)((long)p[n][m] * prefix % MOD);
                    prefix = prefix * grid[n][m] % MOD;
                }
            }

            return p;
        }
    }
}
