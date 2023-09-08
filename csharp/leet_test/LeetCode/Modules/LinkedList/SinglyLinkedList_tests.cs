using leet.LeetCode.Models;
using leet.LeetCode.Modules.LinkedList;
using leet_test.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leet_test.LeetCode.Modules.LinkedList
{
    [TestClass]
    public class SinglyLinkedList_tests
    {
        [TestMethod]
        public void Get_can_return_at_index()
        {

            var head = new LinkedListHelper().CreateSinglyLinkedList(new int[] { 1, 2, 3, 4 });
            var sut = new MySinglyLinkedList(head);

            var result1 = sut.Get(0);
            var result2 = sut.Get(2);
            var result3 = sut.Get(3);

            Assert.AreEqual(1, result1);
            Assert.AreEqual(3, result2);
            Assert.AreEqual(4, result3);
        }

        [TestMethod]
        public void AddAtHead_Can_Add()
        {
            var head = new LinkedListHelper().CreateSinglyLinkedList(new int[] { 1, 2, 3, 4 });
            var sut = new MySinglyLinkedList(head);

            sut.AddAtHead(0);
            var result = sut.Head.val;

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void AddAtTail_Can_Add()
        {
            ListNode tail;
            var head = new LinkedListHelper().CreateSinglyLinkedList(new int[] { 1, 2, 3, 4 }, out tail);
            var sut = new MySinglyLinkedList(head, tail);

            sut.AddAtTail(5);
            var result = sut.Tail.val;

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void AddAtIndex_Can_Add()
        {
            var head = new LinkedListHelper().CreateSinglyLinkedList(new int[] { 1, 2, 3, 4 });
            var sut = new MySinglyLinkedList(head);

            sut.AddAtIndex(3, 10);
            var result = sut.Get(3);

            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void Can_Delete_At_Index()
        {
            var head = new LinkedListHelper().CreateSinglyLinkedList(new int[] { 1, 2, 3, 4 });
            var sut = new MySinglyLinkedList(head);

            sut.DeleteAtIndex(1);
            var result = sut.Get(1);

            Assert.AreEqual(3, result);
        }
    }
}
