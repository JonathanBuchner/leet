using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.MaxAreaOfIsland
{
    /*
     * Max Area of Island
     * 
     * Return the maximum area of an island in grid. If there is no island, return 0.
     * 
     * https://leetcode.com/problems/max-area-of-island/
     */
    public class Solution
    {
        public int MaxAreaOfIsland(int[][] grid)
        {
            var max = 0;
            var queue = new Queue<int[]>(); // x, y

            for (var i = 0; i < grid.Length; ++i)
            {
                for (var k = 0; k < grid[i].Length; ++k)
                {
                    var val = grid[i][k];

                    if(val == 1)
                    {
                        var currMax = 0;
                        queue.Enqueue(new int[] { i, k });
                        grid[i][k] = 2;

                        while(queue.Count > 0)
                        {
                            var q = queue.Dequeue();
                            var x = q[0]; ;
                            var y = q[1];
                            ++currMax;

                            if (CheckTop(q, grid))
                            {
                                queue.Enqueue(new int[] { x - 1, y });
                                grid[x - 1][y] = 2;
                            }
                            if (CheckLeft(q, grid))
                            {
                                queue.Enqueue(new int[] { x, y - 1 });
                                grid[x][y - 1] = 2;
                            }
                            if (CheckBot(q, grid))
                            {
                                queue.Enqueue(new int[] { x + 1, y });
                                grid[x + 1][y] = 2;

                            }
                            if (CheckRight(q, grid))
                            {
                                queue.Enqueue(new int[] { x, y + 1 });
                                grid[x][y + 1] = 2;

                            }
                        }
                        
                        max = Math.Max(max, currMax);
                    }
                }
            }

            return max;
        }

        private bool CheckTop(int[] coords, int[][] grid)
        {
            return coords[0] > 0 && grid[coords[0] - 1][coords[1]] == 1;
        }

        private bool CheckLeft(int[] coords, int[][] grid)
        {
            return coords[1] > 0 && grid[coords[0]][coords[1] - 1] == 1;
        }

        private bool CheckBot(int[] coords, int[][] grid)
        {
            return coords[0] < grid.Length - 1 && grid[coords[0] + 1][coords[1]] == 1;
        }

        private bool CheckRight(int[] coords, int[][] grid)
        {
            return coords[1] < grid[coords[0]].Length - 1 && grid[coords[0]][coords[1] + 1] == 1;
        }
    }
}
