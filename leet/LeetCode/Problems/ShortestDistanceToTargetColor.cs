using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.ShortestDistanceToTargetColor
{
    /*
     * Shortest Distance to Target Color
     * 
     * You are given an array colors, in which there are three colors: 1, 2 and 3.  You are also given some queries. Each query consists of two integers i and c, return the shortest distance between the given index i and the target color c. If there is no solution return -1.
     * 
     * https://leetcode.com/problems/shortest-distance-to-target-color/
     */
    public class Solution
    {
        public IList<int> ShortestDistanceColor(int[] colors, int[][] queries)
        {
            var list = new List<int>();

            for(var i = 0; i < queries.Length; ++i)
            {
                var start = queries[i][0];
                var left = start;
                var right = start;
                var color = queries[i][1];
                var diff = -1;

                while(left >= 0 || right < colors.Length)
                {
                    if(left >= 0)
                    {
                        if (colors[left] == color)
                        {
                            diff = start - left;
                            break;
                        }
                        --left;
                    }

                    if(right < colors.Length)
                    {
                        if (colors[right] == color)
                        {
                            diff = right - start;
                            break;
                        }
                        ++right;
                    }
                }

                list.Add(diff);
            }

            return list;
        }
    }
}
