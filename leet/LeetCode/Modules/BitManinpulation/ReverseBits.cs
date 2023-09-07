using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Modules.BitManinpulation.ReverseBits
{
    /*
     * ReverseBits
     * 
     * Reverse bits of a given 32 bits unsigned integer.
     * 
     * https://leetcode.com/problems/reverse-bits/description/
     */
    public class Solution
    {
        public uint reverseBits(uint n)
        {
            uint result = 0;

            for (var i = 31; i >= 0; i--)
            {
                result += (n & 1) << i;
                n = n >> 1;
            }

            return result;
        }
    }
}
