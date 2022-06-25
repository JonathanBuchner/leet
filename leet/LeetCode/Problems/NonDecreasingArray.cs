using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.NonDecreasingArray
{
    /*
     * Non-decreasing Array
     * 
     * Given an array nums with n integers, your task is to check if it could become non-decreasing by modifying at most one element.
     * 
     * https://leetcode.com/problems/non-decreasing-array/
     */
    public class Solution
    {
        public bool CheckPossibility(int[] nums)
        {
            var changedOne = false;

            for (var i = 0; i < nums.Length - 1; i++)
            {
                // 1, 2, 3, 4, 0, 5, 6
                // 14, 12, 15
                // 12, 100, 15
                if (nums[i] > nums[i + 1])
                {
                    if (changedOne)
                    {
                        return false;
                    }

                    changedOne = true;

                    if (i < nums.Length - 2 && i > 0)
                    {
                        var cantChangeSecond = false;
                        var cantChangeFirst = false;


                        if (nums[i] > nums[i + 2])
                        {
                            cantChangeSecond = true;
                        }

                        if (nums[i - 1 ] > nums[i + 1])
                        {
                            cantChangeFirst = true;
                        }

                        if (cantChangeFirst && cantChangeSecond)
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }
    }
}
