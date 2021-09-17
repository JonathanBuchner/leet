using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Modules.Arrays.ThirdMaximumNumber
{
    /*
     * ThirdMaxNumber
     * 
     * Given an integer array nums, return the third distinct maximum number in this array. If the third maximum does not exist, return the maximum number.
     * 
     * https://leetcode.com/explore/featured/card/fun-with-arrays/523/conclusion/3231/
     */
    public class Solution
    {
        public int ThirdMax(int[] nums)
        {
            var list = new List<int>() { nums[0] };
            var i = 1;

            while(list.Count <= 2 && i < nums.Length)
            {
                if(!list.Contains(nums[i]))
                {
                    list.Add(nums[i]);
                }

                i++;
            }

            list.Sort();
            if (list.Count == 1) return list[0];
            if (list.Count == 2) return list[1];

            while (i < nums.Length)
            {
                if(nums[i] > list[0])
                {
                    if(!list.Contains(nums[i]))
                    {
                        list[0] = nums[i];
                        list.Sort();
                    }
                }

                i++;
            }

            return list[0];
        }
    }
}