using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Modules.HashTables.FirstUniqueCharacterinaString
{
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
