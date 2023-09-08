using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.FindFirstAndLestPositionofElementsInSortedArray
{
    /*
     * Find First and Last Position of Element in Sorted Array
     * 
     * Given an array of integers nums sorted in non-decreasing order, find the starting and ending position of a given target value.  If target is not found in the array, return [-1, -1]
     * 
     * https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/
     */
    public class Solution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            if(nums.Length == 0)
            {
                return new int[] { -1, -1 };
            }

            var left = FindIt(nums, target, true);

            if(left == -1)
            {
                return new int[] { -1, -1 };
            }

            var right = FindIt(nums, target, false);

            return new int[] { left, right };
        }

        private int FindIt(int[] nums, int target, bool isLower)
        {
            var lower = 0;
            var upper = nums.Length - 1;

            while (lower <= upper)
            {
                var middle = (upper + lower) / 2;

                if (nums[middle] == target)
                {
                    if(isLower)
                    {
                        if(middle == lower || nums[middle - 1] != target)
                        {
                            return middle;
                        }
                        else
                        {
                            upper = middle - 1;
                        }
                    }
                    else
                    {
                        if (middle == nums.Length - 1 || nums[middle + 1] != target)
                        {
                            return middle;
                        }
                        else
                        {
                            lower = middle + 1;
                        }
                    }
                }
                else if (nums[middle] < target)
                {
                    lower = middle + 1;
                }
                else
                {
                    upper = middle - 1;
                }

            }

            return -1;
        }
    }
}
