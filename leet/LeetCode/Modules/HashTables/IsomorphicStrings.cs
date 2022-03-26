using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Modules.HashTables.IsomorphicStrings
{
    public class Solution
    {
        /*
         * Isomorphic Strings
         * 
         * Given two strings s and t, determine if they are isomorphic. Two strings s and t are isomorphic if the characters in s can be replaced to get t.
         * 
         * https://leetcode.com/explore/learn/card/hash-table/184/comparison-with-other-data-structures/1117/
         */
        public bool IsIsomorphic(string s, string t)
        {
            if(s.Length != t.Length)
            {
                return false;
            }

            var dict = new Dictionary<char, char>();
            var set = new HashSet<char>();

            for (var i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    if (t[i] != dict[s[i]])
                    {
                        return false;
                    }
                }
                else if (set.Contains(t[i]))
                {
                    return false;
                }
                else
                {
                    dict.Add(s[i], t[i]);
                    set.Add(t[i]);
                }
            }

            return true;
        }
    }
}
