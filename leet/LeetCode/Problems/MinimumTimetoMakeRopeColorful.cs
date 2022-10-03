using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.MinimumTimetoMakeRopeColorful
{
    /*
     * Minimum Time to Make Rope Colorful
     * 
     * Return the minimum time Bob needs to make the rope colorful.
     * 
     * https://leetcode.com/problems/minimum-time-to-make-rope-colorful/description/
     */
    public class Solution
    {
        public int MinCost(string colors, int[] neededTime)
        {
            var time = 0;

            for (var i = 1; i < colors.Length; i++)
            {
                if (colors[i - 1] == colors[i])
                {
                    if (neededTime[i - 1] > neededTime[i])
                    {
                        time += neededTime[i];
                        neededTime[i] = neededTime[i - 1];
                    }
                    else
                    {
                        time += neededTime[i - 1];
                        neededTime[i - 1] = neededTime[i];
                    }
                }
            }

            return time;
        }
    }
}
