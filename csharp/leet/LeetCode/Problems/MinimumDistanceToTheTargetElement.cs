using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.MinimumDistanceToTheTargetElement
{
    /**
     * Minimum Distance to the Target Element
     * 
     * https://leetcode.com/problems/minimum-distance-to-the-target-element/description/?envType=daily-question&envId=2026-04-13
     */
    public class Solution
    {
        public int GetMinDistance(int[] nums, int target, int start)
        {
            var result = Int32.MaxValue;
            
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    result = Math.Min(result, Math.Abs(i - start));
                }
            }

            return result;
        }
    }
}
