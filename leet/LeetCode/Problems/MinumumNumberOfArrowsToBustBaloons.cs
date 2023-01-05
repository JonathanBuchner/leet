using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.MinumumNumberOfArrowsToBustBaloons
{
    /*
     * Minimum Number of Arrows to Burst Balloons
     * 
     * There are some spherical balloons taped onto a flat wall that represents the XY-plane. The balloons are represented as a 2D integer array points where points[i] = [xstart, xend] denotes a balloon whose horizontal diameter stretches between xstart and xend. You do not know the exact y-coordinates of the balloons.
     * 
     * Arrows can be shot up directly vertically (in the positive y-direction) from different points along the x-axis. A balloon with xstart and xend is burst by an arrow shot at x if xstart <= x <= xend. There is no limit to the number of arrows that can be shot. A shot arrow keeps traveling up infinitely, bursting any balloons in its path.
     * 
     * Given the array points, return the minimum number of arrows that must be shot to burst all balloons.
     * 
     * https://leetcode.com/problems/minimum-number-of-arrows-to-burst-balloons/description/
     */
    public class Solution
    {
        public int FindMinArrowShots(int[][] points)
        {
            var arrows = 0;

            Array.Sort(points, (a, b) => a[0] == b[0] ? a[1].CompareTo(b[1]) : a[0].CompareTo(b[0]));

            var i = 0;
            while (i < points.Length)
            {
                var x1 = points[i][1];
                var k = i + 1;

                while (k < points.Length && x1 >= points[k][0])
                {
                    x1 = Math.Min(x1, points[k][1]);
                    k++;
                }

                arrows++;
                i = k;
            }

            return arrows;
        }
    }
}
