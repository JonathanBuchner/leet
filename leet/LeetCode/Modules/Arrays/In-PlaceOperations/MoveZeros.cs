using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Modules.Arrays.In_PlaceOperations.MoveZeros
{
    /*
     * Move Zeroes
     * Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
     * 
     * Note that you must do this in-place without making a copy of the array.
     * 
     * https://leetcode.com/explore/featured/card/fun-with-arrays/511/in-place-operations/3157/
     */
    public class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            if (nums.Length < 2) return;

            var back = 0;
            while (back < nums.Length && nums[back] != 0) back++;

            if (back == nums.Length - 1) return;
                
            var front = back + 1;
            while (front < nums.Length)
            {
                if (nums[front] != 0)
                {
                    var temp = nums[back];
                    nums[back] = nums[front];
                    nums[front] = temp;

                    back++;
                }

                front++;
            }
        }
    }
}
