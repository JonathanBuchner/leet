using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace leet.LeetCode.Modules.Queue_Stack.WallsAndGates
{
    /*
     * Walls and Gates
     * 
     * Fill each empty room with the distance to its nearest gate. If it is impossible to reach a gate, it should be filled with INF.
     * 
     * https://leetcode.com/explore/learn/card/queue-stack/231/practical-application-queue/1373/
     */
    public class Solution
    {
        public void WallsAndGates(int[][] rooms)
        {
            if (rooms == null)
            {
                throw new ArgumentNullException("Rooms cannot be null");
            }

            if(rooms.Length ==0 || rooms[0].Length == 0)
            {
                return ;
                // throw new ArgumentException("There must be at least one room.");
            }

            var gates = FindGates(rooms);

            if(gates.Count == 0)
            {
                return ;
                //throw new ArgumentException("Rooms must contain at least one gate");
            }

            UpdateRooms(rooms, gates);
        }

        private List<int[]> FindGates(int[][] rooms)
        {
            var gates = new List<int[]>();
            
            for(var i = 0; i < rooms.Length; i++)
            {
                for (var k = 0; k < rooms[0].Length; k++)
                {
                    if (rooms[i][k] == 0)
                    {
                        gates.Add(new int[] { i, k, 0 });
                    }
                }
            }

            return gates;
        }

        private void UpdateRooms(int[][] rooms, List<int[]> gates)
        {
            var queue = new Queue<int[]>();
            foreach(var gate in gates)
            {
                queue.Enqueue(gate);
            }

            while(queue.Count > 0)
            {
                CheckCardinalDirectionas(queue, rooms, queue.Dequeue());
            }
        }

        private void CheckCardinalDirectionas(Queue<int[]>  queue, int[][] rooms, int[] pos)
        {
            var height = rooms.Length;
            var width = rooms[0].Length;
            var x = pos[0];
            var y = pos[1];
            var level = pos[2] + 1;

            if(x > 0 && ValidPath(rooms[x-1][y]))
            {
                rooms[x - 1][y] = level;
                queue.Enqueue(new int[] { x - 1, y, level });
            }
            if(y > 0 && ValidPath(rooms[x][y-1]))
            {
                rooms[x][y-1] = level;
                queue.Enqueue(new int[] { x, y - 1, level });
            }
            if(x < height - 1 && ValidPath(rooms[x+1][y]))
            {
                rooms[x + 1][y] = level;
                queue.Enqueue(new int[] { x + 1, y, level });
            }
            if(y < width - 1 && ValidPath(rooms[x][y+1]))
            {
                rooms[x][y+1] = level;
                queue.Enqueue(new int[] { x, y + 1, level });
            }
        }

        private bool ValidPath(int val)
        {
            return val == 2147483647;
        }
    }
}
