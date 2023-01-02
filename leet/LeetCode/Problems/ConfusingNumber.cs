using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.ConfusingNumber
{
    /*
     * Confusing Number
     * 
     * A confusing number is a number that when rotated 180 degrees becomes a different number with each digit valid.  We can rotate digits of a number by 180 degrees to form new digits.
     *      When 0, 1, 6, 8, and 9 are rotated 180 degrees, they become 0, 1, 9, 8, and 6 respectively.
     *      When 2, 3, 4, 5, and 7 are rotated 180 degrees, they become invalid.
     * Note that after rotating a number, we can ignore leading zeros.
     *      For example, after rotating 8000, we have 0008 which is considered as just 8.
     * Given an integer n, return true if it is a confusing number, or false otherwise.
     * 
     * https://leetcode.com/problems/confusing-number/description/
     */
    public class Solution
    {
        public bool ConfusingNumber(int n)
        {
            var result = 0;
            var original = n;

            while (n >= 1)
            {
                var digit = n % 10;

                if (digit == 0 || digit == 1 || digit == 8)
                {
                    result = result * 10 + digit;
                }
                else if (digit == 6)
                {
                    result = result * 10 + 9;
                }
                else if (digit == 9)
                {
                    result = result * 10 + 6;
                }
                else
                {
                    return false;
                }

                n /= 10;
            }

            return result != original;
        }
    }
}
