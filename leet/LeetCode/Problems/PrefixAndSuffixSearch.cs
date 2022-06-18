using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Problems.PrefixAndSuffixSearch
{
    /*
     * Prefix and Suffix Search
     * 
     * Design a special dictionary with some words that searchs the words in it by a prefix and a suffix.
     * 
     * https://leetcode.com/problems/prefix-and-suffix-search/
     */
    public class WordFilter
    {
        private TrieNode suffixprefix = new TrieNode();

        public WordFilter(string[] words)
        {
            for(var i = 0; i < words.Length; i++)
            {
                var sb = new StringBuilder();
                sb.Append(words[i]);
                sb.Insert(0, "{");
                
                for(var k = words[i].Length - 1; k >= 0; k--)
                {
                    sb.Insert(0, words[i][k]);
                    var current = suffixprefix;

                    for(var j = 0; j < sb.Length; j++)
                    {
                        var pos = sb[j] - 'a';
                        if (current.Children[pos] == null)
                        {
                            current.Children[pos] = new TrieNode();
                        }
                        current = current.Children[pos];
                        current.Indexs.Add(i);
                    }
                }
            }
        }

        public int F(string prefix, string suffix)
        {
            var search = String.Concat(suffix, "{", prefix);
            var current = suffixprefix;

            for(var i = 0; i < search.Length; i++)
            {
                var pos = search[i] - 'a';
                if(current.Children[pos] == null)
                {
                    return -1;
                }
                current = current.Children[pos];
            }

            var answer = -1;

            foreach(var index in current.Indexs)
            {
                answer = Math.Max(answer, index);
            }

            return answer;
        }
    }
    public class TrieNode
    {
        public TrieNode[] Children { get; set; }
        public HashSet<int> Indexs { get; set; }
        public TrieNode()
        {
            Children = new TrieNode[27];
            Indexs = new HashSet<int>();
        }
    }
}
