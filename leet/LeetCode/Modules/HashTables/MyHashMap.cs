using System;
using System.Collections.Generic;
using System.Text;


namespace leet.LeetCode.Modules.HashTables.MyHashMap
{
    public class MyHashMap
    {
        //Initialize your data structure here.

        private int[] list = new int[100];
        public MyHashMap()
        {
            for (var i = 0; i < set.Length; i++)
            {
                set[i] = new LinkedList<Entry>();
            }
        }

        public void Add(int key, int val)
        {
            var hash = GetHash(key);

            if (!Contains(key, hash))
            {
                set[hash].AddLast(new Entry(key, val));
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

        // Returns true if this set contains the specified element
        public bool Contains(int key)
        {
            var hash = GetHash(key);

            return Contains(key, hash);
        }

        private bool Contains(int key, int hash)
        {
            return set[hash].Contains(x => x.Key) != null;
        }

        private int GetHash(int value)
        {
            return Math.Abs(value % 10);
        }
    }
}
