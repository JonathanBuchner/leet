using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using leet.LeetCode.Modules.HashTables.MyHashMap;

namespace leet_test.LeetCode.Modules.HashTables
{
    [TestClass]
    public class MyHashMap_tests
    {
        [TestMethod]
        public void Add_CanAddItem()
        {
            var sut = new MyHashMap();
            var key = 10;
            var val = 10;

            sut.Put(key, val);

            var actual = sut.Get(10);
            Assert.AreEqual(actual, key);
        }

        [TestMethod]
        public void Add_CanAddMultipeItems()
        {
            var sut = new MyHashMap();
            var items = new int[][]
            {
                new int[] { 10, 10},
                new int[] { 11, 12},
                new int[] { 12, 13},
                new int[] { 13, 14},
                new int[] { 15, 15},
                new int[] { 16, 16},
                new int[] { 17, 17},
            };
            var expected = 17;

            foreach(var item in items)
            {
                sut.Put(item[0], item[1]);
            }

            var actual = sut.Get(17);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_CanUpdateItems()
        {
            var sut = new MyHashMap();
            var items = new int[][]
            {
                new int[] { 10, 10},
                new int[] { 11, 12},
                new int[] { 12, 13},
                new int[] { 13, 14},
                new int[] { 15, 15},
                new int[] { 16, 16},
                new int[] { 17, 17},
            };
            foreach (var item in items)
            {
                sut.Put(item[0], item[1]);
            }
            var expected = 27;

            sut.Put(17, 27);

            var actual = sut.Get(17);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_CanAddAtCollisions()
        {
            var sut = new MyHashMap();
            var items = new int[][]
            {
                new int[] { 10, 10},
                new int[] { 11, 12},
                new int[] { 12, 13},
                new int[] { 13, 14},
                new int[] { 15, 15},
                new int[] { 16, 16},
                new int[] { 17, 17},
            };
            foreach (var item in items)
            {
                sut.Put(item[0], item[1]);
            }
            var expected = 117;


            var itemUpdates = new int[][]
            {
                new int[] { 110, 110},
                new int[] { 111, 112},
                new int[] { 112, 113},
                new int[] { 113, 114},
                new int[] { 115, 115},
                new int[] { 116, 116},
                new int[] { 117, 117},
            };
            foreach (var item in itemUpdates)
            {
                sut.Put(item[0], item[1]);
            }

            var actual = sut.Get(117);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Get_CanGetItem()
        {
            var sut = new MyHashMap();
            var key = 10;
            var val = 10;
            sut.Put(key, val);

            var actual = sut.Get(10);

            Assert.AreEqual(actual, key);
        }

        [TestMethod]
        public void Remove_CanRemoveItem()
        {
            var sut = new MyHashMap();
            var key = 10;
            var val = 10;
            var expected = -1;

            sut.Put(key, val);
            sut.Remove(key);

            var actual = sut.Get(key);
            Assert.AreEqual(expected, actual);
        }
    }
}
