using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.InterleavingString
{
    /*
     * Interleaving String
     * 
     * iven strings s1, s2, and s3, find whether s3 is formed by an interleaving of s1 and s2. An interleaving of two strings s and t is a configuration where they are divided into non-empty substrings 
     * 
     * https://leetcode.com/problems/interleaving-string/
     */
    public class Solution
    {
        public bool IsInterleave(string s1, string s2, string s3)
        {
            return Interleave(s1, s2, s3, 0, 0, 0);
        }
        private bool Interleave(string s1, string s2, string s3, int p1, int p2, int p3)
        {
            if (s1.Length + s2.Length != s3.Length)
            {
                return false;
            }

            while (p3 < s3.Length)
            {
                if (p1 < s1.Length && s1[p1] == s3[p3] && p2 < s2.Length && s2[p2] == s3[p3])
                {
                    ++p3;
                    return Interleave(s1, s2, s3, p1 + 1, p2, p3) || Interleave(s1, s2, s3, p1, p2 + 1, p3);
                }
                else if (p1 < s1.Length && s1[p1] == s3[p3])
                {
                    ++p1;
                }
                else if (p2 < s2.Length && s2[p2] == s3[p3])
                {
                    ++p2;
                }
                else
                {
                    return false;
                }
                    
                ++p3;
            }

            return true;
        }
    }
}
