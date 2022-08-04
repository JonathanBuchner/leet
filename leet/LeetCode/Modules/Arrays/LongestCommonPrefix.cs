using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Modules.Arrays.LongestCommonPrefix
{
    /*
     * Longest Common Prefix
     * 
     * Write a function to find the longest common prefix string amongst an array of strings.  If there is no common prefix, return an empty string "".
     * 
     * https://leetcode.com/explore/learn/card/array-and-string/203/introduction-to-string/1162/
     */
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {

            if (strs.Length == 1)
            {
                return strs[0];
            }

            var sb = new StringBuilder();
            var p = 0;

            while (p < strs[0].Length)
            {
                for (var i = 1; i < strs.Length; ++i)
                {
                    if (p >= strs[i].Length || strs[0][p] != strs[i][p])
                    {
                        return sb.ToString();
                    }
                }

                sb.Append(strs[0][p]);
                ++p;
            }

            return sb.ToString();
        }
    }
}
