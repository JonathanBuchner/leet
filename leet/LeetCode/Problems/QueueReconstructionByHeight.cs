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
            // Line everyone up in the order 
            // [4,4],[5,2],[5,0],[6,1],[7,1],[7,0]
            Array.Sort(people, 
                (a,b) => a[0] == b[0]
                    ? b[1].CompareTo(a[1])
                    : a[0].CompareTo(b[0])
                );

            // Make a list of al the positions in the line
            var list = new List<int>();

            for (var i = 0; i < people.Length; i++)
            {
                list.Add(i);
            }

            // Make the final position of each person
            var solution = new int[people.Length][];


            for (var i = 0; i < people.Length; ++i)
            {
                var spot = people[i][1];
                var index = list[spot];
                list.Remove(index);
                solution[index] = people[i]; 
            }

            return solution;
        }
    }
}
