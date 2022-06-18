using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.SymbolStore;
using System.Text;

namespace leet.LeetCode.Problems.Longest_String_Chain
{
    public class Solution
    {
        private Dictionary<string, int> dict = new Dictionary<string, int>();
        private HashSet<string> set = new HashSet<string>();

        public int LongestStrChain(string[] words)
        {
            var answer = 0;

            for(var i = 0; i < words.Length; i++)
            {
                set.Add(words[i]);
            }

            for (var i = 0; i < words.Length; i++)
            {
                answer = Math.Max(answer, DepthFirstSearch(words[i]));
            }

            return answer;
        }

        private int DepthFirstSearch(string word)
        {
            if(dict.ContainsKey(word))
            {
                return dict[word];
            }
            var depth = 1;

            for (var i = 0; i < word.Length; i++)
            {
                var sub = String.Concat(word.Substring(0,i), word.Substring(i+1));
                
                if(set.Contains(sub))
                {
                    var currentDepth = DepthFirstSearch(sub) + 1;
                    depth = Math.Max(depth, currentDepth);
                }
            }

            dict.Add(word, depth);

            return depth;
        }
    }
}
