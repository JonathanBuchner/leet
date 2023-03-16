using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.MissingNumber
{
    /*
     * Missing Number
     * 
     * Given an array nums containing n distinct numbers in the range [0, n], return the only number in the range that is missing from the array.
     * 
     * https://leetcode.com/problems/missing-number/description/
     */
    public class Solution
    {
        public int MissingNumber(int[] nums)
        {
            var total = (nums.Length) * (nums.Length + 1) / 2;

            for (var i = 0; i < nums.Length; i++)
            {
                total -= nums[i];
            }

            return total;
        }
    }
}
