using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Problems.Triangle
{
    /*
     * Triangle
     * 
     * Given a triangle array, return the minimum path sum from top to bottom.
     * 
     * 1 <= triangle.length <= 200
     * triangle[0].length == 1
     * triangle[i].length == triangle[i - 1].length + 1
     * -104 <= triangle[i][j] <= 104
     * 
     * https://leetcode.com/problems/triangle/
     */
    public class Solution
    {
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            for (var t = triangle.Count - 2; t >= 0; t--)
            {
                for(var p = 0; p < triangle[t].Count; p++)
                {
                    triangle[t][p] = 
                        triangle[t][p] +
                        Math.Min(triangle[t + 1][p], triangle[t + 1][p+1]);
                }
            }

            return triangle[0][0];
        }
    }
}
