using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Modules.Arrays.In_PlaceOperations.RemoveDuplicatesFromSortedArray
{
    /*
     * Remove Duplicates from Sorted Array
     * Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once. The relative order of the elements should be kept the same.
     * 
     * Since it is impossible to change the length of the array in some languages, you must instead have the result be placed in the first part of the array nums. More formally, if there are k elements after removing the duplicates, then the first k elements of nums should hold the final result. It does not matter what you leave beyond the first k elements.
     * 
     * Return k after placing the final result in the first k slots of nums.
     * 
     * Do not allocate extra space for another array. You must do this by modifying the input array in-place with O(1) extra memory.
     * 
     * https://leetcode.com/explore/featured/card/fun-with-arrays/511/in-place-operations/3258/
     */
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            var left = 0;
            var right = 1;

            while (right < nums.Length)
            {
                if (nums[left] == nums[right])
                {
                    right++;
                }
                else
                {
                    left++;
                    nums[left] = nums[right];
                    right++;
                }
            }

            return left + 1;
        }
    }
}
