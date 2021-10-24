using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using leet.LeetCode.Microsoft.LinkedLists.InteresectionOfTwoLinkedLists;
using leet_test.Helpers;
using leet.LeetCode.Models;

namespace leet_test.LeetCode.Microsoft.LinkedLists
{
    /*
     * These tests are faking the actual comparison between nodes by comparing the values.
     */
    [TestClass]
    public class InteresectionOfTwoLinkedLists_tests
    {
        [TestMethod]
        public void GetInterectionNode_ListsAreSimilarLength()
        {
            var sut = new Solution();
            var helper = new LinkedListHelper();
            var input_headA = helper.CreateSinglyLinkedList(new int[] { 4, 1, 8, 14, 19 });
            var input_headB = helper.CreateSinglyLinkedList(new int[] { 5, 6, 1, 8, 24, 29 });
            var expected = new ListNode(8);

            var actual = sut.GetIntersectionNode(input_headA, input_headB);

            Assert.AreEqual(expected.val, actual.val);
        }

        [TestMethod]
        public void GetInterectionNode_ListsAreDifferentLenghts()
        {
            var sut = new Solution();
            var helper = new LinkedListHelper();
            var input_headA = helper.CreateSinglyLinkedList(new int[] { 1, 9, 1, 2, 14 });
            var input_headB = helper.CreateSinglyLinkedList(new int[] { 3, 4, 4, 2, 24 });
            var expected = new ListNode(2);

            var actual = sut.GetIntersectionNode(input_headA, input_headB);

            Assert.AreEqual(expected.val, actual.val);
        }

        [TestMethod]
        public void GetInterectionNode_ListsDontIntersect()
        {
            var sut = new Solution();
            var helper = new LinkedListHelper();
            var input_headA = helper.CreateSinglyLinkedList(new int[] { 2, 6, 4 });
            var input_headB = helper.CreateSinglyLinkedList(new int[] { 1, 5 });
            ListNode expected = null;

            var actual = sut.GetIntersectionNode(input_headA, input_headB);

            Assert.AreEqual(expected.val, actual.val);
        }

        [TestMethod]
        public void GetInterectionNode_ListsAreNull()
        {
            var sut = new Solution();
            var helper = new LinkedListHelper();
            var input_headA = helper.CreateSinglyLinkedList(new int[] {});
            var input_headB = helper.CreateSinglyLinkedList(new int[] { });
            ListNode expected = null;

            var actual = sut.GetIntersectionNode(input_headA, input_headB);

            Assert.AreEqual(expected.val, actual.val);
        }

        [TestMethod]
        public void GetInterectionNode_AListIsNull()
        {
            var sut = new Solution();
            var helper = new LinkedListHelper();
            var input_headA = helper.CreateSinglyLinkedList(new int[] { });
            var input_headB = helper.CreateSinglyLinkedList(new int[] { 5, 6, 1, 8, 4, 5 });
            ListNode expected = null;

            var actual = sut.GetIntersectionNode(input_headA, input_headB);

            Assert.AreEqual(expected.val, actual.val);
        }
    }
}
