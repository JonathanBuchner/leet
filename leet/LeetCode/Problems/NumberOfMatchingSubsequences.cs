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
            var dict = new Dictionary<string, int>();

            foreach(var w in words)
            {
                if(dict.ContainsKey(w))
                {
                    ++dict[w];
                }
                else
                {
                    dict.Add(w, 1);
                }
            }

            var list = new List<string>();

            foreach(var w in dict)
            {
                list.Add(w.Key);
            }

            var word = new int[list.Count];

            for (var i = 0; i < s.Length; ++i)
            {
                for(var k = 0; k < list.Count; ++k)
                {
                    if (word[k] < list[k].Length && s[i] ==list[k][word[k]])
                    {
                        ++word[k];

                        if(word[k] == list[k].Length)
                        {
                            answer += dict[list[k]];
                        }
                    }

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
