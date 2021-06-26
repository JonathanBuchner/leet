using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.LongestPalindromicSubstring
{
    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            var str = "";
            
            for(var i = 0; i < s.Length; i++)
            {
                if (s.Length - i <= str.Length) break;

                var sb = new StringBuilder();
                for (var k = i; k < s.Length; k++)
                {
                    sb.Append(s[k]);
                    if (sb.Length > str.Length)
                    {
                        if (IsPalindrome(sb.ToString())) str = sb.ToString();
                    }
                }
            }

            return str;
        }
        private bool IsPalindrome(string s)
        {
            if (s.Length == 0) return false;

            //Prepare string for onsidering only alphanumeric characters and ignoring cases.
            var sb = new StringBuilder();
            for (var i = 0; i < s.Length; i++)
            {
                if (Char.IsLetterOrDigit(s[i])) sb.Append(s[i]);
            }

            var str = sb.ToString().ToLower(); ;

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
