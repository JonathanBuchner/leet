using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Transactions;

namespace leet.LeetCode.Microsoft.TreesGraphs
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
            var list = new List<int[]>()
            {
                new int[] {a, 'a'},
                new int[] {b, 'b'},
                new int[] {c, 'c'},

            };
            var sb = new StringBuilder();
            var prev = new int[] { 0, 'z' };

            while (true)
            {
                list.Sort((a, b) => a[0].CompareTo(b[0]));
                var diff = 2;
                var curr = list[list.Count - 1];

                if (curr[1] == prev[1])
                {
                    curr = list[list.Count - 2];
                    diff = list[list.Count - 1][0] - list[list.Count - 2][0] > 0 ? 1 : 2;
                }


                if (curr[0] <= 0)
                {
                    break;
                }

                var i = Math.Min(2, Math.Min(curr[0], diff));

                curr[0] -= i;

                while (i > 0)
                {
                    sb.Append(Convert.ToChar(curr[1]));
                    i--;
                }

                prev = curr;
            }

            return sb.ToString();
        }
    }
}
