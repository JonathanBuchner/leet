using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.SearchInsertPosition
{
    /*
     * Search Insert Position
     * 
     * Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.
     * 
     * You must write an algorithm with O(log n) runtime complexity
     * 
     * https://leetcode.com/problems/search-insert-position/description/
     */
    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length;

            while (right - left > 1)
            {
                var middle = (left + right) / 2;
                var current = nums[middle];

                if (current < target)
                {
                    left = middle;
                }
                else if (current > target)
                {
                    right = middle;
                }
                else
                {
                    return middle;
                }

                Console.WriteLine($"Target: {target}; Current: {current}; Left: {left}; Middle: {middle}; Right: {right}.");
            }


            if (nums[left] > target)
            {
                return left;
            }
            else if (nums[left] < target)
            {
                return left + 1;
            }
            else
            {
                return left;
            }
        }
    }
}
