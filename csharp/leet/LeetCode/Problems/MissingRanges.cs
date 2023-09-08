using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.MissingRanges
{
    /*
     * Missing Ranges
     * 
     * You are given an inclusive range [lower, upper] and a sorted unique integer array nums, where all elements are in the inclusive range.
     * 
     * https://leetcode.com/problems/missing-ranges/
     */
    public class Solution
    {
        public IList<string> FindMissingRanges(int[] nums, int lower, int upper)
        {
            var list = new List<string>();

            if (nums.Length == 0)
            {
                list.Add(GetRange(upper + 1, lower - 1));
            }

            for (var i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    if (nums[0] != lower)
                    {
                        list.Add(GetRange(nums[0], lower - 1));
                    }

                }
                else
                {
                    var diff = nums[i] - nums[i - 1];

                    if (diff > 1)
                    {
                        list.Add(GetRange(nums[i], nums[i - 1]));
                    }
                }


                if (i == nums.Length - 1)
                {
                    if (nums[nums.Length - 1] != upper)
                    {
                        list.Add(GetRange(upper + 1, nums[nums.Length - 1]));
                    }
                }
            }

            return list;
        }

        private string GetRange(int upper, int lower)
        {
            var diff = upper - lower;

            if (diff < 2)
            {
                Console.WriteLine($"Upper: {upper}, Lower {lower}.");
                throw new ArgumentException("Range must be greater than one to provide a string");
            }

            if (diff == 2)
            {
                return (upper - 1).ToString();
            }

            return String.Concat(
                    (lower + 1).ToString(),
                    "->",
                    (upper - 1).ToString()
                );
        }
    }
}
