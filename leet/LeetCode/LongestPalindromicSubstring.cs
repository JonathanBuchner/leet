using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.LongestPalindromicSubstring
{
    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            if (String.IsNullOrEmpty(s)) throw new ArgumentException();
            if (s.Length == 1) return s;

            var substringStartIndex = 0;
            var length = 0;

            for (var i = 0; i < s.Length; i++)
            {
                int index;
                int longest = GetLongestEvenAndOdd(s, i, out index);

                if (longest > length)
                {
                    substringStartIndex = index;
                    length = longest;
                }
            }

            return s.Substring(substringStartIndex, length);
        }

        private int GetLongestEvenAndOdd(string str, int position, out int index)
        {
            int indexOdd;
            int indexEven;
            var longestOdd = GetPalendromeLength(str, position, true, out indexOdd);
            var longestEven = GetPalendromeLength(str, position, false, out indexEven);

            if (longestEven > longestOdd)
            {
                index = indexEven;
                return longestEven;
            }
            else
            {
                index = indexOdd;
                return longestOdd;
            }
        }

        private int GetPalendromeLength(string str, int position, bool TestForOddPalendrome, out int left)
        {
            left = position;
            var right = TestForOddPalendrome ? position : position + 1;
            
            while (left >= 0 && right < str.Length)
            {
                if (str[left] != str[right]) break;

                left--;
                right++;
            }
            // One is added below because it's inclusive and get correct index
            left++;
            
            return right - left;
        }
    }
}
