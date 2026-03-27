using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.EqualSumGridPartitionII
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
                return false;
            
            long top_total = 0;
            long bot_total = 0;
            var top_dict = new Dictionary<long, (int r, int c)>();
            var bot_dict = new Dictionary<long, (int r, int c)>();

            for (var i = 0; i < grid[0].Length; i++)
            {
                top_total += grid[0][i];
                top_dict.Add(grid[0][i], (0, i));
            }

            for (var i = 0; i < grid[0].Length; i++)
            {
                bot_total += grid[grid.Length - 1][i];
                bot_dict.Add(grid[grid.Length - 1][i], (grid.Length - 1, i));
            }            

            var top_i = 1;
            var bot_i = grid.Length - 2;
            bool top_multi_row = false;
            bool bot_is_multi_row = false;


            while (top_i <= bot_i)
            {
                var use_top = top_total <= bot_total;
                var i = use_top ? top_i : bot_i;
                var total = 0;
                for (var k = 0; k < grid[i].Length; k++)
                {
                    total += grid[i][k];
                    if (use_top)
                    {
                        if (!top_dict.ContainsKey(grid[i][k]))
                            top_dict.Add(grid[i][k], (i,k));
                        top_multi_row = true;
                    }
                    else
                    {
                        if (!bot_dict.ContainsKey(grid[i][k]))
                            bot_dict.Add(grid[i][k], (i, k));
                        bot_is_multi_row = true;
                    }
                }

                if (use_top) {
                    top_total += total;
                    top_i++;
                }
                else
                {
                    bot_total += total;
                    bot_i--;
                }
            }

            var diff = top_total - bot_total;

            if (diff == 0)
            {
                return true;
            }
            else if (diff > 0)
            {
                if (top_dict.ContainsKey(diff))
                {
                    if (top_multi_row)
                    {
                        return true;
                    }
                    else
                    {
                        var pos = top_dict[diff * -1];
                        if (pos.c == 0 || pos.c == grid[pos.r].Length - 1)
                        {
                            return true;
                        }
                    }
                }
            }
            else
            {
                if (bot_dict.ContainsKey(diff * -1))
                {
                    if (bot_is_multi_row)
                    {
                        return true;
                    }
                    else
                    {
                        var pos = bot_dict[diff * -1];
                        if (pos.c == 0 || pos.c == grid[pos.r].Length - 1)
                        {
                            return true;
                        }
                    }
                }   
            }

            return false;
        }

        private bool TestVerticalCut(int[][] grid)
        {
            if (grid[0].Length < 2)
            {
                return false;
            }

            long left_total = 0;
            long right_total = 0;
            var left_dict = new Dictionary<long, (int r, int c)>();
            var right_dict = new Dictionary<long, (int r, int c)>();

            for (var i = 0; i < grid.Length; i++)
            {
                left_total += grid[i][0];
                left_dict.Add(grid[i][0], (i, 0));
            }

            for (var i = 0; i < grid.Length; i++)
            {
                right_total += grid[i][grid[0].Length - 1];
                right_dict.Add(grid[i][grid[0].Length - 1], (i, grid[0].Length - 1));
            }
            
            var left_i = 1;
            var right_i = grid[0].Length - 2;
            var left_is_multi_row = false;
            var right_is_multi_row = false;

            while (left_i <= right_i)
            {
                var use_left = left_total <= right_total;
                var i = use_left ? left_i : right_i;
                var total = 0;
                for (var k = 0; k < grid.Length; k++)
                {
                    total += grid[k][i];

                    if (use_left)
                    {
                        if (!left_dict.ContainsKey(grid[k][i]))
                            left_dict.Add(grid[k][i], (i, k));
                    }
                    else
                    {
                        if (!right_dict.ContainsKey(grid[k][i]))
                            right_dict.Add(grid[k][i], (i, k));
                    }
                }

                if (use_left)
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

            var diff = left_total - right_total;

            if (diff == 0)
            {
                return true;
            }
            else if (diff > 0)
            {
                if (left_dict.ContainsKey(diff))
                {
                    if (left_is_multi_row)
                    {
                        return true;
                    }
                    else
                    {
                        var pos = left_dict[diff * -1];
                        if (pos.c == 0 || pos.c == grid[pos.r].Length - 1)
                        {
                            return true;
                        }
                    }
                }
            }
            else
            {
                if (right_dict.ContainsKey(diff * -1))
                {
                    if (right_is_multi_row)
                    {
                        return true;
                    }
                    else
                    {
                        var pos = right_dict[diff * -1];
                        if (pos.c == 0 || pos.c == grid[pos.r].Length - 1)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
    }
}
