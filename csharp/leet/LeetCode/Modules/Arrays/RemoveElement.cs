using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Modules.Arrays.RemoveElement
{
    /*
     * Remove Element
     * 
     * Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. The relative order of the elements may be changed.
     * 
     * https://leetcode.com/explore/featured/card/fun-with-arrays/511/in-place-operations/3575/
     */
    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            var amt = 0;
            for(var i = 0; i < nums.Length; i++)
            {
                if(nums[i] == val)
                {
                    amt++;
                }
                else
                {
                    nums[i - amt] = nums[i];
                }
            }

            return nums.Length - amt;
        }
    }
}
