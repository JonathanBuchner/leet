using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Modules.HashTables.DesignHashSet
{
    /*
     * Design HashSet
     * 
     * Design a HashSet without using any built-in hash table libraries.
     * 
     * https://leetcode.com/explore/learn/card/hash-table/182/practical-applications/1139/
     */
    public class MyHashSet
    {
        /** Initialize your data structure here. */
        private LinkedList<int>[] set = new LinkedList<int>[10];
        public MyHashSet()
        {
            for(var i = 0; i < set.Length; i++)
            {
                set[i] = new LinkedList<int>();
            }
        }

        public void Add(int key)
        {
            var hash = GetHash(key);
            
            if (!Contains(key, hash))
            {
                set[hash].AddLast(key);    
            }
        }

        public void Remove(int key)
        {
            var hash = GetHash(key);

            if (Contains(key, hash))
            {
                set[hash].Remove(key);
            }
        }

        /** Returns true if this set contains the specified element */
        public bool Contains(int key)
        {
            var hash = GetHash(key);
            
            return Contains(key, hash);
        }
        
        private bool Contains(int key, int hash)
        {
            return set[hash].Find(key) != null;
        }

        private int GetHash(int value)
        {
            return Math.Abs(value % 10);
        }
    }

    /**
     * Your MyHashSet object will be instantiated and called as such:
     * MyHashSet obj = new MyHashSet();
     * obj.Add(key);
     * obj.Remove(key);
     * bool param_3 = obj.Contains(key);
     */
}
