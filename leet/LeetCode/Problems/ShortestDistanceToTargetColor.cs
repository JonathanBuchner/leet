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
            var dp = new int[3, colors.Length];           
            var list = new List<int>();
          
            var color = new int[3];

            for (int i = 0; i < color.Length; i++)
            {
                color[i] = Int32.MaxValue;
            }

            for(var i = 0; i < colors.Length; ++i)
            {
                
                for(var k = 0; k < color.Length; ++k)
                {
                    if(colors[i] - 1 == k)
                    {
                        color[k] = 0;
                    }
                    else if(color[k] != Int32.MaxValue)
                    {
                        color[k]++;
                    }
                }

                for(var k = 0; k < color.Length; ++k)
                {
                    dp[k, i] = color[k];
                }
            }

            for (int i = 0; i < color.Length; i++)
            {
                color[i] = Int32.MaxValue;
            }

            for (var i = colors.Length - 1; i >= 0; --i)
            {

                for (var k = 0; k < color.Length; ++k)
                {
                    if (colors[i] - 1 == k)
                    {
                        color[k] = 0;
                    }
                    else if (color[k] != Int32.MaxValue)
                    {
                        color[k]++;
                    }
                }

                for (var k = 0; k < color.Length; ++k)
                {
                    dp[k, i] = Math.Min(dp[k, i], color[k]);
                }
            }
            

            for (var i = 0; i < queries.Length; ++i)
            {
                var dist = dp[queries[i][1] - 1, queries[i][0]];

                if(dist == Int32.MaxValue)
                {
                    list.Add(-1);
                }
                else
                {
                    list.Add(dist);
                }
                
            }

            return list;
        }
    }
}
