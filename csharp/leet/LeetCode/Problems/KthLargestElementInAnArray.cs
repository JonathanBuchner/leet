using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.KthLargestElementInAnArray
{
    /*
     * Kth Largest Element in an Array
     * 
     * Given an integer array nums and an integer k, return the kth largest element in the array.
     * 
     * https://leetcode.com/problems/kth-largest-element-in-an-array/
     */
    public class Solution
    {
        public int FindKthLargest(int[] nums, int k)
        {
            Array.Sort(nums);
            return nums[nums.Length - k];
        }
    }
}