using System;
using System.Collections;
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
            var memo = new Boolean[s1.Length + 1, s2.Length + 1];

            if(s1.Length + s2.Length != s3.Length)
            {
                return false;   
            }

            if(s3.Length == 0)
            {
                return true;
            }

            
            for(var i = 0; i <= s1.Length; ++i)
            {
                for(var k = 0; k <= s2.Length; ++k)
                {
                    var works = false;
                    
                    if(i == 0 && k== 0)
                    {
                        memo[0, 0] = true;
                        continue;
                    }

                    var s3char = s3[i + k - 1];

                    if (k != 0)
                    {
                        var s2char = s2[k - 1];
                        var left = memo[i, k - 1];
                        works = left && s2char == s3char; 
                    }

                    if(i != 0)
                    {
                        var s1char = s1[i - 1];
                        var above = memo[i - 1, k];
                        works |= above && s1char == s3char;
                    }

                    memo[i,k] = works;
                }
            }

            return memo[s1.Length, s2.Length];
        }
    }
}
