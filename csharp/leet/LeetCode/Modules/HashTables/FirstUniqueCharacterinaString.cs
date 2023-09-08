using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Modules.HashTables.FirstUniqueCharacterinaString
{
    /*
     *  First Unique Character in a String
     * 
     * Given a string s, find the first non-repeating character in it and return its index. If it does not exist, return -1.
     * 
     * https://leetcode.com/explore/learn/card/hash-table/184/comparison-with-other-data-structures/1120/
     */
    public class Solution
    {
        public int FirstUniqChar(string s)
        {
            var dict = new Dictionary<char, int>();

            for (var i = 0; i < s.Length; i++)
            {
                if(dict.ContainsKey(s[i]))
                {
                    dict[s[i]]++;
                }
                else
                {
                    dict.Add(s[i], 1);
                }
            }

            for (var i = 0; i < s.Length; i++)
            {
                if (dict[s[i]] == 1)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
