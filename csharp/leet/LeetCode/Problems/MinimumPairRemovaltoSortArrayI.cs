using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.MinimumPairRemoval_I
{
    /// <summary>
    /// Given an array nums, you can perform the following operation any number of times:
    //  - Select the adjacent pair with the minimum sum in nums.If multiple such pairs exist, choose the leftmost one.
    //  - Replace the pair with their sum.
    //
    // Return the minimum number of operations needed to make the array non-decreasing
    //
    // An array is said to be non-decreasing if each element is greater than or equal to its previous element (if it exists).
    
    // https://leetcode.com/problems/minimum-pair-removal-to-sort-array-i/description/?envType=daily-question&envId=2026-01-22
    /// </summary>
    public class Solution
    {
        public int MinimumPairRemoval(int[] nums)
        {
            var is_non_decreasing = false;
            var list = nums.ToList();

            while (!is_non_decreasing && list.Count > 1)
            {
                is_non_decreasing = true;
                var smallest_pair = new int[] { list[0] + list[1], 0};

                for (var i = 0; i + 1 < list.Count; i++)
                {
                    if (list[i] > list[i + 1])
                    {
                        is_non_decreasing = false;
                    }

                    if (smallest_pair[0] > list[i] + list[i+1])
                    {
                        smallest_pair = new int[] { list[i] + list[i + 1], i};
                    }

                }

                if (!is_non_decreasing)
                {
                    list[smallest_pair[1]] = smallest_pair[0];
                    list.RemoveAt(smallest_pair[1] + 1);
                }
            }

            return nums.Length - list.Count;
        }
    }
}
