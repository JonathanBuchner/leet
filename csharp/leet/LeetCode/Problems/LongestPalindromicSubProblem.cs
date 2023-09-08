using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace leet.LeetCode.Problems.LongestPalindromicSubProblem
{
    /*
     * Longest Palindromic Substring
     * 
     * Given a string s, return the longest palindromic substring in s.
     * 
     * https://leetcode.com/problems/longest-palindromic-substring/
     */
    public class Solution
    {
        private string s;

        public string LongestPalindrome(string s)
        {
            this.s = s;

            var longest = s[0].ToString();

            for(var i = 0; i < s.Length - 1; i++)
            {
                var current = PalindromicSubstring(i);

                longest = current.Length > longest.Length   ? current : longest;
            }

            return longest; 
        }

        private string PalindromicSubstring(int mid)
        {
            var p1 = mid;
            var p2 = mid;
            var longest = String.Empty;

            while (p1 >= 0 && p2 < s.Length)
            {
                if (s[p1] == s[p2])
                {
                    longest = s.Substring(p1, p2 - p1 + 1);
                    p1--;
                    p2++;
                }
                else
                {
                    break;
                }
            }

            p1 = mid;
            p2 = mid + 1;
            

            if (s[p1] == s[p2])
            {
                var current = String.Empty;

                while (p1 >= 0 && p2 < s.Length)
                {
                    if (s[p1] == s[p2])
                    {
                        current = s.Substring(p1, p2 - p1 + 1);
                        
                        p1--;
                        p2++;
                    }
                    else
                    {
                        break;
                    }
                }

                if( current.Length > longest.Length)
                {
                    longest = current;
                }
            }

            return longest;
        }
    }
}
