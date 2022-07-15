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
            throw new NotImplementedException();

            var dp = new int[ 3, colors.Length];           
            var list = new List<int>();
          
            var i0 = 0;
            var i1 = 0;
            var i2 = 0;

            for(var i = 0; i < colors.Length; ++i)
            {
                var c = colors[i];


            }

            for (var i = colors.Length; i >= 0; --i)
            {

            }

            for (var i = 0; i < queries.Length; ++i)
            {
                
            }

            return list;
        }
    }
}
