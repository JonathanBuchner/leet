using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.MatchstickToSquares
{
    /*
     * Matchsticks to Square
     * 
     * You are given an integer array matchsticks where matchsticks[i] is the length of the ith matchstick. You want to use all the matchsticks to make one square. You should not break any stick, but you can link them up, and each matchstick must be used exactly one time.  Return true if you can make this square and false otherwise.
     * 
     * https://leetcode.com/problems/matchsticks-to-square/
     * 
     * https://en.wikipedia.org/wiki/Bin_packing_problem
     */
    public class Solution
    {
        public bool Makesquare(int[] matchsticks)
        {
            var side = matchsticks.Sum() / 4;
            var queue = new LinkedList<int[]>();
            Array.Sort(matchsticks, (a, b) => b.CompareTo(a));

            if (matchsticks[0] > side)
            {
                return false;
            }

            var startingList = new int[5];
            // First is index, next is each box

            queue.AddFirst(startingList);

            while (queue.Count > 0)
            {
                var list = queue.First();
                queue.RemoveFirst();

                if (list[0] == matchsticks.Length)
                {
                    return true;
                }
                
                var value = matchsticks[list[0]];

                for (var i = 1; i < list.Length; ++i)
                {
                    if (list[i] + value <= side)
                    {
                        var arr = new int[5];
                        Array.Copy(list, 0, arr, 0, list.Length);
                        arr[i] += value;
                        ++arr[0];
                        queue.AddFirst(arr);
                    }
                }
            }

            return false;
        }
    }
}
