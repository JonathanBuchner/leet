using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using leet.LeetCode.Modules.LinkedList.RemoveLinkedListItem;
using leet_test.Helpers;

namespace leet_test.LeetCode.Modules.LinkedList
{
    [TestClass]
    public class RemoveLinkedListItem_tests
    {
        [TestMethod]
        public void RemoveElement_ShortListWithItemsToRemove_RemovesItems()
        {
            var helper = new LinkedListHelper();
            var sut = new Solution();
            var input_head = helper.CreateSinglyLinkedList(new int[] { 1, 2, 6, 3, 4, 5, 6 });
            var input_val = 6;
            var expected = helper.CreateSinglyLinkedList(new int[] { 1, 2, 3, 4, 5 });

            var actual = sut.RemoveElements(input_head, input_val);

            AssertLinkedList.AreEqualValue(expected, actual);
        }

        [TestMethod]
        public void RemoveElement_FirstItemNeedsRemoval_RemovesItems()
        {
            var helper = new LinkedListHelper();
            var sut = new Solution();
            var input_head = helper.CreateSinglyLinkedList(new int[] { 6, 1, 2, 6, 3, 4, 5, 6 });
            var input_val = 6;
            var expected = helper.CreateSinglyLinkedList(new int[] { 1, 2, 3, 4, 5 });

            var actual = sut.RemoveElements(input_head, input_val);

            AssertLinkedList.AreEqualValue(expected, actual);
        }

        [TestMethod]
        public void RemoveElement_EmptyList_ReturnNull()
        {
            var helper = new LinkedListHelper();
            var sut = new Solution();
            var input_head = helper.CreateSinglyLinkedList(new int[] { });
            var input_val = 7;
            var expected = helper.CreateSinglyLinkedList(new int[] { });

            var actual = sut.RemoveElements(input_head, input_val);

            AssertLinkedList.AreEqualValue(expected, actual);
        }

        [TestMethod]
        public void RemoveElement_ListWhereEveryItemNeedsRemoval_ReturnsNull()
        {
            var helper = new LinkedListHelper();
            var sut = new Solution();
            var input_head = helper.CreateSinglyLinkedList(new int[] { 7, 7, 7, 7 });
            var input_val = 7;
            var expected = helper.CreateSinglyLinkedList(new int[] { });

            var actual = sut.RemoveElements(input_head, input_val);

            AssertLinkedList.AreEqualValue(expected, actual);
        }
    }
}
