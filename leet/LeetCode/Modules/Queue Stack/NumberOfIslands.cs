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
            var possible = new HashSet<int[]>();
            var queue = new Queue<int[]>();
            var answer = 0;

            for (var i = 0; i < grid.Length; i++)
            {
                for (var k = 0; k < grid[i].Length; k++)
                {
                    if (grid[i][k] == '1')
                    {
                        possible.Add(new int[] { i, k });
                    }
                }
            }

            while(possible.Count > 0)
            { 
                answer++;
                var start = possible.First();
                queue.Enqueue(start);

                while(queue.Count > 0)
                {
                    var current = queue.Dequeue();
                    possible.RemoveWhere(p => p[0] == current[0] && p[1] == current[1]);
                    grid[current[0]][current[1]] = '2';
                    UpdateGrid(grid, queue, current);
                }
            }

            return answer;
        }

        private void UpdateGrid(char[][] grid, Queue<int[]> queue, int[] pos)
        {
            var x = pos[0];
            var y = pos[1];

            if( x > 0 && grid[x-1][y] == '1')
            {
                queue.Enqueue(new int[] { x - 1, y});
            }
            if (y > 0 && grid[x][y - 1] == '1')
            {
                queue.Enqueue(new int[] { x, y - 1 });
            }
            if (x < grid.Length - 1 && grid[x + 1][y] == '1')
            {
                queue.Enqueue(new int[] { x + 1, y });
            }
            if (y < grid[x].Length - 1 && grid[x][y + 1] == '1')
            {
                queue.Enqueue(new int[] { x, y + 1 });
            }
        }
    }
}
