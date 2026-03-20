using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.CountSubmatrices
{
    public class Solution
    {
        public int CountSubmatrices(int[][] grid, int k)
        {
            var result = 0;

            for (var r = 0; r < grid.Length; r++)
            {
                var row_total = 0;
                var col_total = 0;

                for (var c = 0; c < grid[0].Length; c++)
                {
                    row_total += grid[r][c];

                    if (r != 0)
                    {
                        col_total += grid[r-1][c];
                    }

                    if (row_total + col_total <= k)
                    {
                        result++;
                    }
                }

                if (r != 0)
                {
                    for (var c = 0; c < grid[0].Length; c++)
                    {
                        grid[r][c] += grid[r-1][c];
                    }
                }
            }

            return result;
        }
    }
}
