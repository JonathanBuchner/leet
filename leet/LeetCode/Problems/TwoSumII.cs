using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Problems.TwoSumII
{
    public class Solution
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            var l = 0;
            var r = numbers.Length - 1;
            
            while( l < r)
            {
                var total = numbers[l] + numbers[r];
                if (  total == target)
                {
                    return new int[] { l + 1, r + 1 };
                }

                if (total > target)
                {
                    r--;
                }
                else
                {
                    l++;
                }
            }

            throw new ArgumentException("Input did not match required constraints");
        }
    }
}



