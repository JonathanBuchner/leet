using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Modules.Arrays.MergeSortedArrays
{
    /*
     * Merge two sorted arrays
     * 
     * You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing the number of elements in nums1 and nums2 respectively.
     * 
     * The final sorted array should not be returned by the function, but instead be stored inside the array nums1. To accommodate this, nums1 has a length of m + n
     * 
     * https://leetcode.com/explore/featured/card/fun-with-arrays/525/inserting-items-into-an-array/3253/
     */
    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var insertion = nums1.Length - 1;
            var index1 = m - 1;
            var index2 = n - 1;

            while (index2 >= 0 && insertion >= 0)
            {
                if (index1 >= 0 && nums1[index1] > nums2[index2])
                {
                    nums1[insertion] = nums1[index1];
                    index1--;
                }
                else
                {
                    nums1[insertion] = nums2[index2];
                    index2--;
                }

                insertion--;
            }
        }
    }
}
