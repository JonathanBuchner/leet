using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.EqualSumGridPartitionI
{
    public class Solution
    {
        public bool CanPartitionGrid(int[][] grid)
        {
            return TestHorizontalCut(grid) || TestVerticalCut(grid);
        }

        private bool TestHorizontalCut(int[][] grid)
        {
            if (grid.Length < 2)
            {
                return false;
            }

            long top_total = 0;
            long bot_total = 0;

            for (var i = 0; i < grid[0].Length; i++)
            {
                top_total += grid[0][i];
            }

            for (var i = 0; i < grid[0].Length; i++)
            {
                bot_total += grid[grid.Length-1][i];
            }

            var top_i = 1;
            var bot_i = grid.Length - 2;
           

            while(true)
            {
                if (top_i > bot_i)
                {
                    return top_total == bot_total;
                }

                var i = top_total <= bot_total ? top_i : bot_i;
                var total = 0;
                for (var k = 0; k < grid[i].Length; k++)
                {
                    total += grid[i][k];
                }

                if (top_total <= bot_total)
                {
                    top_total += total;
                    top_i++;
                }
                else
                {
                    bot_total += total;
                    bot_i--;
                }
            }
        }

        private bool TestVerticalCut(int[][] grid)
        {
            if (grid[0].Length < 2)
            {
                return false;
            }

            long left_total = 0;
            long right_total = 0;

            for (var i = 0; i < grid.Length; i++)
            {
                left_total += grid[i][0];
            }

            for (var i = 0; i < grid.Length; i++)
            {
                right_total += grid[i][grid[0].Length - 1];
            }

            var left_i = 1;
            var right_i = grid[0].Length - 2;

            while (true)
            {
                if (left_i > right_i)
                {
                    return left_total == right_total;
                }

                var i = left_total <= right_total ? left_i : right_i;
                var total = 0;
                for (var k = 0; k < grid.Length; k++)
                {
                    total += grid[k][i];
                }

                if (left_total <= right_total)
                {
                    left_total += total;
                    left_i++;
                }
                else
                {
                    right_total += total;
                    right_i--;
                }
            }
            
        }
    }
}
