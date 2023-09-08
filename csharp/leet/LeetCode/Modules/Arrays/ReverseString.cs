using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Modules.Arrays.ReverseString
{
    /*
     * Reverse String
     * 
     * Write a function that reverses a string. The input string is given as an array of characters s.  You must do this by modifying the input array in-place with O(1) extra memory.
     * 
     * https://leetcode.com/explore/learn/card/array-and-string/205/array-two-pointer-technique/1183/
     */
    public class Solution
    {
        public void ReverseString(char[] s)
        {
            var l = 0;
            var r = s.Length - 1;

            while (l < r)
            {
                var temp = s[l];
                s[l] = s[r];
                s[r] = temp;

                ++l;
                --r;
            }
        }
    }
}
