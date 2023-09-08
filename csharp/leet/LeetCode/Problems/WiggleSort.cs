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
            for (var i = 0; i < nums.Length - 1; i++)
            {
                if (i % 2 == 0)
                {
                    if (nums[i] > nums[i + 1])
                    {
                        Swap(nums, i, i + 1);
                    }
                }
                else if (i % 2 == 1)
                {
                    if (nums[i] < nums[i + 1])
                    {
                        Swap(nums, i, i + 1);
                    }
                }
            }
        }

        private void Swap(int[] nums, int l, int r)
        {
            var temp = nums[r];
            nums[r] = nums[l];
            nums[l] = temp;
        }
    }
}
