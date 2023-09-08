using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.BinarySearch
{
    /*
     * Binary Search
     * 
     * Given an array of integers nums which is sorted in ascending order, and an integer target, write a function to search target in nums. If target exists, then return its index. Otherwise, return -1.
     * 
     * You must write an algorithm with O(log n) runtime complexity.
     * 
     * https://leetcode.com/problems/binary-search/description/
     */
    public class Solution
    {
        public int Search(int[] nums, int target)
        {

            var l = 0;
            var r = nums.Length - 1;

            while (l <= r)
            {
                var m = (l + r) / 2;

                if (nums[m] == target)
                {
                    return m;
                }
                else if (nums[m] > target)
                {
                    r = m - 1;
                }
                else
                {
                    l = m + 1;
                }

            }

            return -1;
        }
    }
}
