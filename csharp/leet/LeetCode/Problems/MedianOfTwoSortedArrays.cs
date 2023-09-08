using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Problems.MedianOfTwoSortedArrays
{
    /*
     * Median of Two Sorted Arrays
     * Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
     * 
     * The overall run time complexity should be O(log (m+n)).
     * 
     * https://leetcode.com/problems/median-of-two-sorted-arrays/
     */
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double middle = (nums1.Length + nums2.Length) / 2d;
            var isEven = (nums1.Length + nums2.Length) % 2 == 0;

            var i1 = 0;
            var i2 = 0;
            double k = isEven ? middle - 1 : Math.Floor(middle);
            
            while(k > 0)
            {
                if (nums1.Length > i1 && nums2.Length > i2)
                {
                    if (nums1[i1] > nums2[i2])
                    {
                        i2++;
                    }
                    else
                    {
                        i1++;
                    }
                }
                else if (nums1.Length > i1)
                {
                    i1++;
                } 
                else
                {
                    i2++;
                }

                k--;
            }

            double bot;

            if (nums1.Length > i1 && nums2.Length > i2)
            {
                if (nums1[i1] > nums2[i2])
                {
                    bot = nums2[i2];
                    i2++;
                }
                else
                {
                    bot = nums1[i1];
                    i1++;
                }
            }
            else if (nums1.Length > i1)
            {
                bot = nums1[i1];
                i1++;
            }
            else
            {
                bot = nums2[i2];
                i2++;
            }

            if (!isEven) return bot;

            double top;

            if (nums1.Length > i1 && nums2.Length > i2)
            {
                if (nums1[i1] > nums2[i2])
                {
                    top = nums2[i2];
                }
                else
                {
                    top = nums1[i1];
                }
            }
            else if (nums1.Length > i1)
            {
                top = nums1[i1];
                i1++;
            }
            else
            {
                top = nums2[i2];
                i2++;
            }

            return (top + bot) / 2d;
        }
    }
}
