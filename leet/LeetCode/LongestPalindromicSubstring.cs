using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.LongestPalindromicSubstring
{
    public class Solution
    {
        public string LongestPalindrome(string s)
        {
           

            for(var i = s.Length; i > 0; i--)
            {
                if (i == 1) return s[0].ToString();

                var left = 0;
                var right = i;

                while (left + right <= s.Length)
                {
                    var test = s.Substring(left, right);
                    
                    if (IsPalindrom(test))
                    {
                        return test;
                    }

                    left++;
                }
            }

            throw new NotSupportedException();
        }

        private bool IsPalindrom(string test)
        {
            var left = 0;
            var right = test.Length - 1;

            while (right > left)
            {
                if (test[right] != test[left]) return false;

                left++;
                right--;
            }

            return true;
        }
    }
}
