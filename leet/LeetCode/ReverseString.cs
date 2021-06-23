using System;
using System.Collections.Generic;
using System.Text;

/* Reverse String
 * Write a function that reverses a string. The input string is given as an array of characters s.
 * 
 * https://leetcode.com/explore/interview/card/microsoft/30/array-and-strings/187/
 */
namespace leet.LeetCode.ReverseString
{
    public class Solution
    {
        public void ReverseString(char[] s)
        {
            var left = 0;
            var right = s.Length-1;

            while (left < right)
            {
                var temp = s[left];
                s[left] = s[right];
                s[right] = temp;

                left++;
                right--;
            }
        }
    }
}
