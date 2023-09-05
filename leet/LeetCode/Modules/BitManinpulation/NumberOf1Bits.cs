using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Modules.BitManinpulation.NumberOf1Bits
{
    /*
     * Number of 1 Bits
     * 
     * Write a function that takes the binary representation of an unsigned integer and returns the number of '1' bits it has (also known as the Hamming weight).
     * 
     * https://leetcode.com/problems/number-of-1-bits/submissions/
     */
    public class Solution
    {
        public int HammingWeight(uint n)
        {
            var count = 0;

            for (var i = 0; i < 32; i++)
            {
                if ((n & 1) == 1)
                {
                    count++;
                }

                n = n >> 1;
            }

            return count;
        }
    }
}
