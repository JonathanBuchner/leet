using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using leet.LeetCode.Problems.InsertionSortList;
using leet_test.Helpers;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class InsertionSortList_tests
    {
        [TestMethod]
        public void InserstionSortList_Example1()
        {
            var sut = new Solution();
            var helper = new LinkedListHelper();
            var input = helper.CreateSinglyLinkedList(new int[] { 4, 2, 1, 3 });
            var expected = helper.CreateSinglyLinkedList(new int[] { 1, 2, 3, 4 });

            var actual = sut.InsertionSortList(input);

            AssertLinkedList.AreEqualValue(expected, actual);
        }

        [TestMethod]
        public void InserstionSortList_Example2()
        {
            var sut = new Solution();
            var helper = new LinkedListHelper();
            var input = helper.CreateSinglyLinkedList(new int[] { -1, 5, 3, 4, 0 });
            var expected = helper.CreateSinglyLinkedList(new int[] { -1, 0, 3, 4, 5 });

            var actual = sut.InsertionSortList(input);

            AssertLinkedList.AreEqualValue(expected, actual);
        }
    }
}
