using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.QueueReconstructionByHeight
{
    /*
     * Queue Reconstruction by Height
     * 
     * Reconstruct and return the queue that is represented by the input array people
     * 
     * https://leetcode.com/problems/queue-reconstruction-by-height/
     */

    // Example input used input [7,0],[4,4],[7,1],[5,0],[6,1],[5,2]
    public class Solution
    {
        public int[][] ReconstructQueue(int[][] people)
        {
            Array.Sort(people, 
                (a,b) => a[0] == b[0]
                    ? b[1].CompareTo(a[1])
                    : a[0].CompareTo(b[0])
                );

            var dict = new SortedDictionary<int, int>();

            for (var i = 0; i < people.Length; i++)
            {
                dict.Add(i, i);
            }

            var solution = new int[people.Length][];

            for (var i = 0; i < people.Length; ++i)
            {
                var spot = people[i][1];
                var index = dict.Keys;
                var test = new SortedList<int, int>() { }.Keys; 
                set.RemoveAt(index);
                solution[index] = people[i]; 
            }

            return solution;
        }
    }
}
