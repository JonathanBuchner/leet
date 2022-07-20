using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.NumberOfMatchingSubsequences
{
    /*
     * Number of Matching Subsequences
     * 
     * Given a string s and an array of strings words, return the number of words[i] that is a subsequence of s.
     * 
     * https://leetcode.com/problems/number-of-matching-subsequences/
     */
    public class Solution
    {
        public int NumMatchingSubseq(string s, string[] words)
        {
            var answer = 0;
            var word = new int[words.Length]; 

            for (var i = 0; i < words.Length; ++i)
            {
                var x = 0;
                var y = 0;

                while(x < s.Length)
                {
                    if (s[x] == words[i][y])
                    {
                        ++y;
                        if (words[i].Length == y)
                        {
                            ++answer;
                            break;
                        }
                    }
                    ++x;
                }
            }

            return answer;
        }
    }
}

/*var memo = new bool[s.Length + 1, words[i].Length + 1];

for (var x = 1; x < s.Length; ++x)
{
    for (var y = 1; y < words[i].Length; ++y)
    {
        if (words[i][y] == s[x])
        {
            memo[x, y] = true;
        }
        else if ()
                    }
}*/
