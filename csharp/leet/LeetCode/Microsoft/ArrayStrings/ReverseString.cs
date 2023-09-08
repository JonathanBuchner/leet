using System;
using System.Collections.Generic;
using System.Text;

/* Reverse String
 * Write a function that reverses a string. The input string is given as an array of characters s.
 * 
 * https://leetcode.com/explore/interview/card/microsoft/30/array-and-strings/187/
 */
namespace leet.LeetCode.Microsoft.ArrayStrings.ReverseString
{
    public class Solution
    {
        public void ReverseString(char[] s)
        {
            var start = 0;
            var length = s.Length - 1;

            while (2 * start < length)
            {
                var temp = s[start];
                s[start] = s[length - start];
                s[length - start] = temp;

                start++;
            }
        }
    }
}
