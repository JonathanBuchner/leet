using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using leet.LeetCode.Modules.HashTables.DesignHashSet;

namespace leet_test.LeetCode.Modules.HashTables
{
    [TestClass]
    public class MyHashSet_tests
    {
        [TestMethod]
        [DataRow(0,true)]
        [DataRow(1, true)]
        [DataRow(9, true)]
        [DataRow(2, true)]
        [DataRow(-1, true)]
        [DataRow(Int32.MaxValue, true)]
        [DataRow(Int32.MinValue, true)]
        public void Add_SingleItem_CanAdd(int input, bool expected)
        {
            var sut = new MyHashSet();

            sut.Add(input);
            var actual = sut.Contains(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        //[DataRow(0, 0, true)]
        [DataRow(1, 0, false)]
        [DataRow(-1, -1, true)]
        [DataRow(Int32.MaxValue, Int32.MaxValue, true)]
        [DataRow(Int32.MinValue, Int32.MaxValue, false)]
        public void Contains(int input, int isInHash, bool expected)
        {
            var sut = new MyHashSet();
            sut.Add(input);

            var actual = sut.Contains(isInHash);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(new int[] { 1, 2, 4, 5, 6, 7,})]
        [DataRow(new int[] { -1, 2, -4, 5, -6, 7 })]
        [DataRow(new int[] { 0, 0, 10, 20, 30, 1 })]
        [DataRow(new int[] { int.MinValue, int.MinValue, int.MinValue, int.MaxValue, int.MaxValue, })]
        public void Add_AddCollisions_ReturnValue(int[] inputs)
        {
            var sut = new MyHashSet();

            foreach(var input in inputs)
            {
                sut.Add(input);
            }

            foreach(var input in inputs)
            {
                var doesContain = sut.Contains(input);
                Assert.IsTrue(doesContain);
            }
        }

        [TestMethod]
        [DataRow(new int[] { 1, 2, 4, 5, 6, 7, }, 0, false )]
        [DataRow(new int[] { -1, 2, -4, 5, -6, 7 }, -1, true)]
        [DataRow(new int[] { 0, 0, 10, 20, 30, 1 }, 40, false)]
        [DataRow(new int[] { int.MinValue, int.MinValue, int.MinValue, int.MaxValue, int.MaxValue, }, 1, false)]
        public void Add_AddCollisions_ReturnsFalseIfDoesNotContain(int[] arrange, int input, bool expected)
        {
            var sut = new MyHashSet();
            foreach (var val in arrange)
            {
                sut.Add(val);
            }
            
            var actual = sut.Contains(input);
            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_SingleItem_CanRemove()
        {
            var sut = new MyHashSet();
            var input = 1;
            var expected = false;
            sut.Add(input);

            sut.Remove(input);
            
            var actual = sut.Contains(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_MultipleItems_CanRemove()
        {
            var sut = new MyHashSet();
            var inputs = new int[] { 1, 2, 10, 20, 40, -15, Int32.MaxValue, Int32.MinValue};
            var expected = false;
            foreach(var input in inputs)
            {
                sut.Add(input);
            }

            foreach(var input in inputs)
            {
                sut.Remove(input);
            }

            foreach(var input in inputs)
            {
                var actual = sut.Contains(input);
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
