using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.PartitionList;
using leet_test.Helpers;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class PartitionList_tests
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var helper = new LinkedListHelper();
            var list = new int[]
            {
                1,4,3,2,5,2
            };
            var head = helper.CreateSinglyLinkedList(list);
            var value = 3;
            var outputlist = new int[]
            {
                1,2,2,4,3,5
            };
            var expected = helper.CreateSinglyLinkedList(outputlist);

            var actual = sut.Partition(head, 3);

            AssertLinkedList.AreEqualValue(expected, actual);
        }

        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var helper = new LinkedListHelper();
            var list = new int[]
            {
                2,1
            };
            var head = helper.CreateSinglyLinkedList(list);
            var value = 2;
            var outputlist = new int[]
            {
                1,2
            };
            var expected = helper.CreateSinglyLinkedList(outputlist);

            var actual = sut.Partition(head, 3);

            AssertLinkedList.AreEqualValue(expected, actual);
        }
    }
}
