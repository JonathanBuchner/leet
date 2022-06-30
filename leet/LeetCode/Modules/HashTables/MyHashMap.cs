using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Modules.HashTables.MyHashMap
{
    public class MyHashMap
    {
        //Initialize your data structure here.
        private List<int[]>[] buckets = new List<int[]>[100];
        public MyHashMap()
        {

        }

        public void Put(int key, int value)
        {
            var hash = GetHash(key);

            if(buckets[hash] == null)
            {
                InitializeBucketWithItem(key, value, hash);
            }
            else if(Contains(key)) 
            {
                UpdateItemInBucket(key, value, hash);
            }
            else
            {
                AddItemInBucket(key, value, hash);
            }
        }

        public int Get(int key)
        {
            var hash = GetHash(key);

            if (Contains(key))
            {
                return buckets[hash].Find(x => x[0] == key)[1];
            }
            else
            {
                return -1;
            }
        }

        public void Remove(int key)
        {
            var hash = GetHash(key);

            if (Contains(key, hash))
            {
                buckets[hash].RemoveAll(x => x[0] == key);
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
            return buckets[hash] == null
                ? false
                : buckets[hash].Exists(x => x[0] == key);
        }

        private int GetHash(int value)
        {
            return Math.Abs(value % 100);
        }

        
        private void InitializeBucketWithItem(int key, int val, int hash)
        {
            buckets[hash] = new List<int[]>() { new int[] { key, val } };
        }

        private void AddItemInBucket(int key, int val, int hash)
        {
            buckets[hash].Add(new int[] { key, val });
        }

        private void UpdateItemInBucket(int key, int val, int hash)
        {
            buckets[hash].Find(x => x[0] == key)[1] = val;
        }
    }
}
