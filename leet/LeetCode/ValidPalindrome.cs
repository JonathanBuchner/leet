using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.ValidPalindrome
{
    /* Valid Palindrome
     * https://leetcode.com/explore/interview/card/microsoft/30/array-and-strings/162/
     * 
     * Given a string s, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.
     */

    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            if (s.Length < 2) return false;

            //Prepare string for onsidering only alphanumeric characters and ignoring cases.
            var arr = s.ToLower().ToCharArray();
            var sb = new StringBuilder();
            for (var i = 0; i < arr.Length; i++)
            {
                if (Char.IsLetter(arr[i])) sb.Append(arr[i]);
            }
            var str = sb.ToString();

            var left = 0;
            var right = str.Length - 1;

            while (right > left)
            {
                if (str[right] != str[left]) return false;

                left++;
                right--;
            }

            return true;
        }
    }
}
