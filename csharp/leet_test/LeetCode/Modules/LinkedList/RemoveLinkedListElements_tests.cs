using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using leet.LeetCode.Modules.LinkedList.RemoveLinkedListElements;
using leet_test.Helpers;
using leet.LeetCode.Models;

namespace leet_test.LeetCode.Modules.LinkedList
{
    [TestClass]
    public class RemoveLinkedListElements_tests
    {
        [TestMethod]
        public void RemoveElements_NullList_ReturnsNewHead()
        {
            var sut = new Solution();
            ListNode input_head = null;
            var input_val = 0;
            ListNode expected = null;

            var actual = sut.RemoveElements(input_head, input_val);

            AssertLinkedList.AreEqualValue(expected, actual);
        }

        [TestMethod]
        public void RemoveElements_NoItemsToRemove_ReturnsHead()
        {
            var sut = new Solution();
            var helper = new LinkedListHelper();
            var input_head = helper.CreateSinglyLinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            var input_val = 0;
            var expected = helper.CreateSinglyLinkedList(new int[] { 1, 2, 3, 4, 5, 6 });

            var actual = sut.RemoveElements(input_head, input_val);

            AssertLinkedList.AreEqualValue(expected, actual);
        }

        [TestMethod]
        public void RemoveElements_RemoveFirst_ReturnsNewHead()
        {
            var sut = new Solution();
            var helper = new LinkedListHelper();
            var input_head = helper.CreateSinglyLinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            var input_val = 1;
            var expected = helper.CreateSinglyLinkedList(new int[] { 2, 3, 4, 5, 6 });

            var actual = sut.RemoveElements(input_head, input_val);

            AssertLinkedList.AreEqualValue(expected, actual);
        }

        [TestMethod]
        public void RemoveElements_RemoveOneInMiddle_ReturnsNewList()
        {
            var sut = new Solution();
            var helper = new LinkedListHelper();
            var input_head = helper.CreateSinglyLinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            var input_val = 4;
            var expected = helper.CreateSinglyLinkedList(new int[] { 1, 2, 3, 5, 6 });

            var actual = sut.RemoveElements(input_head, input_val);

            AssertLinkedList.AreEqualValue(expected, actual);
        }

        [TestMethod]
        public void RemoveElements_RemoveMultipleInMiddle_ReturnsNewList()
        {
            var sut = new Solution();
            var helper = new LinkedListHelper();
            var input_head = helper.CreateSinglyLinkedList(new int[] { 1, 4, 2, 3, 4, 5, 6 });
            var input_val = 4;
            var expected = helper.CreateSinglyLinkedList(new int[] { 1, 2, 3, 5, 6 });

            var actual = sut.RemoveElements(input_head, input_val);

            AssertLinkedList.AreEqualValue(expected, actual);
        }

        [TestMethod]
        public void RemoveElements_ItemAtEnd_RemoveEnd()
        {
            var sut = new Solution();
            var helper = new LinkedListHelper();
            var input_head = helper.CreateSinglyLinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            var input_val = 6;
            var expected = helper.CreateSinglyLinkedList(new int[] { 1, 2, 3, 4, 5 });

            var actual = sut.RemoveElements(input_head, input_val);

            AssertLinkedList.AreEqualValue(expected, actual);
        }

        [TestMethod]
        public void RemoveElements_AllItemsNeedRemoving_Null()
        {
            var sut = new Solution();
            var helper = new LinkedListHelper();
            var input_head = helper.CreateSinglyLinkedList(new int[] { 1, 1, 1, 1, 1, 1 });
            var input_val = 1;
            ListNode expected = null;

            var actual = sut.RemoveElements(input_head, input_val);

            AssertLinkedList.AreEqualValue(expected, actual);
        }
    }
}
