using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.MaxPointsOnALine
{
    /*
     * Max Points on a Line
     * 
     * Given an array of points where points[i] = [xi, yi] represents a point on the X-Y plane, return the maximum number of points that lie on the same straight line.
     * 
     * https://leetcode.com/problems/max-points-on-a-line/description/
     */
    public class Solution
    {
        public int MaxPoints(int[][] points)
        {
            if (points.Length == 1)
            {
                return 1;
            }

            var max = 2;

            for (var i = 0; i < points.Length - 1; i++)
            {
                var dict = new Dictionary<(float? slope, float? yintercept), int>();

                for (var k = i + 1; k < points.Length; k++)
                {
                    float? slope;     // y2 -y1 / x2 - x1
                    float? intercept; //y = x * slope + yinctercept

                    if (points[k][0] - points[i][0] == 0)
                    {
                        slope = null;
                        intercept = points[i][0];
                    }
                    else
                    {
                        slope = (float)(points[k][1] - points[i][1]) / (points[k][0] - points[i][0]);
                        intercept = points[i][1] - points[i][0] * slope;
                    }

                    var vector = (slope, intercept);

                    if (dict.ContainsKey(vector))
                    {
                        dict[vector]++;
                    }
                    else
                    {
                        dict.Add(vector, 2);
                    }
                }

                foreach (var item in dict)
                {
                    max = Math.Max(max, item.Value);
                }
            }

            return max;
        }
    }
}
