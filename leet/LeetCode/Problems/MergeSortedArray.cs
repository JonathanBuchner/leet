using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Problems.MergeSortedArray
{
    /*
     * Merge Sorted Array
     * 
     * You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing the number of elements in nums1 and nums2 respectively.  Merge nums1 and nums2 into a single array sorted in non-decreasing order.
     * 
     * https://leetcode.com/problems/merge-sorted-array/
     */
    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            m--;
            n--;

            for(var i = nums1.Length - 1; i >= 0; i--)
            {
                if (m >= 0 && n >= 0)
                {
                    if (nums1[m] > nums2[n])
                    {
                        nums1[i] = nums1[m];
                        m--;
                    }
                    else
                    {
                        nums1[i] = nums2[n];
                        n--;
                    }
                }
                else if (n >= 0)
                {
                    nums1[i] = nums2[n];
                    n--;
                }
                
            }
        }
    }
}
