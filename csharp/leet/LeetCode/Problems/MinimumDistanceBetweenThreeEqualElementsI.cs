using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.MinimumDistanceBetweenThreeEqualElementsI
{
    /**
     * Minimum Distance Between Three Equal Elements I
     * 
     * https://leetcode.com/problems/minimum-distance-between-three-equal-elements-i
     */
    public class Solution
    {
        public int MinimumDistance(int[] nums)
        {
            var dict = GetGoodTuples(nums);

            return GetLowestTuple(dict);
        }

        private Dictionary<int, List<int>> GetGoodTuples(int[] nums)
        {
            var dict = new Dictionary<int, List<int>>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], new List<int>());
                }

                dict[nums[i]].Add(i);
            }

            return dict;
        }

        private int GetLowestTuple(Dictionary<int, List<int>> dict)
        {
            var lowest = Int32.MaxValue;

            foreach(var pair in dict)
            {
                var list = pair.Value;
                // Assumes that each list contains indexes in increasing order
                for (var i = 0; i + 2 < list.Count; i++)
                {
                    lowest = Math.Min(lowest, list[i + 2] - list[i]);
                }
            }

            return lowest == Int32.MaxValue ? -1 : lowest * 2;
        }
    }
}
