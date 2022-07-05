using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace leet.LeetCode.Microsoft.LongestHappyString
{
    /*
      * Longest Happy String
      * 
      * Given three integers a, b, and c, return the longest possible happy string. If there are multiple longest happy strings, return any of them. If there is no such string, return the empty string ""
      * 
      * https://leetcode.com/problems/longest-happy-string/
      */
    public class Solution
    {
        public string LongestDiverseString(int a, int b, int c)
        {
            var list = new List<(int, char)>()
            {
                (a, 'a'),
                (b, 'b'),
                (c, 'c'),
            };
            var sb = new StringBuilder();
            var prev = 'z';

            while (list.Count > 0)
            {
                list.Sort((a, b) => a.Item1.CompareTo(b.Item1));
                var curr = list[list.Count - 1];

                if (curr.Item2 == prev)
                {
                    if(list.Count == 1)
                    {
                        break;
                    }
                    else
                    {
                        curr = list[list.Count - 2];
                    }
                }

                var i = Math.Min(curr.Item1, 2);
                curr.Item1 -= i;

                while (i > 0)
                {
                    sb.Append(curr.Item2);
                    i--;
                }

                
                list.RemoveAll((a) => a.Item1 == 0);

                prev = curr.Item2;
            }

            return sb.ToString();
        }
    }
}
