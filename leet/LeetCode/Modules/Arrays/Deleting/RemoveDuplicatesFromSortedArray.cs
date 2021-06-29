using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Modules.Arrays.Deleting.RemoveDuplicatesFromSortedArray
{
    /*
     * Remove Duplicates from Sorted Array
     * Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once. The relative order of the elements should be kept the same.
     *  
     * https://leetcode.com/explore/featured/card/fun-with-arrays/526/deleting-items-from-an-array/3248/
     */
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length < 1) return 0;

            var ind = 0;
            var pos = 1;

            while(pos < nums.Length)
            {
                if(nums[ind] == nums[pos])
                {
                    pos++;
                }
                else 
                {
                    ind++;
                    nums[ind] = nums[pos];
                    pos++;
                }
            }

            return ind + 1;
        }
    }
}
