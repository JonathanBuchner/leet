using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leet.LeetCode.Modules.Queue_Stack.NumberOfIslands
{
    /*
     * Number of Islands
     * 
     * Given an m x n 2D binary grid grid which represents a map of '1's (land) and '0's (water), return the number of islands.
     * 
     * https://leetcode.com/explore/learn/card/queue-stack/231/practical-application-queue/1374/
     */
    public class Solution
    {
        public int NumIslands(char[][] grid)
        {
            return BFA(grid);
        }
        
        private int BFA(char[][] grid)
        {
            var queue = new LinkedList<int>();
            var answer = 0;

            for (var i = 0; i < grid.Length; i++)
            {
                for (var k = 0; k < grid[i].Length; k++)
                {
                    if (grid[i][k] == '1')
                    {
                        answer++;
                        grid[i][k] = '0';
                        queue.AddFirst(i * grid[i].Length + k);

                        while (queue.Count > 0)
                        {
                            var pos = queue.Last();
                            queue.RemoveLast();
                            var x = pos / grid[i].Length;
                            var y = pos % grid[i].Length;
                            

                            if (x > 0 && grid[x - 1][y] == '1')
                            {
                                queue.AddFirst((x - 1) * grid[x].Length + y);
                                grid[x-1][y] = '0';
                            }
                            if (y > 0 && grid[x][y - 1] == '1')
                            {
                                queue.AddFirst(x * grid[x].Length + y - 1);
                                grid[x][y-1] = '0';
                            }
                            if (x < grid.Length - 1 && grid[x + 1][y] == '1')
                            {
                                queue.AddFirst((x + 1) * grid[x].Length + y);
                                grid[x+1][y] = '0';
                            }
                            if (y < grid[x].Length - 1 && grid[x][y + 1] == '1')
                            {
                                queue.AddFirst(x * grid[x].Length + y + 1);
                                grid[x][y+1] = '0';
                            }
                        }
                    }
                }
            }

            return answer;
        }
    }
}
