using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.MinimumAbsoluteDistanceBetweenMirrorPairs
{
    /**
     * Minimum Absolute Distance Between Mirror Pairs
     * 
     * https://leetcode.com/problems/minimum-absolute-distance-between-mirror-pairs/description
     */
    public class Solution
    {
        public int MinMirrorPairDistance(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            var result = Int32.MaxValue;

            for (var i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    result = Math.Min(result, i - dict[nums[i]]);
                }

                dict[ReverseNumbers(nums[i])] = i;
            }

            return result != Int32.MaxValue ? result : -1;
        }

        private int ReverseNumbers(int num)
        {
            var str = num.ToString();
            var sb = new StringBuilder();

            for (var i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }

            return Int32.Parse(sb.ToString());
        }
    }
}
