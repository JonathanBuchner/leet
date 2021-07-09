using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Modules.Arrays.SortArraysByParity
{
    /*
     * Sort Array By Parity

     * Given an array nums of non-negative integers, return an array consisting of all the even elements of nums, followed by all the odd elements of nums.
     * 
     * You may return any answer array that satisfies this condition.
     * 
     * https://leetcode.com/explore/learn/card/fun-with-arrays/511/in-place-operations/3260/
     */
    public class Solution
    {
        public int[] SortArrayByParity(int[] nums)
        {
            var odds = 0;
            var evens = 0;

            while(evens < nums.Length)
            {
                if (nums[odds] % 2 == 1 && nums[evens] % 2 == 0)
                {
                    var temp = nums[evens];
                    nums[evens] = nums[odds];
                    nums[odds] = temp;
                    odds++;
                } 
                else if (nums[odds] % 2 == 0)
                {
                    odds++;
                }

                evens++;
            }

            return nums;
        }
    }
}
