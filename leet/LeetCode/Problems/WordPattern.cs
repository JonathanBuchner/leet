using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.WordPattern
{
    /*
     * Word Pattern
     * 
     * Given a pattern and a string s, find if s follows the same pattern.  Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in s.
     * 
     * https://leetcode.com/problems/word-pattern/description/
     */
    public class Solution
    {
        public bool WordPattern(string pattern, string s)
        {
            var dict = new Dictionary<char, string>();
            var set = new HashSet<string>();
            var words = s.Split(" ");

            if (pattern.Length != words.Length)
            {
                return false;
            }

            for (var i = 0; i < pattern.Length; i++)
            {
                if (dict.ContainsKey(pattern[i]))
                {
                    if (dict[pattern[i]] != words[i])
                    {
                        return false;
                    }
                }
                else
                {
                    if (set.Contains(words[i]))
                    {
                        return false;
                    }
                    else
                    {
                        dict.Add(pattern[i], words[i]);
                        set.Add(words[i]);
                    }
                }
            }

            return true;
        }
    }

}
