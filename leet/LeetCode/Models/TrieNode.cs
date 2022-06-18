using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Models
{
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
