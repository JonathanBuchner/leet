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
        private TrieNode prefixes = new TrieNode();
        private TrieNode suffixes = new TrieNode();

        public WordFilter(string[] words)
        {
            for(var index = 0; index < words.Length; index++)
            {
                var arr = words[index].ToCharArray();

                var cur = prefixes;
                cur.Indexs.Add(index);

                for(var i = 0; i < arr.Length; i++)
                {
                    var pos = arr[i] - 'a';
                    if(cur.Children[pos] == null)
                    {
                        cur.Children[pos] = new TrieNode();
                    }
                    cur = cur.Children[pos];
                    cur.Indexs.Add(index);
                }

                cur = suffixes;
                cur.Indexs.Add(index);

                for (var i = arr.Length - 1; i >= 0; i--)
                {
                    var pos = arr[i] - 'a';
                    if (cur.Children[pos] == null)
                    {
                        cur.Children[pos] = new TrieNode();
                    }
                    cur = cur.Children[pos];
                    cur.Indexs.Add(index);
                }
            }
        }

        public int F(string prefix, string suffix)
        {
            var answer = -1;
            return answer;
        }
    }
    public class TrieNode
    {
        public TrieNode[] Children { get; set; }
        public HashSet<int> Indexs { get; set; }
        public TrieNode()
        {
            Children = new TrieNode[26];
            Indexs = new HashSet<int>();
        }
    }
}
