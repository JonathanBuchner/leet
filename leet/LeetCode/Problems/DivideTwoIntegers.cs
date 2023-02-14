using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.DivideTwoIntegers
{
    /*
     * Divide Two Integers
     * 
     * Given two integers dividend and divisor, divide two integers without using multiplication, division, and mod operator.
     * 
     * https://leetcode.com/problems/divide-two-integers/description/
     */
    public class Solution
    {
        public int Divide(int dividend, int divisor)
        {
            if (dividend == Int32.MinValue)
            {
                if (divisor == -1)
                {
                    return Int32.MaxValue;
                }
                return dividend / divisor;
            }
            else if (divisor == Int32.MinValue)
            {
                return 0;
            }

            uint total = 0;
            var i = 0;
            var isNeg = dividend < 0 ^ divisor < 0;
            dividend = Math.Abs(dividend);
            uint d = (uint)Math.Abs(divisor);

            while (total <= Int32.MaxValue)
            {
                total += d;

                if (total > dividend)
                {
                    if (isNeg)
                    {
                        return ~i + 1;
                    }
                    else
                    {
                        return i;
                    }
                }

                i++;
            }

            if (isNeg)
            {
                return Int32.MinValue;
            }
            else
            {
                return Int32.MaxValue;
            }
        }
    }
}
