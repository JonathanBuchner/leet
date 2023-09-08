using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.ReverseStringII
{
    /*
     * Reverse String II
     * 
     * You are given a sorted array consisting of only integers where every element appears exactly twice, except for one element which appears exactly once.
     * 
     * Return the single element that appears only once.
     * 
     * Your solution must run in O(log n) time and O(1) space.
     * 
     * https://leetcode.com/problems/reverse-string-ii/description/
     */

    public class Solution
    {
        public int SingleNonDuplicate(int[] nums)
        {
            var l = 0;
            var r = nums.Length - 1;

            if (nums.Length == 1)
            {
                return nums[0];
            }

            while (l < r)
            {
                var m = (l + r) / 2;

                if (m % 2 == 1)
                {
                    m--;
                }
                Console.WriteLine($"l: {l}; m: {m}; r: {r}.");

                if (nums[m] == nums[m + 1])
                {
                    l = m + 2;
                }
                else
                {
                    r = m;
                }
            }

            return nums[l];
        }
    }
}
