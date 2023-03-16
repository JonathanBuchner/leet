using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.UglyNumber
{
    /*
     * Ugly Number
     * 
     * An ugly number is a positive integer whose prime factors are limited to 2, 3, and 5.
     * 
     * Given an integer n, return true if n is an ugly number.
     * 
     * https://leetcode.com/problems/ugly-number/description/
     */
    public class Solution
    {
        public bool IsUgly(int n)
        {
            if (n < 1)
            {
                return false;
            }

            while (n % 5 == 0)
            {
                n /= 5;
            }

            while (n % 3 == 0)
            {
                n /= 3;
            }

            while (n % 2 == 0)
            {
                n /= 2;
            }

            return n == 1;
        }
    }
}
