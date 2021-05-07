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
    public class MyLinkedList_tests
    {
        [TestMethod]
        public void Get_can_return_at_index()
        {
            
            var head = new LinkedListHelper().CreateSinglyLinkedList(new int[] { 1, 2, 3, 4 });
            var sut = new MyLinkedList(head);

            var result1 = sut.Get(1);
            var result2 = sut.Get(3);
            var result3 = sut.Get(4);

            Assert.AreEqual(1, result1);
            Assert.AreEqual(3, result2);
            Assert.AreEqual(4, result3);
        }

        [TestMethod]
        public void AddAtHead_Can_Add()
        {
            var head = new LinkedListHelper().CreateSinglyLinkedList(new int[] { 1, 2, 3, 4 });
            var sut = new MyLinkedList(head);

            sut.AddAtHead(0);
            var result = sut.Head.Val;

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void AddAtTail_Can_Add()
        {
            ListNode tail;
            var head = new LinkedListHelper().CreateSinglyLinkedList(new int[] { 1, 2, 3, 4 }, out tail);
            var sut = new MyLinkedList(head, tail);

            sut.AddAtTail(5);
            var result = sut.Tail.Val;

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void AddAtIndex_Can_Add()
        {
            var head = new LinkedListHelper().CreateSinglyLinkedList(new int[] { 1, 2, 3, 4 });
            var sut = new MyLinkedList(head);

            sut.AddAtIndex(3, 10);
            var result = sut.Get(3);

            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void Can_Delete_At_Index()
        {
            var head = new LinkedListHelper().CreateSinglyLinkedList(new int[] { 1, 2, 3, 4 });
            var sut = new MyLinkedList(head);

            sut.DeleteAtIndex(3);
            var result = sut.Get(3);

            Assert.AreEqual(4, result);
        }
    }
}
