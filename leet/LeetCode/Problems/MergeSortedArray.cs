using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Problems.MergeSortedArray
{
    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {

            /*var i = 0;
            var j = 0;
            var k = -1;

            while (j < n)
            {
                if (k == -1)
                {
                    if (nums2[k] < nums2[j])
                    {
                        nums1[i] = nums2[k];
                        k--;
                    }
                    else
                    {
                        var temp = nums2[j];
                        k++;
                        nums2[k] = nums1[i];
                        nums1[i] = temp;
                        j++;
                    }
                }
                else if (nums1[i] > nums2[j])
                {
                    var temp = nums1[i];
                    nums1[i] = nums2[j];
                    nums2[j] = temp;
                    j++;
                    k++;
                }

                i++;
            }

            var l = i;
            var o = l + k + 1;
            while (o > n)
            {
                nums1[o] = nums1[l];
                l++;
                o++;
            }
            while(k > -1)
            {
                nums1[i] = 

            }

        }*/
    }
}
