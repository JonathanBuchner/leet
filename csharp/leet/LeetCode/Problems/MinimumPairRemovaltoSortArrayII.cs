using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.MinimumPairRemoval_II
{
    /// <summary>
    /// Given an array nums, you can perform the following operation any number of times:
    ///    - Select the adjacent pair with the minimum sum in nums.If multiple such pairs exist, choose the leftmost one.
    ///    - Replace the pair with their sum
    /// Return the minimum number of operations needed to make the array non-decreasing.
    //An array is said to be non-decreasing if each element is greater than or equal to its previous element (if it exists).

    // https://leetcode.com/problems/minimum-pair-removal-to-sort-array-ii/description/?envType=daily-question&envId=2026-01-23
    /// </summary>
    
    public class TrackSortedArray
    {
        private SortedDictionary<int, long> _sd;
        private int Fixes { get; }
        private bool IsSorted => Fixes == 0;
        public TrackSortedArray(int[] nums)
        {
            _sd = new SortedDictionary<int, long>();

            for (var i = 0; i + 1 < nums.Length; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    Fixes++;
                }
            }
        }

        public bool Combine(int index)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("Index must be greater than zero");
            }

            if (index > _sd.Max().Key)
            {
                throw new ArgumentOutOfRangeException($"Index must be less than the greatest remaining index. Max: { _sd.Max().Key }. Requested: { index } ");
            }

            long left;
            if (_sd.TryGetValue(index, out left))
            {
                throw new ArgumentException($"Index does not exist. Index: {index}");
            }

            throw new NotImplementedException();
        }
    }

    public class Solution
    {
        public int MinimumPairRemoval(int[] nums)
        {
            var sorted_Dictionary = new SortedDictionary<int, long>();

            for (var i = 0; i < nums.Length; i++)
            {

            }

            throw new NotImplementedException();

        }
    }
}
