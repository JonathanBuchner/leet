﻿using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Modules.Arrays.MoveZeros
{
    /*
     * Move Zeroes
     * 
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
            var front = 0;
                
            while (front < nums.Length)
            {
                if (nums[front] != 0)
                {
                    nums[back] = nums[front];
                    back++;
                }

                front++;
            }

            while (back < nums.Length)
            {
                nums[back] = 0;
                back++;
            }
        }
    }
}
