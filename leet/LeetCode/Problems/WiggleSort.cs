using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.WiggleSort
{
    /*
     * Wiggle Sort
     * 
     * Given an integer array nums, reorder it such that nums[0] <= nums[1] >= nums[2] <= nums[3].... You may assume the input array always has a valid answer.
     * 
     * https://leetcode.com/problems/wiggle-sort/description/
     */
    public class Solution
    {
        public void WiggleSort(int[] nums)
        {
            Array.Sort(nums);

            if (nums.Length % 2 == 0)
            {
                for (var i = 0; i < nums.Length / 2; i++)
                {
                    if (i % 2 == 1)
                    {
                        var k = nums.Length - i - 1;
                        var temp = nums[i];
                        nums[i] = nums[k];
                        nums[k] = temp;
                    }
                }
            }
            else
            {
                for (var i = 1; i <= nums.Length / 2; i++)
                {
                    if (i % 2 == 1)
                    {
                        var k = nums.Length - i;
                        var temp = nums[i];
                        nums[i] = nums[k];
                        nums[k] = temp;
                    }
                }
            }


        }
    }
}
