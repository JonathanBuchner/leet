using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Modules.Arrays.In_PlaceOperations.SortArraysByParity
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
            var arr = new int[nums.Length];
            var front = 0;
            var back = arr.Length - 1;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    arr[front] = nums[i];
                    front++;
                }
                else
                {
                    arr[back] = nums[i];
                    back--;
                }
            }

            return arr;
        }
    }
}
