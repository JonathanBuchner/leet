using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.IsSubsequence
{
    /*
     * Is Subsequence
     * 
     * Given two strings s and t, return true if s is a subsequence of t, or false otherwise.
     * 
     * A subsequence of a string is a new string that is formed from the original string by deleting some (can be none) of the characters without disturbing the relative positions of the remaining characters. (i.e., "ace" is a subsequence of "abcde" while "aec" is not).
     * 
     * https://leetcode.com/problems/is-subsequence/description/
     */
    public class Solution
    {
        public bool IsSubsequence(string s, string t)
        {
            if (s.Length < 1)
            {
                return true;
            }

            var i = 0;
            var k = 0;

            while (i < t.Length)
            {
                if (s[k] == t[i])
                {
                    if (k == s.Length - 1)
                    {
                        return true;
                    }

                    k++;
                }

                i++;
            }

            return false;
        }
    }
}
