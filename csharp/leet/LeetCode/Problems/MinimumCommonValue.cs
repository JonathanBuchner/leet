using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.MinimumCommonValue
{
    public class Solution
    {
        public int GetCommon(int[] nums1, int[] nums2)
        {
            var i = 0;
            var k = 0;

            while (i < nums1.Length && k < nums2.Length)
            {
                var num1 = nums1[i];
                var num2 = nums2[k];

                if (num1 == num2)
                    return num1;

                if (num1 > num2)
                {
                    k++;
                }
                else
                {
                    i++;
                }
            }

            return -1;
        }
    }
}
