using leet.LeetCode.Models;
using leet.LeetCode.Modules.LinkedList;
using leet.LeetCode.Modules.LinkedList.DoubleLinkedList;
using leet_test.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using DoubleListNode = leet.LeetCode.Modules.LinkedList.DoubleListNode;
using MyLinkedList = leet.LeetCode.Modules.LinkedList.DoubleLinkedList.MyLinkedList;

namespace leet_test.LeetCode.Modules.LinkedList
{
    [TestClass]
    public class DoubleLinkedList_tests
    {
        [TestMethod]
        public void Get_can_return_at_index()
        {
            DoubleListNode tail;
            var head = new LinkedListHelper().CreateDoubleLinkedList(new int[] { 1, 2, 3, 4 }, out tail);
            var sut = new MyLinkedList(head, tail);

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
            DoubleListNode tail;
            var head = new LinkedListHelper().CreateDoubleLinkedList(new int[] { 1, 2, 3, 4 }, out tail);
            var sut = new MyLinkedList(head, tail);

            sut.AddAtHead(0);
            var result = sut.Get(0);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void AddAtTail_Can_Add()
        {
            DoubleListNode tail;
            var head = new LinkedListHelper().CreateDoubleLinkedList(new int[] { 1, 2, 3, 4 }, out tail);
            var sut = new MyLinkedList(head, tail);

            sut.AddAtTail(5);
            var result = sut.Get(4);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void AddAtIndex_Can_Add()
        {
            DoubleListNode tail;
            var head = new LinkedListHelper().CreateDoubleLinkedList(new int[] { 1, 2, 3, 4 }, out tail);
            var sut = new MyLinkedList(head, tail);

            sut.AddAtIndex(3, 10);
            var result = sut.Get(3);

            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void Leet_Test_Case_One()
        {
            DoubleListNode tail;
            var head = new LinkedListHelper().CreateDoubleLinkedList(new int[] { }, out tail);
            var sut = new MyLinkedList(head, tail);

            sut.AddAtHead(1);
            sut.AddAtTail(3);
            sut.AddAtIndex(1, 2);
            var result1 = sut.Get(1);
            sut.DeleteAtIndex(1);
            var result2 = sut.Get(1);

            Assert.AreEqual(2, result1);
            Assert.AreEqual(3, result2);
        }

        [TestMethod]
        public void Leet_Test_Case_OneOne()
        {
            DoubleListNode tail;
            var head = new LinkedListHelper().CreateDoubleLinkedList(new int[] { }, out tail);
            var sut = new MyLinkedList(head, tail);

            // ["MyLinkedList","addAtHead","addAtHead","addAtHead","addAtIndex","deleteAtIndex","addAtHead","addAtTail","get","addAtHead","addAtIndex","addAtHead"]
            //[[],[7],[2],[1],[3,0],[2],[6],[4],[4],[4],[5,0],[6]]

            sut.AddAtHead(1);
            sut.DeleteAtIndex(0);
        }

        [TestMethod]
        public void Leet_Test_Case_Two()
        {
            DoubleListNode tail;
            var head = new LinkedListHelper().CreateDoubleLinkedList(new int[] { }, out tail);
            var sut = new MyLinkedList(head, tail);

            // ["MyLinkedList","addAtHead","addAtHead","addAtHead","addAtIndex","deleteAtIndex","addAtHead","addAtTail","get","addAtHead","addAtIndex","addAtHead"]
            //[[],[7],[2],[1],[3,0],[2],[6],[4],[4],[4],[5,0],[6]]

            sut.AddAtHead(7);
            sut.AddAtHead(2);
            sut.AddAtHead(1);
            sut.AddAtIndex(3, 0);
            sut.DeleteAtIndex(2);
            sut.AddAtHead(6);
            sut.AddAtTail(4);
            var actual = sut.Get(4);
            sut.AddAtHead(4);
            sut.AddAtIndex(5, 0);
            sut.AddAtHead(6);

            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void Leet_Test_Case_Ten()
        {
            DoubleListNode tail;
            var head = new LinkedListHelper().CreateDoubleLinkedList(new int[] { }, out tail);
            var sut = new MyLinkedList(head, tail);

           /* ["MyLinkedList","addAtHead","get","addAtHead","addAtHead","deleteAtIndex","addAtHead","get","get","get","addAtHead","deleteAtIndex"]
            [[],[4],[1],[1],[5],[3],[7],[3],[3],[3],[1],[4]]*/

            sut.AddAtHead(4);
            var actual = sut.Get(1);
            sut.AddAtHead(1);
            sut.AddAtHead(5);
            sut.DeleteAtIndex(3);
            sut.AddAtHead(7);
            var actual2 = sut.Get(3);
            var actual3 = sut.Get(3);
            var actual4 = sut.Get(3);
            sut.AddAtHead(1);
            sut.DeleteAtIndex(4);

            Assert.AreEqual(-1, actual);
            //
        }

        [TestMethod]
        public void Leet_Test_Case_SixtyThree()
        {
            DoubleListNode tail;
            var head = new LinkedListHelper().CreateDoubleLinkedList(new int[] { }, out tail);
            var sut = new MyLinkedList(head, tail);

            /* ["MyLinkedList","addAtHead","get","addAtHead","addAtHead","deleteAtIndex","addAtHead","get","get","get","addAtHead","deleteAtIndex"]
             [[],[4],[1],[1],[5],[3],[7],[3],[3],[3],[1],[4]]*/

            sut.AddAtIndex(1, 0);
            var actual = sut.Get(0);

            Assert.AreEqual(-1, actual);
        }
    }
}
