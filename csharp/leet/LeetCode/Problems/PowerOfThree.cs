using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.PowerOfThree
{
    /*
     * 326. Power of Three
     * 
     * Given an integer n, return true if it is a power of three. Otherwise, return false.
     * 
     * An integer n is a power of three, if there exists an integer x such that n == 3x.
     * 
     * https://leetcode.com/problems/power-of-three/description/
     */
    public class Solution
    {
        public bool IsPowerOfThree(int n)
        {
            if (n < 1)
            {
                return false;
            }

            if (n == 1)
            {
                return true;
            }

            while (n % 3 == 0)
            {

                if (n == 3)
                {
                    return true;
                }

                n /= 3;
            }

            return false;
        }
    }
}
