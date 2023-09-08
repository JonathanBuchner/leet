using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.PowerOfFour
{
    /*
     * Power of Four
     * 
     * Given an integer n, return true if it is a power of four. Otherwise, return false.
     * 
     * An integer n is a power of four, if there exists an integer x such that n == 4x.
     * 
     * https://leetcode.com/problems/power-of-four/description/
     */
    public class Solution
    {
        public bool IsPowerOfFour(int n)
        {

            if (n < 1)
            {
                return false;
            }
            if (n == 1)
            {
                return true;
            }

            while (n % 4 == 0)
            {
                n /= 4;

                if (n == 1)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
