using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Modules.Arrays.ImplementStrSTr
{
    /*
     * Implement strStr()
     * 
     * Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
     * 
     * https://leetcode.com/explore/learn/card/array-and-string/203/introduction-to-string/1161/
     */
    public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            if (needle.Length == 0)
            {
                return 0;
            }

            for (var i = 0; i < haystack.Length; ++i)
            {
                if (haystack[i] == needle[0])
                {
                    var h = i + 1;
                    var n = 1;
                    while (n < needle.Length && h < haystack.Length && haystack[h] == needle[n])
                    {
                        ++h;
                        ++n;
                    }

                    if (n == needle.Length)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }
    }
}
