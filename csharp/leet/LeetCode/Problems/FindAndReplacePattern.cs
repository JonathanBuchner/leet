using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.FindAndReplacePattern
{
    /*
     * Find and Replace Pattern
     * 
     * Given a list of strings words and a string pattern, return a list of words[i] that match pattern. You may return the answer in any order.
     * 
     * https://leetcode.com/problems/find-and-replace-pattern/
     */
    public class Solution
    {
        public IList<string> FindAndReplacePattern(string[] words, string pattern)
        {

            var result = new List<string>();

            for (var i = 0; i < words.Length; ++i)
            {
                var letters = new BitArray(26, false);
                var dict = new Dictionary<char, char>();
                // word char, pattern char

                for (var k = 0; k < words[i].Length; ++k)
                {
                    if (dict.ContainsKey(words[i][k]))
                    {
                        if (pattern[k] != dict[words[i][k]])
                        {
                            break;
                        }
                    }
                    else
                    {
                        var index = pattern[k] - 'a';

                        if (letters[index])
                        {
                            break;
                        }
                        else
                        {
                            letters[index] = true;
                        }

                        dict.Add(words[i][k], pattern[k]);
                    }

                    if (k == words[i].Length - 1)
                    {
                        result.Add(words[i]);
                    }
                }
            }

            return result;
        }
    }
}
